using GymManagementSystem.Controllers;
using GymManagementSystem.Models;
using System;
using System.Windows.Forms;

namespace GymManagementSystem.Views
{
    public partial class EditMembershipPlanForm : Form
    {
        private MembershipPlanController membershipPlanController;
        private MembershipPlan selectedPlan;

        // ✅ Constructor when editing a plan
        public EditMembershipPlanForm(MembershipPlan plan)
        {
            InitializeComponent();

            membershipPlanController = new MembershipPlanController();
            selectedPlan = plan;

            LoadPlanData();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        // ✅ Load selected plan into form fields
        private void LoadPlanData()
        {
            if (selectedPlan == null) return;

            planNameTextBox.Text = selectedPlan.Name;
            planDurationTextBox.Text = selectedPlan.DurationDays.ToString();
            planPriceTextBox.Text = selectedPlan.Price.ToString();
            descriptionTextBox.Text = selectedPlan.Description;
        }

        private void saveButton_Click_1(object sender, EventArgs e)
        {
            if (selectedPlan == null)
            {
                MessageBox.Show("No plan selected.");
                return;
            }

            // Basic validation
            if (string.IsNullOrWhiteSpace(planNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(planDurationTextBox.Text) ||
                string.IsNullOrWhiteSpace(planPriceTextBox.Text))
            {
                MessageBox.Show("Please fill all required fields.");
                return;
            }

            try
            {
                // Update object
                selectedPlan.Name = planNameTextBox.Text;
                selectedPlan.DurationDays = int.Parse(planDurationTextBox.Text);
                selectedPlan.Price = decimal.Parse(planPriceTextBox.Text);
                selectedPlan.Description = descriptionTextBox.Text;

                // Save to database
                membershipPlanController.UpdatePlan(selectedPlan);

                MessageBox.Show("Plan updated successfully!");

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating plan: " + ex.Message);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}