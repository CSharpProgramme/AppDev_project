using GymManagementSystem.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GymManagementSystem.Views
{
    public class TrainerUpsertForm : Form
    {
        private readonly bool isEditMode;
        private readonly Trainer existingTrainer;

        private readonly TextBox firstNameTextBox = new TextBox();
        private readonly TextBox lastNameTextBox = new TextBox();
        private readonly TextBox emailTextBox = new TextBox();
        private readonly TextBox phoneTextBox = new TextBox();
        private readonly TextBox specializationTextBox = new TextBox();
        private readonly TextBox hourlyRateTextBox = new TextBox();
        private readonly Button saveButton = new Button();
        private readonly Button cancelButton = new Button();

        public Trainer TrainerData { get; private set; }

        public TrainerUpsertForm()
        {
            isEditMode = false;
            InitializeUi();
        }

        public TrainerUpsertForm(Trainer trainer)
        {
            isEditMode = trainer != null;
            existingTrainer = trainer;
            InitializeUi();

            if (isEditMode)
            {
                firstNameTextBox.Text = existingTrainer.FName;
                lastNameTextBox.Text = existingTrainer.LName;
                emailTextBox.Text = existingTrainer.Email;
                phoneTextBox.Text = existingTrainer.Phone;
                specializationTextBox.Text = existingTrainer.Specialization;
                hourlyRateTextBox.Text = existingTrainer.HourlyRate.ToString("0.##");
            }
        }

        private void InitializeUi()
        {
            Text = isEditMode ? "Edit Trainer" : "Add Trainer";
            StartPosition = FormStartPosition.CenterParent;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Width = 450;
            Height = 420;

            Controls.Add(CreateLabel("First Name", 20, 20));
            firstNameTextBox.SetBounds(160, 20, 240, 28);
            Controls.Add(firstNameTextBox);

            Controls.Add(CreateLabel("Last Name", 20, 65));
            lastNameTextBox.SetBounds(160, 65, 240, 28);
            Controls.Add(lastNameTextBox);

            Controls.Add(CreateLabel("Email", 20, 110));
            emailTextBox.SetBounds(160, 110, 240, 28);
            Controls.Add(emailTextBox);

            Controls.Add(CreateLabel("Phone", 20, 155));
            phoneTextBox.SetBounds(160, 155, 240, 28);
            Controls.Add(phoneTextBox);

            Controls.Add(CreateLabel("Specialization", 20, 200));
            specializationTextBox.SetBounds(160, 200, 240, 28);
            Controls.Add(specializationTextBox);

            Controls.Add(CreateLabel("Hourly Rate", 20, 245));
            hourlyRateTextBox.SetBounds(160, 245, 240, 28);
            Controls.Add(hourlyRateTextBox);

            saveButton.Text = isEditMode ? "Update" : "Add";
            saveButton.SetBounds(160, 300, 110, 35);
            saveButton.Click += SaveButton_Click;
            Controls.Add(saveButton);

            cancelButton.Text = "Cancel";
            cancelButton.SetBounds(290, 300, 110, 35);
            cancelButton.Click += (s, e) => DialogResult = DialogResult.Cancel;
            Controls.Add(cancelButton);
        }

        private static Label CreateLabel(string text, int x, int y)
        {
            return new Label
            {
                Text = text,
                Left = x,
                Top = y + 4,
                Width = 130
            };
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(firstNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(lastNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(emailTextBox.Text))
            {
                MessageBox.Show("First name, last name and email are required.");
                return;
            }

            if (!decimal.TryParse(hourlyRateTextBox.Text.Trim(), out decimal hourlyRate) || hourlyRate < 0)
            {
                MessageBox.Show("Please enter a valid hourly rate.");
                return;
            }

            TrainerData = new Trainer
            {
                TrainerId = isEditMode ? existingTrainer.TrainerId : 0,
                FName = firstNameTextBox.Text.Trim(),
                LName = lastNameTextBox.Text.Trim(),
                Email = emailTextBox.Text.Trim(),
                Phone = phoneTextBox.Text.Trim(),
                Specialization = specializationTextBox.Text.Trim(),
                HourlyRate = hourlyRate
            };

            DialogResult = DialogResult.OK;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // TrainerUpsertForm
            // 
            this.ClientSize = new System.Drawing.Size(303, 297);
            this.Name = "TrainerUpsertForm";
            this.ResumeLayout(false);

        }
    }
}
