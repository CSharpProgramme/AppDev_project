using GymManagementSystem.Controllers;
using GymManagementSystem.Models;
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
    public partial class DashboardControl : UserControl
    {
        private MemberController memberController;


        public DashboardControl()
        {
            InitializeComponent();
            memberController = new MemberController();
            LoadRecentMembers();
            LoadTotalMembers();
        }

        private void LoadRecentMembers()
        {
            List<Member> members = memberController.GetAllMembers();

            recentMemberDataGridView.AutoGenerateColumns = false;
            recentMemberDataGridView.Columns.Clear();

            recentMemberDataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "ID", DataPropertyName = "MemberID" });
            recentMemberDataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "First Name", DataPropertyName = "FName" });
            recentMemberDataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Last Name", DataPropertyName = "LName" });
            recentMemberDataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Email", DataPropertyName = "Email", AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            });
            recentMemberDataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Phone", DataPropertyName = "Phone" });
            recentMemberDataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Join Date", DataPropertyName = "JoinDate" });
            recentMemberDataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Status", DataPropertyName = "Status" });

            recentMemberDataGridView.DataSource = members;
        }

        private void LoadTotalMembers()
        {
            memberNumLabel.Text = memberController.GetTotalMembers().ToString();
        }
    }
}
