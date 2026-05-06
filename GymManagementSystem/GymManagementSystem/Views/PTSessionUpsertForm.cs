using GymManagementSystem.Controllers;
using GymManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GymManagementSystem.Views
{
    public partial class PTSessionUpsertForm : Form
    {
        private readonly MemberController memberController = new MemberController();
        private readonly TrainerController trainerController = new TrainerController();
        private readonly PTSessionController sessionController = new PTSessionController();

        private PTSession currentSession;
        private bool isEditMode = false;

        //construct create
        public PTSessionUpsertForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            ConfigureMemberGrid();
            ConfigureTrainerGrid();

            LoadMembers();
            LoadTrainers();

            createButton.Text = "Create Session";
        }

        //construct edit
        public PTSessionUpsertForm(PTSession session) : this()
        {
            currentSession = session;
            isEditMode = true;

            createButton.Text = "Update Session";

            this.Load += PTSessionUpsertForm_LoadEdit;
        }

        //grid config
        private void ConfigureMemberGrid()
        {
            memberDataGridView.AutoGenerateColumns = false;
            memberDataGridView.Columns.Clear();

            memberDataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "MemberID", HeaderText = "ID" });
            memberDataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "FName", HeaderText = "First Name", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            memberDataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "LName", HeaderText = "Last Name", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });

            memberDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            memberDataGridView.MultiSelect = false;
            memberDataGridView.ReadOnly = true;
        }

        private void ConfigureTrainerGrid()
        {
            trainerDataGridView.AutoGenerateColumns = false;
            trainerDataGridView.Columns.Clear();

            trainerDataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "TrainerId", HeaderText = "ID" });
            trainerDataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "FName", HeaderText = "First Name", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            trainerDataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "LName", HeaderText = "Last Name", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });

            trainerDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            trainerDataGridView.MultiSelect = false;
            trainerDataGridView.ReadOnly = true;
        }

        //load data
        private void LoadMembers()
        {
            memberDataGridView.DataSource = memberController.GetAllMembers();
        }

        private void LoadTrainers()
        {
            trainerDataGridView.DataSource = trainerController.GetAllTrainers();
        }

        //search
        private void searchMembersButton_Click(object sender, EventArgs e)
        {
            string search = memberTextBox.Text.Trim();

            if (string.IsNullOrEmpty(search))
                LoadMembers();
            else
                memberDataGridView.DataSource = memberController.SearchMembers(search);
        }

        private void searchTrainersButton_Click(object sender, EventArgs e)
        {
            string search = trainerTextBox.Text.Trim();

            if (string.IsNullOrEmpty(search))
            {
                LoadTrainers();
            }
            else
            {
                var list = trainerController.GetAllTrainers()
                        .Where(t =>
                         t.FName.ToLower().Contains(search.ToLower()) || t.LName.ToLower().Contains(search.ToLower()))
                        .ToList();

                trainerDataGridView.DataSource = list;
            }
        }

        //get selected
        private Member GetSelectedMember()
        {
            if (memberDataGridView.SelectedRows.Count == 0)
                return null;

            return memberDataGridView.SelectedRows[0].DataBoundItem as Member;
        }

        private Trainer GetSelectedTrainer()
        {
            if (trainerDataGridView.SelectedRows.Count == 0)
                return null;

            return trainerDataGridView.SelectedRows[0].DataBoundItem as Trainer;
        }

        //edit load fix
        private void PTSessionUpsertForm_LoadEdit(object sender, EventArgs e)
        {
            PreselectData();
        }

        //preselect
        private void PreselectData()
        {
            if (currentSession == null) return;

            memberDataGridView.ClearSelection();

            foreach (DataGridViewRow row in memberDataGridView.Rows)
            {
                if (row.DataBoundItem is Member m && m.MemberID == currentSession.MemberID)
                {
                    row.Selected = true;
                    memberDataGridView.CurrentCell = row.Cells[0];
                    break;
                }
            }

            trainerDataGridView.ClearSelection();

            foreach (DataGridViewRow row in trainerDataGridView.Rows)
            {
                if (row.DataBoundItem is Trainer t && t.TrainerId == currentSession.TrainerID)
                {
                    row.Selected = true;
                    trainerDataGridView.CurrentCell = row.Cells[0];
                    break;
                }
            }

            scheduledAtPicker.Value = currentSession.ScheduledAt;
            timeTextBox.Text = currentSession.ScheduledAt.ToString("HH:mm");
            durationTextBox.Text = currentSession.DurationMinutes.ToString();
        }

        //create update
        private void createButton_Click(object sender, EventArgs e)
        {
            try
            {
                Member member = GetSelectedMember();
                Trainer trainer = GetSelectedTrainer();

                if (member == null || trainer == null)
                {
                    MessageBox.Show("Select member and trainer");
                    return;
                }

                DateTime datePart = scheduledAtPicker.Value.Date;
                TimeSpan timePart;

                if (!TimeSpan.TryParse(timeTextBox.Text, out timePart))
                {
                    MessageBox.Show("Invalid time format (HH:mm)");
                    return;
                }

                DateTime fullDateTime = datePart.Add(timePart);

                string status = fullDateTime < DateTime.Now ? "Completed" : "Scheduled";

                PTSession session = new PTSession
                {
                    MemberID = member.MemberID,
                    TrainerID = trainer.TrainerId,
                    ScheduledAt = fullDateTime,
                    DurationMinutes = int.Parse(durationTextBox.Text),
                    Status = status
                };

                if (isEditMode)
                {
                    session.PTSessionID = currentSession.PTSessionID;
                    sessionController.UpdateSession(session);
                }
                else
                {
                    sessionController.AddSession(session);
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PTSessionUpsertForm_Load(object sender, EventArgs e)
        {
            
        }
        
    }
}