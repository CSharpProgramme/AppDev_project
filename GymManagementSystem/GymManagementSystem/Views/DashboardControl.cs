using GymManagementSystem.Controllers;
using GymManagementSystem.Localization;
using GymManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace GymManagementSystem
{
    public partial class DashboardControl : UserControl
    {
        private readonly MemberController memberController = new MemberController();
        private readonly StaffController staffController = new StaffController();
        private readonly RevenueController revenueController = new RevenueController();

        public DashboardControl()
        {
            InitializeComponent();
            LoadRecentMembers();
            LoadStats();
        }

        private void LoadRecentMembers()
        {
            List<Member> members = memberController.GetAllMembers();

            recentMemberDataGridView.AutoGenerateColumns = false;
            recentMemberDataGridView.Columns.Clear();

            recentMemberDataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "ID",        DataPropertyName = "MemberID", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            recentMemberDataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "First Name", DataPropertyName = "FName",    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            recentMemberDataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Last Name",  DataPropertyName = "LName",    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            recentMemberDataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Email",      DataPropertyName = "Email",    AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells });
            recentMemberDataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Phone",      DataPropertyName = "Phone",    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            recentMemberDataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Join Date",  DataPropertyName = "JoinDate", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            recentMemberDataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Status",     DataPropertyName = "Status",   AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });

            recentMemberDataGridView.DataSource = members;
        }

        private void LoadStats()
        {
            memberNumLabel.Text     = memberController.GetTotalMembers().ToString();
            activePLanNumLabel.Text = memberController.GetActiveSubscriptionCount().ToString();
            revenueNumLabel.Text    = revenueController.GetRevenueThisMonth().ToString("C");
            employeeNumLabel.Text   = staffController.GetTotalStaff().ToString();
        }

        private void DashboardControl_Load(object sender, EventArgs e)
        {
            SetGridLanguage();
        }

        public void RefreshLanguage()
        {
            SetGridLanguage();
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
