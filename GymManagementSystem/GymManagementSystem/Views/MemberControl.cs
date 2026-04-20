using GymManagementSystem.Controllers;
using GymManagementSystem.Models;
using GymManagementSystem.Views;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GymManagementSystem
{
    public partial class MemberControl : UserControl
    {
        private MemberController memberController;

        public MemberControl()
        {
            InitializeComponent();

            //disable edit button until a row from datagridview is selected
            editButton.Enabled = false;

            //create a new MemberController when the control is loaded
            memberController = new MemberController();

            //placeholder for search box
            searchMemTextBox.Text = "Search a Member...";
            searchMemTextBox.ForeColor = Color.Gray;

            LoadMembers();

            // Deselect all rows on load
            memberDataGridView.ClearSelection();
        }

        // Enable edit button when a row is selected
        private void memberDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            editButton.Enabled = memberDataGridView.SelectedRows.Count > 0;
        }

        //fetch all members from the controller and display them in datagridview
        private void LoadMembers()
        {
            List<Member> members = memberController.GetAllMembers();

            // Turn off auto generated columns
            memberDataGridView.AutoGenerateColumns = false;

            // Clear existing columns to avoid duplicates on refresh
            memberDataGridView.Columns.Clear();

            // Add columns manually matching your Member model properties
            memberDataGridView.Columns.Add(new DataGridViewTextBoxColumn { 
                Name = "MemberID",
                HeaderText = "ID", 
                DataPropertyName = "MemberID" });

            memberDataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "First Name", DataPropertyName = "FName" });
            memberDataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Last Name", DataPropertyName = "LName" });
            memberDataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Email", DataPropertyName = "Email" });
            memberDataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Phone", DataPropertyName = "Phone" });
            memberDataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Date of Birth", DataPropertyName = "DateOfBirth" });
            memberDataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Join Date", DataPropertyName = "JoinDate" });
            memberDataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Emergency Contact", DataPropertyName = "EmergencyContactName" });
            memberDataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Emergency Phone", DataPropertyName = "EmergencyContactPhone" });
            memberDataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Status", DataPropertyName = "Status" });

            memberDataGridView.DataSource = members;
        }

        //when user clicks on the search box, it clears the placeholder
        private void clickTextBox(object sender, EventArgs e)
        {
            if (searchMemTextBox.Text == "Search a Member...")
            {
                searchMemTextBox.Text = "";
                searchMemTextBox.ForeColor = Color.Black;
            }
        }

        //restore back the placeholder, when user clicks somewhere else
        private void clickAwayTextBox(object sender, EventArgs e)
        {
            if (searchMemTextBox.Text == "")
            {
                searchMemTextBox.Text = "Search a Member...";
                searchMemTextBox.ForeColor = Color.Gray;
            }
        }

        //when user types in the search box, it filters the members in datagridview
        private void searchMembtn_Click(object sender, EventArgs e)
        {
            string searchText = searchMemTextBox.Text.Trim();

            // If the search box is empty or has the placeholder, load all members
            if (searchText == "" || searchText == "Search a Member...")
            {
                LoadMembers();
                return;
            }

            List<Member> filtered = memberController.SearchMembers(searchText);
            memberDataGridView.DataSource = filtered;
        }

        private void btnRegisterMember_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            // Refresh the member list when the form closes
            registerForm.FormClosed += (s, args) => LoadMembers();
            registerForm.ShowDialog();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            // Get the selected column name member ID from the grid
            int selectedId = (int)memberDataGridView.SelectedRows[0].Cells["MemberID"].Value;

            // Fetch the full member object from the controller
            Member member = memberController.GetMemberByID(selectedId);

            // Open the edit form with the selected member
            EditMemberForm editForm = new EditMemberForm(member);

            // Refresh the member list when the form closes
            editForm.FormClosed += (s, args) => LoadMembers();
            editForm.ShowDialog();
        }
    }
}
