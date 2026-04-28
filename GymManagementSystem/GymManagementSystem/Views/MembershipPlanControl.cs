using GymManagementSystem.Controllers;
using GymManagementSystem.Models;
using GymManagementSystem.Views;
using GymManagementSystem.Views.AllRegisterForms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GymManagementSystem
{
    public partial class MembershipPlanControl : UserControl
    {
        private MembershipPlanController planController;

        public MembershipPlanControl()
        {
            InitializeComponent();

            planController = new MembershipPlanController();

            ConfigureGridColumns();
            InitializePlanActions();

            LoadPlans();
            membershipPlanDataGridView.ClearSelection();
        }

        private void RegisterPlanButton_Click(object sender, EventArgs e)
        {
            MembershipPlanForm registerForm = new MembershipPlanForm();
            registerForm.FormClosed += (s, args) => LoadPlans();
            registerForm.ShowDialog();
        }

        private void InitializePlanActions()
        {
            editPlanButton.Text = "Edit Plan";
            editPlanButton.Left = RegisterPlanButton.Right + 10;
            editPlanButton.Top = RegisterPlanButton.Top;
            editPlanButton.Enabled = false;
            editPlanButton.Click += EditPlanButton_Click;

            deletePlanButton.Text = "Delete Plan";
            deletePlanButton.Left = editPlanButton.Right + 10;
            deletePlanButton.Top = RegisterPlanButton.Top;
            deletePlanButton.Enabled = false;
            deletePlanButton.Click += DeletePlanButton_Click;

            Controls.Add(editPlanButton);
            Controls.Add(deletePlanButton);

            membershipPlanDataGridView.SelectionChanged += MembershipPlanDataGridView_SelectionChanged;
        }

        private void ConfigureGridColumns()
        {
            membershipPlanDataGridView.AutoGenerateColumns = false;
            membershipPlanDataGridView.Columns.Clear();

            membershipPlanDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "PlanId",
                HeaderText = "ID",
                DataPropertyName = "PlanId"
            });

            membershipPlanDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Plan Name",
                DataPropertyName = "PlanName"
            });

            membershipPlanDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Duration",
                DataPropertyName = "DurationMonths"
            });

            membershipPlanDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Price",
                DataPropertyName = "Price"
            });

            membershipPlanDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Description",
                DataPropertyName = "Description"
            });

            membershipPlanDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            membershipPlanDataGridView.MultiSelect = false;
            membershipPlanDataGridView.ReadOnly = true;
        }

        private void LoadPlans()
        {
            List<MembershipPlan> plans = planController.GetAllPlans();

            membershipPlanDataGridView.DataSource = null;
            membershipPlanDataGridView.DataSource = plans;
        }

        private MembershipPlan GetSelectedPlan()
        {
            if (membershipPlanDataGridView.SelectedRows.Count == 0)
                return null;

            return membershipPlanDataGridView.SelectedRows[0].DataBoundItem as MembershipPlan;
        }

        private void MembershipPlanDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            bool hasSelection = GetSelectedPlan() != null;
            editPlanButton.Enabled = hasSelection;
            deletePlanButton.Enabled = hasSelection;
        }

        private void EditPlanButton_Click(object sender, EventArgs e)
        {
            var selectedPlan = GetSelectedPlan();

            if (selectedPlan == null)
            {
                MessageBox.Show("Select a plan first.");
                return;
            }

            MembershipPlanForm form = new MembershipPlanForm(); //selectedPlan
            form.FormClosed += (s, args) => LoadPlans();
            form.ShowDialog();
        }

        private void DeletePlanButton_Click(object sender, EventArgs e)
        {
            var selectedPlan = GetSelectedPlan();

            if (selectedPlan == null)
            {
                MessageBox.Show("Select a plan first.");
                return;
            }

            var confirm = MessageBox.Show(
                $"Delete plan '{selectedPlan.Name}'?",
                "Confirm",
                MessageBoxButtons.YesNo);

            if (confirm != DialogResult.Yes) return;

            planController.DeletePlan(selectedPlan.PlanId);
            LoadPlans();
        }
    }
}