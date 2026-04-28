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
    public partial class TrainerControl : UserControl
    {
        private readonly TrainerController trainerController = new TrainerController();
        public TrainerControl()
        {
            InitializeComponent();
            ConfigureGridColumns();
            LoadTrainers();
        }

        private void trainerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.trainerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gymManagementDBDataSet);
        }

        private void ConfigureGridColumns()
        {
            trainerDataGridView.AutoGenerateColumns = false;
            trainerDataGridView.Columns.Clear();

            trainerDataGridView.Columns.Add(new DataGridViewTextBoxColumn { Name = "TrainerId", HeaderText = "ID", DataPropertyName = "TrainerId", ReadOnly = true });
            trainerDataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "First Name", DataPropertyName = "FName" });
            trainerDataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Last Name", DataPropertyName = "LName" });
            trainerDataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Email", DataPropertyName = "Email" });
            trainerDataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Phone", DataPropertyName = "Phone" });
            trainerDataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Specialization", DataPropertyName = "Specialization" });
            trainerDataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Hourly Rate", DataPropertyName = "HourlyRate" });
            trainerDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            trainerDataGridView.MultiSelect = false;
            trainerDataGridView.ReadOnly = true;
        }

        private void TrainerControl_Load(object sender, EventArgs e)
        {
            LoadTrainers();
        }

        private void LoadTrainers()
        {
            List<Trainer> trainers = trainerController.GetAllTrainers();
            trainerDataGridView.DataSource = null;
            trainerDataGridView.DataSource = trainers;
            TrainerDataGridView_SelectionChanged(null, EventArgs.Empty);
        }

        private Trainer GetSelectedTrainer()
        {
            if (trainerDataGridView.SelectedRows.Count == 0)
            {
                return null;
            }

            return trainerDataGridView.SelectedRows[0].DataBoundItem as Trainer;
        }

        private void TrainerDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            bool hasSelection = GetSelectedTrainer() != null;
            editTrainerButton.Enabled = hasSelection;
            deleteTrainerButton.Enabled = hasSelection;
        }
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
            {
                return;
            }

            trainerController.DeleteTrainer(selectedTrainer.TrainerId);
            LoadTrainers();
        }

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
                {
                    return;
                }

                trainerController.UpdateTrainer(form.TrainerData);
                LoadTrainers();
            }
        }

        private void RegisterTrainerButton_Click(object sender, EventArgs e)
        {
            using (TrainerUpsertForm form = new TrainerUpsertForm())
            {
                if (form.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                trainerController.AddTrainer(form.TrainerData);
                LoadTrainers();
            }
        }
    }
}
