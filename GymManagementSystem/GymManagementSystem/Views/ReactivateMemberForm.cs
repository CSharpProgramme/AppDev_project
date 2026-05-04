using GymManagementSystem.Controllers;
using GymManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GymManagementSystem.Views
{
    public partial class ReactivateMemberForm : Form
    {
        private readonly ActivationController activationController = new ActivationController();
        private readonly Member member;
        private List<MembershipPlan> plans;

        public ReactivateMemberForm(Member member)
        {
            InitializeComponent();
            this.member = member;
            lblMemberName.Text = $"Activating: {member.FName} {member.LName}";
            dtpStart.Value = DateTime.Today;
            LoadPlans();
            LoadMethods();
        }

        private void LoadPlans()
        {
            plans = activationController.GetAllPlans();
            cmbPlan.Items.Clear();
            foreach (var plan in plans)
                cmbPlan.Items.Add($"{plan.Name} — ${plan.Price:F2} / {plan.DurationDays} days");

            if (cmbPlan.Items.Count > 0)
                cmbPlan.SelectedIndex = 0;
        }

        private void LoadMethods()
        {
            cmbMethod.Items.Clear();
            cmbMethod.Items.AddRange(new object[] { "cash", "credit_card", "debit_card", "online", "bank_transfer" });
            cmbMethod.SelectedIndex = 0;
        }

        private void cmbPlan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPlan.SelectedIndex >= 0 && cmbPlan.SelectedIndex < plans.Count)
                lblAmount.Text = $"${plans[cmbPlan.SelectedIndex].Price:F2}";
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (cmbPlan.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a membership plan.", "Validation");
                return;
            }

            MembershipPlan selectedPlan = plans[cmbPlan.SelectedIndex];

            try
            {
                activationController.ReactivateMember(
                    member.MemberID,
                    selectedPlan.PlanId,
                    cmbMethod.SelectedItem.ToString(),
                    dtpStart.Value,
                    Auth.UserId
                );

                MessageBox.Show(
                    $"{member.FName} {member.LName} has been activated on the {selectedPlan.Name} plan.\nPayment of ${selectedPlan.Price:F2} recorded.",
                    "Activated");

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error activating member: " + ex.Message, "Error");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
