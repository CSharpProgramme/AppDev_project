using GymManagementSystem.Controllers;
using GymManagementSystem.Models;
using GymManagementSystem.Views;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GymManagementSystem
{
    public partial class TrainerControl : UserControl
    {
        private readonly TrainerController trainerController = new TrainerController();

        public TrainerControl()
        {
            InitializeComponent();

            ConfigureGridColumns();

            trainerDataGridView.SelectionChanged += TrainerDataGridView_SelectionChanged;

            LoadTrainers();
        }

        // SAVE NAVIGATOR (if you still use dataset designer stuff)
        private void trainerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.trainerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gymManagementDBDataSet);
        }

        // CONFIGURE GRID
        private void ConfigureGridColumns()
        {
            trainerDataGridView.AutoGenerateColumns = false;
            trainerDataGridView.Columns.Clear();

            trainerDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TrainerId",
                HeaderText = "ID",
                DataPropertyName = "TrainerId",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            trainerDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "First Name",
                DataPropertyName = "FName",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            trainerDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Last Name",
                DataPropertyName = "LName",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            trainerDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Email",
                DataPropertyName = "Email",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            });

            trainerDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Phone",
                DataPropertyName = "Phone",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            trainerDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Specialization",
                DataPropertyName = "Specialization",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            trainerDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Hourly Rate",
                DataPropertyName = "HourlyRate",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            trainerDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            trainerDataGridView.MultiSelect = false;
            trainerDataGridView.ReadOnly = true;
        }

        // LOAD DATA
        private void LoadTrainers()
        {
            List<Trainer> trainers = trainerController.GetAllTrainers();

            trainerDataGridView.DataSource = null;
            trainerDataGridView.DataSource = trainers;

            trainerDataGridView.ClearSelection();

            if (trainerDataGridView.Rows.Count > 0)
            {
                trainerDataGridView.Rows[0].Selected = true;
            }

            UpdateButtonState();
        }

        // GET SELECTED
        private Trainer GetSelectedTrainer()
        {
            if (trainerDataGridView.SelectedRows.Count == 0)
                return null;

            return trainerDataGridView.SelectedRows[0].DataBoundItem as Trainer;
        }

        // BUTTON STATE CONTROL
        private void UpdateButtonState()
        {
            bool hasSelection = GetSelectedTrainer() != null;

            editTrainerButton.Enabled = hasSelection;
            deleteTrainerButton.Enabled = hasSelection;
        }

        // SELECTION CHANGED
        private void TrainerDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            UpdateButtonState();
        }

        // DELETE
        private void deleteTrainerButton_Click(object sender, EventArgs e)
        {
            Trainer selectedTrainer = GetSelectedTrainer();

            if (selectedTrainer == null)
            {
                MessageBox.Show("Please select a trainer to delete.");
                return;
            }

            DialogResult confirm = MessageBox.Show(
                $"Delete trainer '{selectedTrainer.FName} {selectedTrainer.LName}'?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes)
                return;

            trainerController.DeleteTrainer(selectedTrainer.TrainerId);

            LoadTrainers();
        }

        // EDIT
        private void editTrainerButton_Click(object sender, EventArgs e)
        {
            Trainer selectedTrainer = GetSelectedTrainer();

            if (selectedTrainer == null)
            {
                MessageBox.Show("Please select a trainer to edit.");
                return;
            }

            using (TrainerUpsertForm form = new TrainerUpsertForm(selectedTrainer))
            {
                if (form.ShowDialog() != DialogResult.OK)
                    return;

                trainerController.UpdateTrainer(form.TrainerData);
            }

            LoadTrainers();
        }

        // ADD
        private void RegisterTrainerButton_Click(object sender, EventArgs e)
        {
            using (TrainerUpsertForm form = new TrainerUpsertForm())
            {
                if (form.ShowDialog() != DialogResult.OK)
                    return;

                trainerController.AddTrainer(form.TrainerData);
            }

            LoadTrainers();
        }

        // OPEN PT SESSIONS
        private void viewPTSessionButton_Click(object sender, EventArgs e)
        {
            PTSessionForm form = new PTSessionForm();
            form.ShowDialog();
        }
    }
}