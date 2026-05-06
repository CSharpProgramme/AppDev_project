using GymManagementSystem.Controllers;
using GymManagementSystem.Localization;
using GymManagementSystem.Models;
using GymManagementSystem.Views;
using GymManagementSystem.Views.AllRegisterForms;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace GymManagementSystem
{
    public partial class MembershipPlanControl : UserControl
    {
        private readonly MembershipPlanController planController;

        public MembershipPlanControl()
        {
            InitializeComponent();

            planController = new MembershipPlanController();

            ConfigureGridColumns();

            LoadPlans();
            membershipPlanDataGridView.ClearSelection();
        }

        private void ConfigureGridColumns()
        {
            membershipPlanDataGridView.AutoGenerateColumns = false;
            membershipPlanDataGridView.Columns.Clear();

            membershipPlanDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Plan ID",
                DataPropertyName = "PlanId"
            });

            membershipPlanDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Plan Name",
                DataPropertyName = "name"
            });

            membershipPlanDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Duration",
                DataPropertyName = "DurationDays"
            });

            membershipPlanDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Price",
                DataPropertyName = "price"
            });

            membershipPlanDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Description",
                DataPropertyName = "description",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

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
            SetGridLanguage();
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

        private void RegisterPlanButton_Click_1(object sender, EventArgs e)
        {
            RegisterMembershipPlanForm registerForm = new RegisterMembershipPlanForm();
            registerForm.FormClosed += (s, args) => LoadPlans();
            registerForm.ShowDialog();
        }

        private void editPlanButton_Click_1(object sender, EventArgs e)
        {
            var selectedPlan = GetSelectedPlan();

            if (selectedPlan == null)
            {
                MessageBox.Show("Select a plan first.");
                return;
            }

            EditMembershipPlanForm form = new EditMembershipPlanForm(selectedPlan);
            form.FormClosed += (s, args) => LoadPlans();
            form.ShowDialog();
        }

        private void deletePlanButton_Click_1(object sender, EventArgs e)
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
        public void RefreshLanguage()
        {
            SetGridLanguage();
        }

        private void SetGridLanguage()
        {
            string lang = Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName;
            SetColumnHeader("PlanId", MainPanelLocalization.TranslateFromEnglish("Plan ID", lang));
            SetColumnHeader("name", MainPanelLocalization.TranslateFromEnglish("Name", lang));
            SetColumnHeader("DurationDays", MainPanelLocalization.TranslateFromEnglish("Duration Name", lang));
            SetColumnHeader("price", MainPanelLocalization.TranslateFromEnglish("price", lang));
            SetColumnHeader("description", MainPanelLocalization.TranslateFromEnglish("description", lang));
     
        }

        private void SetColumnHeader(string dataPropertyName, string headerText)
        {
            foreach (DataGridViewColumn column in membershipPlanDataGridView.Columns)
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