using GymManagementSystem.Controllers;
using GymManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace GymManagementSystem
{
    /// UserControl that handles member check-in and check-out.
    /// Staff search for a member, select them from the results,
    /// then click Check In or Check Out to record their attendance.
    public partial class AttendanceControl : UserControl
    {
        // MemberController handles searching members from the database
        private readonly MemberController memberController = new MemberController();

        // AttendanceController handles check-in, check-out, and getting who's currently in
        private readonly AttendanceController attendanceController = new AttendanceController();

        public AttendanceControl()
        {
            InitializeComponent();

            // AutoGenerateColumns = false tells each grid to use the columns defined
            // in the designer instead of auto-creating columns from the data source
            dgvSearchResults.AutoGenerateColumns = false;
            dgvCurrentlyIn.AutoGenerateColumns = false;
            dgvAttendanceLog.AutoGenerateColumns = false;

            LoadCurrentlyIn();   // Show who's already in the gym on load
            LoadAttendanceLog(); // Show today's full attendance history on load
        }

        /// Fetches and displays all members currently inside the gym.
        /// Called on load and after every check-in/check-out to keep the list fresh.
        private void LoadCurrentlyIn()
        {
            // GetCurrentlyIn returns a DataTable — DataGridView can bind to it directly
            DataTable dt = attendanceController.GetCurrentlyIn();
            dgvCurrentlyIn.DataSource = dt;
        }

        /// Fetches and displays today's full attendance history —
        /// everyone who checked in today, whether they have left or not.
        /// Called on load and refreshed after every check-in/check-out.
        private void LoadAttendanceLog()
        {
            // GetTodayAttendanceLog returns all today's records including checked-out members
            DataTable dt = attendanceController.GetTodayAttendanceLog();
            dgvAttendanceLog.DataSource = dt;
        }

        /// Returns the member ID of the row selected in dgvSearchResults.
        /// Returns -1 if nothing is selected.
        private int GetSelectedMemberId()
        {
            if (dgvSearchResults.SelectedRows.Count == 0)
                return -1;

            // Read the MemberID cell value from the selected row
            return (int)dgvSearchResults.SelectedRows[0].Cells["MemberID"].Value;
        }

        /// Searches for members by name, email, or phone using the text in the search box.
        /// Results are displayed in dgvSearchResults.
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = textBox1.Text.Trim();

            // Don't search if the box is empty
            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Please enter a name, email or phone to search.", "Search");
                return;
            }

            // SearchMembers queries MEMBER table using LIKE — returns a list of matching members
            List<Member> results = memberController.SearchMembers(searchText);
            dgvSearchResults.DataSource = results;

            if (results.Count == 0)
                MessageBox.Show("No members found.", "Search");
        }

        /// Checks in the selected member.
        /// Creates an ATTENDANCE record with check_in = now and check_out = NULL.
        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            int memberId = GetSelectedMemberId();

            // Make sure a row is selected before proceeding
            if (memberId == -1)
            {
                MessageBox.Show("Please search and select a member first.", "Check In");
                return;
            }

            try
            {
                // CheckIn validates active status and no double check-in internally
                attendanceController.CheckIn(memberId);
                MessageBox.Show("Member checked in successfully.", "Check In");

                // Refresh both grids — currently in gets the new member, log gets the new entry
                LoadCurrentlyIn();
                LoadAttendanceLog();
            }
            catch (Exception ex)
            {
                // Show the specific error (e.g. "already checked in" or "not active")
                MessageBox.Show(ex.Message, "Error");
            }
        }

        /// Checks out the selected member.
        /// Finds their open ATTENDANCE record and sets check_out = now.
        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            int memberId = GetSelectedMemberId();

            // Make sure a row is selected before proceeding
            if (memberId == -1)
            {
                MessageBox.Show("Please search and select a member first.", "Check Out");
                return;
            }

            try
            {
                // CheckOut validates that the member is currently checked in internally
                attendanceController.CheckOut(memberId);
                MessageBox.Show("Member checked out successfully.", "Check Out");

                // Refresh both grids — member disappears from currently in, log shows check-out time
                LoadCurrentlyIn();
                LoadAttendanceLog();
            }
            catch (Exception ex)
            {
                // Show the specific error (e.g. "not currently checked in")
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
