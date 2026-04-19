using GymManagementSystem.Controllers;
using GymManagementSystem.Models;
using GymManagementSystem.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagementSystem
{
    public partial class MemberControl : UserControl
    {
        private MemberController memberController;

        public MemberControl()
        {
            InitializeComponent();

            //create a new MemberController when the control is loaded
            memberController = new MemberController();

            //placeholder for search box
            searchMemTextBox.Text = "Search a Member...";
            searchMemTextBox.ForeColor = Color.Gray;

            LoadMembers();
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
            memberDataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "ID", DataPropertyName = "MemberID" });
            memberDataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "First Name", DataPropertyName = "FName" });
            memberDataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Last Name", DataPropertyName = "LName" });
            memberDataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Email", DataPropertyName = "Email" });
            memberDataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Phone", DataPropertyName = "Phone" });
            memberDataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Date of Birth", DataPropertyName = "DateOfBirth" });
            memberDataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Join Date", DataPropertyName = "JoinDate" });
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
    }
}
