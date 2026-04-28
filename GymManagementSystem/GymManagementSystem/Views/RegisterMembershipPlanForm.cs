using GymManagementSystem.Controllers;
using GymManagementSystem.Models;
using System;
using System.Windows.Forms;

namespace GymManagementSystem.Views
{
    public partial class RegisterMembershipPlanForm : Form
    {
        private MembershipPlanController membershipPlanController;

        public RegisterMembershipPlanForm()
        {
            InitializeComponent();

            membershipPlanController = new MembershipPlanController();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        // ✅ SAVE BUTTON
        private void saveButton_Click(object sender, EventArgs e)
        {
            // Validation
            if (string.IsNullOrWhiteSpace(planNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(planDurationTextBox.Text) ||
                string.IsNullOrWhiteSpace(planPriceTextBox.Text))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            try
            {
                // Create new plan
                MembershipPlan newPlan = new MembershipPlan
                {
                    Name = planNameTextBox.Text,
                    DurationDays = int.Parse(planDurationTextBox.Text),
                    Price = decimal.Parse(planPriceTextBox.Text),
                    Description = descriptionTextBox.Text
                };

                // Save to database
                membershipPlanController.AddPlan(newPlan);

                MessageBox.Show("Membership plan added successfully!");

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding plan: " + ex.Message);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}