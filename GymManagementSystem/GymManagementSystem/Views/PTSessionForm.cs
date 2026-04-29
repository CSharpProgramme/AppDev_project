using GymManagementSystem.Controllers;
using GymManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GymManagementSystem.Views
{
    public partial class PTSessionForm : Form
    {
        private readonly PTSessionController sessionController = new PTSessionController();

        public PTSessionForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            ConfigureGrid();
            LoadSessions();

            editSessionButton.Enabled = false;
            cancelSessionButton.Enabled = false;

            sessionDataGridView.SelectionChanged += SessionDataGridView_SelectionChanged;
        }

        // GRID CONFIG
        private void ConfigureGrid()
        {
            sessionDataGridView.AutoGenerateColumns = false;
            sessionDataGridView.Columns.Clear();

            sessionDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Session ID",
                DataPropertyName = "PTSessionID",
                ReadOnly = true
            });

            sessionDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Member ID",
                DataPropertyName = "MemberID"
            });

            sessionDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Trainer ID",
                DataPropertyName = "TrainerID"
            });

            sessionDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Scheduled At",
                DataPropertyName = "ScheduledAt"
            });

            sessionDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Duration (min)",
                DataPropertyName = "DurationMinutes"
            });

            sessionDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Status",
                DataPropertyName = "Status"
            });

            sessionDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            sessionDataGridView.MultiSelect = false;
            sessionDataGridView.ReadOnly = true;
        }

        // LOAD DATA
        private void LoadSessions()
        {
            List<PTSession> sessions = sessionController.GetAllSessions();

            sessionDataGridView.DataSource = null;
            sessionDataGridView.DataSource = sessions;

            sessionDataGridView.ClearSelection();
        }

        // GET SELECTED
        private PTSession GetSelectedSession()
        {
            if (sessionDataGridView.SelectedRows.Count == 0)
                return null;

            return sessionDataGridView.SelectedRows[0].DataBoundItem as PTSession;
        }

        // ENABLE BUTTONS
        private void SessionDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            bool hasSelection = GetSelectedSession() != null;

            editSessionButton.Enabled = hasSelection;
            cancelSessionButton.Enabled = hasSelection;
        }

        private void editSessionButton_Click(object sender, EventArgs e)
        {
            PTSession selected = GetSelectedSession();

            if (selected == null)
            {
                MessageBox.Show("Please select a session.");
                return;
            }

            PTSessionUpsertForm form = new PTSessionUpsertForm();//selected
            form.FormClosed += (s, args) => LoadSessions();
            form.ShowDialog();
        }

        private void cancelSessionButton_Click(object sender, EventArgs e)
        {
            PTSession selected = GetSelectedSession();

            if (selected == null)
            {
                MessageBox.Show("Please select a session.");
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "Cancel this session?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes)
                return;

            sessionController.DeleteSession(selected.PTSessionID);
            LoadSessions();
        }

        private void createSessionButton_Click(object sender, EventArgs e)
        {
            PTSessionUpsertForm form = new PTSessionUpsertForm();
            form.FormClosed += (s, args) => LoadSessions();
            form.ShowDialog();
        }
    }
}