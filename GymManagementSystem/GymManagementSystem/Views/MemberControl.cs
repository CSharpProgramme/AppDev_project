using GymManagementSystem.Controllers;
using GymManagementSystem.Localization;
using GymManagementSystem.Models;
using GymManagementSystem.Views;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
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
            deleteButton.Enabled = false;

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
            bool hasSelection = memberDataGridView.SelectedRows.Count > 0;
            editButton.Enabled = hasSelection;
            deleteButton.Enabled = hasSelection;
        }


        private void SetGridLanguage()
        {
            string lang = Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName;
            SetColumnHeader("MemberID", MainPanelLocalization.TranslateFromEnglish("ID", lang));
            SetColumnHeader("FName", MainPanelLocalization.TranslateFromEnglish("First Name", lang));
            SetColumnHeader("LName", MainPanelLocalization.TranslateFromEnglish("Last Name", lang));
            SetColumnHeader("Email", MainPanelLocalization.TranslateFromEnglish("Email", lang));
            SetColumnHeader("Phone", MainPanelLocalization.TranslateFromEnglish("Phone", lang));
            SetColumnHeader("JoinDate", MainPanelLocalization.TranslateFromEnglish("Join Date", lang));
            SetColumnHeader("Status", MainPanelLocalization.TranslateFromEnglish("Status", lang));
            SetColumnHeader("EmergencyContactName", MainPanelLocalization.TranslateFromEnglish("Emergency Contact Name", lang));
            SetColumnHeader("EmergencyContactPhone", MainPanelLocalization.TranslateFromEnglish("Emergency Contact Phone", lang));
        }
        private void SetColumnHeader(string dataPropertyName, string headerText)
        {
            foreach (DataGridViewColumn column in memberDataGridView.Columns)
            {
                if (string.Equals(column.DataPropertyName, dataPropertyName, StringComparison.OrdinalIgnoreCase))
                {
                    column.HeaderText = headerText;
                    break;
                }
            }
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

            memberDataGridView.Columns.Add(new DataGridViewTextBoxColumn { Name = "FName",                 HeaderText = "First Name",         DataPropertyName = "FName" });
            memberDataGridView.Columns.Add(new DataGridViewTextBoxColumn { Name = "LName",                 HeaderText = "Last Name",          DataPropertyName = "LName" });
            memberDataGridView.Columns.Add(new DataGridViewTextBoxColumn { Name = "Email",                 HeaderText = "Email",              DataPropertyName = "Email" });
            memberDataGridView.Columns.Add(new DataGridViewTextBoxColumn { Name = "Phone",                 HeaderText = "Phone",              DataPropertyName = "Phone" });
            memberDataGridView.Columns.Add(new DataGridViewTextBoxColumn { Name = "DateOfBirth",           HeaderText = "Date of Birth",      DataPropertyName = "DateOfBirth" });
            memberDataGridView.Columns.Add(new DataGridViewTextBoxColumn { Name = "JoinDate",              HeaderText = "Join Date",          DataPropertyName = "JoinDate" });
            memberDataGridView.Columns.Add(new DataGridViewTextBoxColumn { Name = "EmergencyContactName",  HeaderText = "Emergency Contact",  DataPropertyName = "EmergencyContactName" });
            memberDataGridView.Columns.Add(new DataGridViewTextBoxColumn { Name = "EmergencyContactPhone", HeaderText = "Emergency Phone",    DataPropertyName = "EmergencyContactPhone" });
            memberDataGridView.Columns.Add(new DataGridViewTextBoxColumn { Name = "Status",                HeaderText = "Status",             DataPropertyName = "Status" });

            memberDataGridView.DataSource = members;
            SetGridLanguage();
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
            GymManagementSystem.Localization.MainPanelLocalization.ApplyToForm(registerForm);
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
            GymManagementSystem.Localization.MainPanelLocalization.ApplyToForm(editForm);
            editForm.FormClosed += (s, args) => LoadMembers();
            editForm.ShowDialog();
        }
        public void RefreshLanguage()
        {
            SetGridLanguage();
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (memberDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a member to delete.");
                return;
            }

            int selectedId = (int)memberDataGridView.SelectedRows[0].Cells["MemberID"].Value;
            string selectedName = memberDataGridView.SelectedRows[0].Cells["FName"].Value + " " +
                                  memberDataGridView.SelectedRows[0].Cells["LName"].Value;

            DialogResult confirm = MessageBox.Show(
                $"Delete member '{selectedName}'?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes)
            {
                return;
            }

            try
            {
                memberController.DeleteMember(selectedId);
                LoadMembers();
                memberDataGridView.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to delete member: " + ex.Message, "Error");
            }
        }
    }
}
