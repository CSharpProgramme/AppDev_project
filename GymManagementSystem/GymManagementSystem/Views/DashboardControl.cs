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

            recentMemberDataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "ID", DataPropertyName = "MemberID", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            recentMemberDataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "First Name", DataPropertyName = "FName", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            recentMemberDataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Last Name", DataPropertyName = "LName", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            recentMemberDataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Email", DataPropertyName = "Email", AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells });
            recentMemberDataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Phone", DataPropertyName = "Phone", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            recentMemberDataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Join Date", DataPropertyName = "JoinDate", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            recentMemberDataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Status", DataPropertyName = "Status", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });

            recentMemberDataGridView.DataSource = members;
        }

        private void LoadTotalMembers()
        {
            memberNumLabel.Text = memberController.GetTotalMembers().ToString();
        }

        private void DashboardControl_Load(object sender, EventArgs e)
        {
            SetGridLanguage();
        }
        private void SetGridLanguage()
        {
            bool isFrench = System.Threading.Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName == "fr";

            SetColumnHeader("MemberID", isFrench ? "ID Membre" : "ID");
            SetColumnHeader("FName", isFrench ? "Prenom" : "First Name");
            SetColumnHeader("LName", isFrench ? "Nom" : "Last Name");
            SetColumnHeader("Email", "Email");
            SetColumnHeader("Phone", isFrench ? "Telephone" : "Phone");
            SetColumnHeader("JoinDate", isFrench ? "Date d'inscription" : "Join Date");
            SetColumnHeader("Status", isFrench ? "Statut" : "Status");
        }

        private void SetColumnHeader(string dataPropertyName, string headerText)
        {
            foreach (DataGridViewColumn column in recentMemberDataGridView.Columns)
            {
                if (string.Equals(column.DataPropertyName, dataPropertyName, StringComparison.OrdinalIgnoreCase))
                {
                    column.HeaderText = headerText;
                    break;
                }
            }
        }
    }
}
