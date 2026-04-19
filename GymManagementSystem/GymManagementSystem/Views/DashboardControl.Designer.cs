namespace GymManagementSystem
{
    partial class DashboardControl
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
            this.auditLogLabel = new System.Windows.Forms.Label();
            this.recentMemberLabel = new System.Windows.Forms.Label();
            this.mEMBERBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gymManagementDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gymManagementDBDataSet = new GymManagementSystem.GymManagementDBDataSet();
            this.totalPaymentPanel = new System.Windows.Forms.Panel();
            this.revenueNumLabel = new System.Windows.Forms.Label();
            this.revenuLabel = new System.Windows.Forms.Label();
            this.activePlanPanel = new System.Windows.Forms.Panel();
            this.activePLanNumLabel = new System.Windows.Forms.Label();
            this.activePlanLabel = new System.Windows.Forms.Label();
            this.totalEmployeePanel = new System.Windows.Forms.Panel();
            this.employeeNumLabel = new System.Windows.Forms.Label();
            this.totalEployeeLabel = new System.Windows.Forms.Label();
            this.totalMembersPanel = new System.Windows.Forms.Panel();
            this.memberNumLabel = new System.Windows.Forms.Label();
            this.totalMemberLabel = new System.Windows.Forms.Label();
            this.mEMBERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new GymManagementSystem.GymManagementDBDataSetTableAdapters.TableAdapterManager();
            this.memberTableAdapter = new GymManagementSystem.GymManagementDBDataSetTableAdapters.MemberTableAdapter();
            this.memberDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.mEMBERBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymManagementDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymManagementDBDataSet)).BeginInit();
            this.totalPaymentPanel.SuspendLayout();
            this.activePlanPanel.SuspendLayout();
            this.totalEmployeePanel.SuspendLayout();
            this.totalMembersPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mEMBERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // auditLogLabel
            // 
            this.auditLogLabel.AutoSize = true;
            this.auditLogLabel.Location = new System.Drawing.Point(178, 502);
            this.auditLogLabel.Name = "auditLogLabel";
            this.auditLogLabel.Size = new System.Drawing.Size(77, 20);
            this.auditLogLabel.TabIndex = 16;
            this.auditLogLabel.Text = "Audit Log";
            // 
            // recentMemberLabel
            // 
            this.recentMemberLabel.AutoSize = true;
            this.recentMemberLabel.Location = new System.Drawing.Point(178, 150);
            this.recentMemberLabel.Name = "recentMemberLabel";
            this.recentMemberLabel.Size = new System.Drawing.Size(131, 20);
            this.recentMemberLabel.TabIndex = 15;
            this.recentMemberLabel.Text = "Recent Members";
            // 
            // mEMBERBindingSource1
            // 
            this.mEMBERBindingSource1.DataMember = "MEMBER";
            this.mEMBERBindingSource1.DataSource = this.gymManagementDBDataSetBindingSource;
            // 
            // gymManagementDBDataSetBindingSource
            // 
            this.gymManagementDBDataSetBindingSource.DataSource = this.gymManagementDBDataSet;
            this.gymManagementDBDataSetBindingSource.Position = 0;
            // 
            // gymManagementDBDataSet
            // 
            this.gymManagementDBDataSet.DataSetName = "GymManagementDBDataSet";
            this.gymManagementDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // totalPaymentPanel
            // 
            this.totalPaymentPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.totalPaymentPanel.Controls.Add(this.revenueNumLabel);
            this.totalPaymentPanel.Controls.Add(this.revenuLabel);
            this.totalPaymentPanel.Location = new System.Drawing.Point(674, 20);
            this.totalPaymentPanel.Name = "totalPaymentPanel";
            this.totalPaymentPanel.Size = new System.Drawing.Size(180, 100);
            this.totalPaymentPanel.TabIndex = 10;
            this.totalPaymentPanel.Tag = "";
            // 
            // revenueNumLabel
            // 
            this.revenueNumLabel.AutoSize = true;
            this.revenueNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.revenueNumLabel.Location = new System.Drawing.Point(19, 59);
            this.revenueNumLabel.Name = "revenueNumLabel";
            this.revenueNumLabel.Size = new System.Drawing.Size(65, 29);
            this.revenueNumLabel.TabIndex = 1;
            this.revenueNumLabel.Text = "$145";
            // 
            // revenuLabel
            // 
            this.revenuLabel.Location = new System.Drawing.Point(20, 11);
            this.revenuLabel.Name = "revenuLabel";
            this.revenuLabel.Size = new System.Drawing.Size(118, 58);
            this.revenuLabel.TabIndex = 0;
            this.revenuLabel.Text = "Revenue This Month";
            // 
            // activePlanPanel
            // 
            this.activePlanPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.activePlanPanel.Controls.Add(this.activePLanNumLabel);
            this.activePlanPanel.Controls.Add(this.activePlanLabel);
            this.activePlanPanel.Location = new System.Drawing.Point(417, 20);
            this.activePlanPanel.Name = "activePlanPanel";
            this.activePlanPanel.Size = new System.Drawing.Size(180, 100);
            this.activePlanPanel.TabIndex = 11;
            this.activePlanPanel.Tag = "";
            // 
            // activePLanNumLabel
            // 
            this.activePLanNumLabel.AutoSize = true;
            this.activePLanNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activePLanNumLabel.Location = new System.Drawing.Point(14, 52);
            this.activePLanNumLabel.Name = "activePLanNumLabel";
            this.activePLanNumLabel.Size = new System.Drawing.Size(52, 29);
            this.activePLanNumLabel.TabIndex = 1;
            this.activePLanNumLabel.Text = "145";
            // 
            // activePlanLabel
            // 
            this.activePlanLabel.AutoSize = true;
            this.activePlanLabel.Location = new System.Drawing.Point(15, 21);
            this.activePlanLabel.Name = "activePlanLabel";
            this.activePlanLabel.Size = new System.Drawing.Size(144, 20);
            this.activePlanLabel.TabIndex = 0;
            this.activePlanLabel.Text = "Active Subscription";
            // 
            // totalEmployeePanel
            // 
            this.totalEmployeePanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.totalEmployeePanel.Controls.Add(this.employeeNumLabel);
            this.totalEmployeePanel.Controls.Add(this.totalEployeeLabel);
            this.totalEmployeePanel.Location = new System.Drawing.Point(919, 20);
            this.totalEmployeePanel.Name = "totalEmployeePanel";
            this.totalEmployeePanel.Size = new System.Drawing.Size(180, 100);
            this.totalEmployeePanel.TabIndex = 12;
            this.totalEmployeePanel.Tag = "";
            // 
            // employeeNumLabel
            // 
            this.employeeNumLabel.AutoSize = true;
            this.employeeNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeNumLabel.Location = new System.Drawing.Point(14, 52);
            this.employeeNumLabel.Name = "employeeNumLabel";
            this.employeeNumLabel.Size = new System.Drawing.Size(52, 29);
            this.employeeNumLabel.TabIndex = 1;
            this.employeeNumLabel.Text = "145";
            // 
            // totalEployeeLabel
            // 
            this.totalEployeeLabel.AutoSize = true;
            this.totalEployeeLabel.Location = new System.Drawing.Point(15, 21);
            this.totalEployeeLabel.Name = "totalEployeeLabel";
            this.totalEployeeLabel.Size = new System.Drawing.Size(126, 20);
            this.totalEployeeLabel.TabIndex = 0;
            this.totalEployeeLabel.Text = "Total Employees";
            // 
            // totalMembersPanel
            // 
            this.totalMembersPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.totalMembersPanel.Controls.Add(this.memberNumLabel);
            this.totalMembersPanel.Controls.Add(this.totalMemberLabel);
            this.totalMembersPanel.Location = new System.Drawing.Point(178, 20);
            this.totalMembersPanel.Name = "totalMembersPanel";
            this.totalMembersPanel.Size = new System.Drawing.Size(180, 100);
            this.totalMembersPanel.TabIndex = 9;
            this.totalMembersPanel.Tag = "";
            // 
            // memberNumLabel
            // 
            this.memberNumLabel.AutoSize = true;
            this.memberNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberNumLabel.Location = new System.Drawing.Point(31, 52);
            this.memberNumLabel.Name = "memberNumLabel";
            this.memberNumLabel.Size = new System.Drawing.Size(52, 29);
            this.memberNumLabel.TabIndex = 1;
            this.memberNumLabel.Text = "145";
            // 
            // totalMemberLabel
            // 
            this.totalMemberLabel.AutoSize = true;
            this.totalMemberLabel.Location = new System.Drawing.Point(32, 22);
            this.totalMemberLabel.Name = "totalMemberLabel";
            this.totalMemberLabel.Size = new System.Drawing.Size(114, 20);
            this.totalMemberLabel.TabIndex = 0;
            this.totalMemberLabel.Text = "Total Members";
            // 
            // mEMBERBindingSource
            // 
            this.mEMBERBindingSource.DataMember = "MEMBER";
            this.mEMBERBindingSource.DataSource = this.gymManagementDBDataSet;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AttendanceTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.EquipmentTableAdapter = null;
            this.tableAdapterManager.LockerTableAdapter = null;
            this.tableAdapterManager.Member_ProgressTableAdapter = null;
            this.tableAdapterManager.Membership_PlanTableAdapter = null;
            this.tableAdapterManager.MemberTableAdapter = null;
            this.tableAdapterManager.PaymentTableAdapter = null;
            this.tableAdapterManager.PT_SessionTableAdapter = null;
            this.tableAdapterManager.StaffTableAdapter = null;
            this.tableAdapterManager.SubscriptionTableAdapter = null;
            this.tableAdapterManager.TrainerTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GymManagementSystem.GymManagementDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // memberTableAdapter
            // 
            this.memberTableAdapter.ClearBeforeFill = true;
            // 
            // memberDataGridView
            // 
            this.memberDataGridView.AllowUserToAddRows = false;
            this.memberDataGridView.AllowUserToDeleteRows = false;
            this.memberDataGridView.AutoGenerateColumns = false;
            this.memberDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.memberDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn10});
            this.memberDataGridView.DataSource = this.mEMBERBindingSource;
            this.memberDataGridView.Location = new System.Drawing.Point(183, 220);
            this.memberDataGridView.Name = "memberDataGridView";
            this.memberDataGridView.ReadOnly = true;
            this.memberDataGridView.RowHeadersVisible = false;
            this.memberDataGridView.RowHeadersWidth = 62;
            this.memberDataGridView.RowTemplate.Height = 28;
            this.memberDataGridView.Size = new System.Drawing.Size(1219, 220);
            this.memberDataGridView.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "first_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "First Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "last_name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Last Name";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "email";
            this.dataGridViewTextBoxColumn4.HeaderText = "Email";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "join_date";
            this.dataGridViewTextBoxColumn7.HeaderText = "Joined Date";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "status";
            this.dataGridViewTextBoxColumn10.HeaderText = "Status";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 150;
            // 
            // DashboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.memberDataGridView);
            this.Controls.Add(this.auditLogLabel);
            this.Controls.Add(this.recentMemberLabel);
            this.Controls.Add(this.totalPaymentPanel);
            this.Controls.Add(this.activePlanPanel);
            this.Controls.Add(this.totalEmployeePanel);
            this.Controls.Add(this.totalMembersPanel);
            this.Name = "DashboardControl";
            this.Size = new System.Drawing.Size(1505, 800);
            ((System.ComponentModel.ISupportInitialize)(this.mEMBERBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymManagementDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymManagementDBDataSet)).EndInit();
            this.totalPaymentPanel.ResumeLayout(false);
            this.totalPaymentPanel.PerformLayout();
            this.activePlanPanel.ResumeLayout(false);
            this.activePlanPanel.PerformLayout();
            this.totalEmployeePanel.ResumeLayout(false);
            this.totalEmployeePanel.PerformLayout();
            this.totalMembersPanel.ResumeLayout(false);
            this.totalMembersPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mEMBERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label auditLogLabel;
        private System.Windows.Forms.Label recentMemberLabel;
        private System.Windows.Forms.Panel totalPaymentPanel;
        private System.Windows.Forms.Label revenueNumLabel;
        private System.Windows.Forms.Label revenuLabel;
        private System.Windows.Forms.Panel activePlanPanel;
        private System.Windows.Forms.Label activePLanNumLabel;
        private System.Windows.Forms.Label activePlanLabel;
        private System.Windows.Forms.Panel totalEmployeePanel;
        private System.Windows.Forms.Label employeeNumLabel;
        private System.Windows.Forms.Label totalEployeeLabel;
        private System.Windows.Forms.Panel totalMembersPanel;
        private System.Windows.Forms.Label memberNumLabel;
        private System.Windows.Forms.Label totalMemberLabel;
        private GymManagementDBDataSet gymManagementDBDataSet;
        private System.Windows.Forms.BindingSource mEMBERBindingSource;
        private GymManagementDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource mEMBERBindingSource1;
        private System.Windows.Forms.BindingSource gymManagementDBDataSetBindingSource;
        private GymManagementDBDataSetTableAdapters.MemberTableAdapter memberTableAdapter;
        private System.Windows.Forms.DataGridView memberDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
    }
}
