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
            this.recentMemberDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.recentMemberDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // auditLogLabel
            // 
            this.auditLogLabel.AutoSize = true;
            this.auditLogLabel.Location = new System.Drawing.Point(30, 486);
            this.auditLogLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.auditLogLabel.Name = "auditLogLabel";
            this.auditLogLabel.Size = new System.Drawing.Size(52, 13);
            this.auditLogLabel.TabIndex = 16;
            this.auditLogLabel.Text = "Audit Log";
            // 
            // recentMemberLabel
            // 
            this.recentMemberLabel.AutoSize = true;
            this.recentMemberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recentMemberLabel.Location = new System.Drawing.Point(33, 109);
            this.recentMemberLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.recentMemberLabel.Name = "recentMemberLabel";
            this.recentMemberLabel.Size = new System.Drawing.Size(155, 24);
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
            this.totalPaymentPanel.Location = new System.Drawing.Point(364, 25);
            this.totalPaymentPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.totalPaymentPanel.Name = "totalPaymentPanel";
            this.totalPaymentPanel.Size = new System.Drawing.Size(120, 65);
            this.totalPaymentPanel.TabIndex = 10;
            this.totalPaymentPanel.Tag = "";
            // 
            // revenueNumLabel
            // 
            this.revenueNumLabel.AutoSize = true;
            this.revenueNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.revenueNumLabel.Location = new System.Drawing.Point(13, 38);
            this.revenueNumLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.revenueNumLabel.Name = "revenueNumLabel";
            this.revenueNumLabel.Size = new System.Drawing.Size(45, 20);
            this.revenueNumLabel.TabIndex = 1;
            this.revenueNumLabel.Text = "$145";
            // 
            // revenuLabel
            // 
            this.revenuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.revenuLabel.Location = new System.Drawing.Point(13, 6);
            this.revenuLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.revenuLabel.Name = "revenuLabel";
            this.revenuLabel.Size = new System.Drawing.Size(79, 38);
            this.revenuLabel.TabIndex = 0;
            this.revenuLabel.Text = "Revenue This Month";
            // 
            // activePlanPanel
            // 
            this.activePlanPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.activePlanPanel.Controls.Add(this.activePLanNumLabel);
            this.activePlanPanel.Controls.Add(this.activePlanLabel);
            this.activePlanPanel.Location = new System.Drawing.Point(193, 25);
            this.activePlanPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.activePlanPanel.Name = "activePlanPanel";
            this.activePlanPanel.Size = new System.Drawing.Size(120, 65);
            this.activePlanPanel.TabIndex = 11;
            this.activePlanPanel.Tag = "";
            // 
            // activePLanNumLabel
            // 
            this.activePLanNumLabel.AutoSize = true;
            this.activePLanNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activePLanNumLabel.Location = new System.Drawing.Point(9, 34);
            this.activePLanNumLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.activePLanNumLabel.Name = "activePLanNumLabel";
            this.activePLanNumLabel.Size = new System.Drawing.Size(36, 20);
            this.activePLanNumLabel.TabIndex = 1;
            this.activePLanNumLabel.Text = "145";
            // 
            // activePlanLabel
            // 
            this.activePlanLabel.AutoSize = true;
            this.activePlanLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activePlanLabel.Location = new System.Drawing.Point(10, 14);
            this.activePlanLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.activePlanLabel.Name = "activePlanLabel";
            this.activePlanLabel.Size = new System.Drawing.Size(109, 15);
            this.activePlanLabel.TabIndex = 0;
            this.activePlanLabel.Text = "Active Subscription";
            // 
            // totalEmployeePanel
            // 
            this.totalEmployeePanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.totalEmployeePanel.Controls.Add(this.employeeNumLabel);
            this.totalEmployeePanel.Controls.Add(this.totalEployeeLabel);
            this.totalEmployeePanel.Location = new System.Drawing.Point(527, 25);
            this.totalEmployeePanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.totalEmployeePanel.Name = "totalEmployeePanel";
            this.totalEmployeePanel.Size = new System.Drawing.Size(120, 65);
            this.totalEmployeePanel.TabIndex = 12;
            this.totalEmployeePanel.Tag = "";
            // 
            // employeeNumLabel
            // 
            this.employeeNumLabel.AutoSize = true;
            this.employeeNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeNumLabel.Location = new System.Drawing.Point(9, 34);
            this.employeeNumLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.employeeNumLabel.Name = "employeeNumLabel";
            this.employeeNumLabel.Size = new System.Drawing.Size(36, 20);
            this.employeeNumLabel.TabIndex = 1;
            this.employeeNumLabel.Text = "145";
            // 
            // totalEployeeLabel
            // 
            this.totalEployeeLabel.AutoSize = true;
            this.totalEployeeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalEployeeLabel.Location = new System.Drawing.Point(10, 14);
            this.totalEployeeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalEployeeLabel.Name = "totalEployeeLabel";
            this.totalEployeeLabel.Size = new System.Drawing.Size(98, 15);
            this.totalEployeeLabel.TabIndex = 0;
            this.totalEployeeLabel.Text = "Total Employees";
            // 
            // totalMembersPanel
            // 
            this.totalMembersPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.totalMembersPanel.Controls.Add(this.memberNumLabel);
            this.totalMembersPanel.Controls.Add(this.totalMemberLabel);
            this.totalMembersPanel.Location = new System.Drawing.Point(33, 25);
            this.totalMembersPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.totalMembersPanel.Name = "totalMembersPanel";
            this.totalMembersPanel.Size = new System.Drawing.Size(120, 65);
            this.totalMembersPanel.TabIndex = 9;
            this.totalMembersPanel.Tag = "";
            // 
            // memberNumLabel
            // 
            this.memberNumLabel.AutoSize = true;
            this.memberNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberNumLabel.Location = new System.Drawing.Point(21, 34);
            this.memberNumLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.memberNumLabel.Name = "memberNumLabel";
            this.memberNumLabel.Size = new System.Drawing.Size(36, 20);
            this.memberNumLabel.TabIndex = 1;
            this.memberNumLabel.Text = "145";
            // 
            // totalMemberLabel
            // 
            this.totalMemberLabel.AutoSize = true;
            this.totalMemberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalMemberLabel.Location = new System.Drawing.Point(21, 14);
            this.totalMemberLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalMemberLabel.Name = "totalMemberLabel";
            this.totalMemberLabel.Size = new System.Drawing.Size(90, 15);
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
            // recentMemberDataGridView
            // 
            this.recentMemberDataGridView.AllowUserToAddRows = false;
            this.recentMemberDataGridView.AllowUserToDeleteRows = false;
            this.recentMemberDataGridView.AutoGenerateColumns = false;
            this.recentMemberDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recentMemberDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn10});
            this.recentMemberDataGridView.DataSource = this.mEMBERBindingSource;
            this.recentMemberDataGridView.Location = new System.Drawing.Point(33, 142);
            this.recentMemberDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.recentMemberDataGridView.Name = "recentMemberDataGridView";
            this.recentMemberDataGridView.ReadOnly = true;
            this.recentMemberDataGridView.RowHeadersVisible = false;
            this.recentMemberDataGridView.RowHeadersWidth = 62;
            this.recentMemberDataGridView.RowTemplate.Height = 28;
            this.recentMemberDataGridView.Size = new System.Drawing.Size(735, 323);
            this.recentMemberDataGridView.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "member_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "member_id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
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
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "phone";
            this.dataGridViewTextBoxColumn5.HeaderText = "Phone";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 150;
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.recentMemberDataGridView);
            this.Controls.Add(this.auditLogLabel);
            this.Controls.Add(this.recentMemberLabel);
            this.Controls.Add(this.totalPaymentPanel);
            this.Controls.Add(this.activePlanPanel);
            this.Controls.Add(this.totalEmployeePanel);
            this.Controls.Add(this.totalMembersPanel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DashboardControl";
            this.Size = new System.Drawing.Size(833, 520);
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
            ((System.ComponentModel.ISupportInitialize)(this.recentMemberDataGridView)).EndInit();
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
        private System.Windows.Forms.DataGridView recentMemberDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
    }
}
