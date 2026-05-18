namespace GymManagementSystem
{
    partial class EmployeeControl : System.Windows.Forms.UserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.staffDataGridView = new System.Windows.Forms.DataGridView();
            this.RegisterMemberButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.EditStaffBtn = new System.Windows.Forms.Button();
            this.DeleteStaffBtn = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gymManagementDBDataSet = new GymManagementSystem.GymManagementDBDataSet();
            this.staffTableAdapter = new GymManagementSystem.GymManagementDBDataSetTableAdapters.StaffTableAdapter();
            this.tableAdapterManager = new GymManagementSystem.GymManagementDBDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.staffDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymManagementDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // staffDataGridView
            // 
            this.staffDataGridView.AutoGenerateColumns = false;
            this.staffDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.staffDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
            this.staffDataGridView.DataSource = this.staffBindingSource;
            this.staffDataGridView.Location = new System.Drawing.Point(37, 98);
            this.staffDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.staffDataGridView.Name = "staffDataGridView";
            this.staffDataGridView.RowHeadersVisible = false;
            this.staffDataGridView.RowHeadersWidth = 62;
            this.staffDataGridView.RowTemplate.Height = 28;
            this.staffDataGridView.Size = new System.Drawing.Size(1187, 463);
            this.staffDataGridView.TabIndex = 1;
            // 
            // RegisterMemberButton
            // 
            this.RegisterMemberButton.Location = new System.Drawing.Point(536, 44);
            this.RegisterMemberButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RegisterMemberButton.Name = "RegisterMemberButton";
            this.RegisterMemberButton.Size = new System.Drawing.Size(153, 49);
            this.RegisterMemberButton.TabIndex = 2;
            this.RegisterMemberButton.Text = "Register Staff";
            this.RegisterMemberButton.UseVisualStyleBackColor = true;
            this.RegisterMemberButton.Click += new System.EventHandler(this.RegisterMemberButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 29);
            this.label1.TabIndex = 17;
            this.label1.Text = "Staff";
            // 
            // EditStaffBtn
            // 
            this.EditStaffBtn.Location = new System.Drawing.Point(712, 45);
            this.EditStaffBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EditStaffBtn.Name = "EditStaffBtn";
            this.EditStaffBtn.Size = new System.Drawing.Size(153, 49);
            this.EditStaffBtn.TabIndex = 18;
            this.EditStaffBtn.Text = "Edit Staff Info";
            this.EditStaffBtn.UseVisualStyleBackColor = true;
            this.EditStaffBtn.Click += new System.EventHandler(this.EditStaffBtn_Click);
            // 
            // DeleteStaffBtn
            // 
            this.DeleteStaffBtn.Location = new System.Drawing.Point(887, 45);
            this.DeleteStaffBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteStaffBtn.Name = "DeleteStaffBtn";
            this.DeleteStaffBtn.Size = new System.Drawing.Size(153, 49);
            this.DeleteStaffBtn.TabIndex = 19;
            this.DeleteStaffBtn.Text = "Delete Staff";
            this.DeleteStaffBtn.UseVisualStyleBackColor = true;
            this.DeleteStaffBtn.Click += new System.EventHandler(this.DeleteStaffBtn_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "staff_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "staff_id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "first_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "first_name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "last_name";
            this.dataGridViewTextBoxColumn3.HeaderText = "last_name";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "email";
            this.dataGridViewTextBoxColumn4.HeaderText = "email";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "phone";
            this.dataGridViewTextBoxColumn5.HeaderText = "phone";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "position";
            this.dataGridViewTextBoxColumn6.HeaderText = "position";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "last_login";
            this.dataGridViewTextBoxColumn9.HeaderText = "last_login";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 150;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "salary";
            this.dataGridViewTextBoxColumn11.HeaderText = "salary";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 150;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "hire_date";
            this.dataGridViewTextBoxColumn12.HeaderText = "hire_date";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 150;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "status";
            this.dataGridViewTextBoxColumn13.HeaderText = "status";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 150;
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "Staff";
            this.staffBindingSource.DataSource = this.gymManagementDBDataSet;
            // 
            // gymManagementDBDataSet
            // 
            this.gymManagementDBDataSet.DataSetName = "GymManagementDBDataSet";
            this.gymManagementDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // staffTableAdapter
            // 
            this.staffTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AttendanceTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EquipmentTableAdapter = null;
            this.tableAdapterManager.LockerTableAdapter = null;
            this.tableAdapterManager.Member_ProgressTableAdapter = null;
            this.tableAdapterManager.Membership_PlanTableAdapter = null;
            this.tableAdapterManager.MemberTableAdapter = null;
            this.tableAdapterManager.PaymentTableAdapter = null;
            this.tableAdapterManager.PT_SessionTableAdapter = null;
            this.tableAdapterManager.StaffTableAdapter = this.staffTableAdapter;
            this.tableAdapterManager.SubscriptionTableAdapter = null;
            this.tableAdapterManager.TrainerTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GymManagementSystem.GymManagementDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // EmployeeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DeleteStaffBtn);
            this.Controls.Add(this.EditStaffBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RegisterMemberButton);
            this.Controls.Add(this.staffDataGridView);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EmployeeControl";
            this.Size = new System.Drawing.Size(1313, 695);
            this.Load += new System.EventHandler(this.EmployeeControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.staffDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymManagementDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GymManagementDBDataSet gymManagementDBDataSet;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private GymManagementDBDataSetTableAdapters.StaffTableAdapter staffTableAdapter;
        private GymManagementDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView staffDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.Button RegisterMemberButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button EditStaffBtn;
        private System.Windows.Forms.Button DeleteStaffBtn;
    }
}
