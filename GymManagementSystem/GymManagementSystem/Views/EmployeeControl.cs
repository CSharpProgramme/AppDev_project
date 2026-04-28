using GymManagementSystem.Controllers;
using GymManagementSystem.Models;
using GymManagementSystem.Views;
using GymManagementSystem.Views.AllRegisterForms;
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
    public partial class EmployeeControl : UserControl
    {
        private readonly StaffController staffController = new StaffController();
        private readonly Button editStaffButton = new Button();
        private readonly Button deleteStaffButton = new Button();

        public EmployeeControl()
        {
            InitializeComponent();
            InitializeStaffActions();
            ConfigureGridColumns();
        }

        private void staffBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.staffBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gymManagementDBDataSet);

        }

        private void RegisterMemberButton_Click(object sender, EventArgs e)
        {
            EmployeeRegisterForm registerForm = new EmployeeRegisterForm();
            // Keep the grid in sync after adding an employee.
            registerForm.FormClosed += (s, args) => LoadStaff();
            registerForm.ShowDialog();
        }

        private void InitializeStaffActions()
        {
            editStaffButton.Text = "Edit Staff";
            editStaffButton.Width = 120;
            editStaffButton.Height = RegisterMemberButton.Height;
            editStaffButton.Left = RegisterMemberButton.Right + 12;
            editStaffButton.Top = RegisterMemberButton.Top;
            editStaffButton.Enabled = false;
            editStaffButton.Click += EditStaffButton_Click;

            deleteStaffButton.Text = "Delete Staff";
            deleteStaffButton.Width = 120;
            deleteStaffButton.Height = RegisterMemberButton.Height;
            deleteStaffButton.Left = editStaffButton.Right + 12;
            deleteStaffButton.Top = RegisterMemberButton.Top;
            deleteStaffButton.Enabled = false;
            deleteStaffButton.Click += DeleteStaffButton_Click;

            Controls.Add(editStaffButton);
            Controls.Add(deleteStaffButton);

            staffDataGridView.SelectionChanged += StaffDataGridView_SelectionChanged;
        }

        private void ConfigureGridColumns()
        {
            staffDataGridView.AutoGenerateColumns = false;
            staffDataGridView.Columns.Clear();

            staffDataGridView.Columns.Add(new DataGridViewTextBoxColumn { Name = "StaffId", HeaderText = "ID", DataPropertyName = "StaffId", ReadOnly = true });
            staffDataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "First Name", DataPropertyName = "FName" });
            staffDataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Last Name", DataPropertyName = "LName" });
            staffDataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Email", DataPropertyName = "Email" });
            staffDataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Phone", DataPropertyName = "Phone" });
            staffDataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Position", DataPropertyName = "Position" });
            staffDataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Role", DataPropertyName = "Role" });
            staffDataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Salary", DataPropertyName = "Salary" });
            staffDataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Status", DataPropertyName = "Status" });
            staffDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            staffDataGridView.MultiSelect = false;
            staffDataGridView.ReadOnly = true;
        }

        private void LoadStaff()
        {
            List<Staff> staff = staffController.GetAllStaff();
            staffDataGridView.DataSource = null;
            staffDataGridView.DataSource = staff;
            StaffDataGridView_SelectionChanged(null, EventArgs.Empty);
        }

        private Staff GetSelectedStaff()
        {
            if (staffDataGridView.SelectedRows.Count == 0)
            {
                return null;
            }

            return staffDataGridView.SelectedRows[0].DataBoundItem as Staff;
        }

        private void StaffDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            bool hasSelection = GetSelectedStaff() != null;
            editStaffButton.Enabled = hasSelection;
            deleteStaffButton.Enabled = hasSelection;
        }

        private void EditStaffButton_Click(object sender, EventArgs e)
        {
            Staff selectedStaff = GetSelectedStaff();
            if (selectedStaff == null)
            {
                MessageBox.Show("Please select a staff record to edit.");
                return;
            }

            EmployeeRegisterForm editForm = new EmployeeRegisterForm(selectedStaff);
            editForm.FormClosed += (s, args) => LoadStaff();
            editForm.ShowDialog();
        }

        private void DeleteStaffButton_Click(object sender, EventArgs e)
        {
            Staff selectedStaff = GetSelectedStaff();
            if (selectedStaff == null)
            {
                MessageBox.Show("Please select a staff record to delete.");
                return;
            }

            DialogResult confirm = MessageBox.Show(
                $"Delete staff '{selectedStaff.FName} {selectedStaff.LName}'?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes)
            {
                return;
            }

            try
            {
                staffController.DeleteStaff(selectedStaff.StaffId);
                LoadStaff();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to delete staff: " + ex.Message);
            }
        }

        private void EmployeeControl_Load(object sender, EventArgs e)
        {
            LoadStaff();
        }
    }
}
