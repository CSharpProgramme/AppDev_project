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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardControl));
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
            // recentMemberLabel
            // 
            resources.ApplyResources(this.recentMemberLabel, "recentMemberLabel");
            this.recentMemberLabel.Name = "recentMemberLabel";
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
            resources.ApplyResources(this.totalPaymentPanel, "totalPaymentPanel");
            this.totalPaymentPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.totalPaymentPanel.Controls.Add(this.revenueNumLabel);
            this.totalPaymentPanel.Controls.Add(this.revenuLabel);
            this.totalPaymentPanel.Name = "totalPaymentPanel";
            this.totalPaymentPanel.Tag = "";
            // 
            // revenueNumLabel
            // 
            resources.ApplyResources(this.revenueNumLabel, "revenueNumLabel");
            this.revenueNumLabel.Name = "revenueNumLabel";
            // 
            // revenuLabel
            // 
            resources.ApplyResources(this.revenuLabel, "revenuLabel");
            this.revenuLabel.Name = "revenuLabel";
            // 
            // activePlanPanel
            // 
            resources.ApplyResources(this.activePlanPanel, "activePlanPanel");
            this.activePlanPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.activePlanPanel.Controls.Add(this.activePLanNumLabel);
            this.activePlanPanel.Controls.Add(this.activePlanLabel);
            this.activePlanPanel.Name = "activePlanPanel";
            this.activePlanPanel.Tag = "";
            // 
            // activePLanNumLabel
            // 
            resources.ApplyResources(this.activePLanNumLabel, "activePLanNumLabel");
            this.activePLanNumLabel.Name = "activePLanNumLabel";
            // 
            // activePlanLabel
            // 
            resources.ApplyResources(this.activePlanLabel, "activePlanLabel");
            this.activePlanLabel.Name = "activePlanLabel";
            // 
            // totalEmployeePanel
            // 
            resources.ApplyResources(this.totalEmployeePanel, "totalEmployeePanel");
            this.totalEmployeePanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.totalEmployeePanel.Controls.Add(this.employeeNumLabel);
            this.totalEmployeePanel.Controls.Add(this.totalEployeeLabel);
            this.totalEmployeePanel.Name = "totalEmployeePanel";
            this.totalEmployeePanel.Tag = "";
            // 
            // employeeNumLabel
            // 
            resources.ApplyResources(this.employeeNumLabel, "employeeNumLabel");
            this.employeeNumLabel.Name = "employeeNumLabel";
            // 
            // totalEployeeLabel
            // 
            resources.ApplyResources(this.totalEployeeLabel, "totalEployeeLabel");
            this.totalEployeeLabel.Name = "totalEployeeLabel";
            // 
            // totalMembersPanel
            // 
            resources.ApplyResources(this.totalMembersPanel, "totalMembersPanel");
            this.totalMembersPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.totalMembersPanel.Controls.Add(this.memberNumLabel);
            this.totalMembersPanel.Controls.Add(this.totalMemberLabel);
            this.totalMembersPanel.Name = "totalMembersPanel";
            this.totalMembersPanel.Tag = "";
            // 
            // memberNumLabel
            // 
            resources.ApplyResources(this.memberNumLabel, "memberNumLabel");
            this.memberNumLabel.Name = "memberNumLabel";
            // 
            // totalMemberLabel
            // 
            resources.ApplyResources(this.totalMemberLabel, "totalMemberLabel");
            this.totalMemberLabel.Name = "totalMemberLabel";
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
            resources.ApplyResources(this.recentMemberDataGridView, "recentMemberDataGridView");
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
            this.recentMemberDataGridView.Name = "recentMemberDataGridView";
            this.recentMemberDataGridView.ReadOnly = true;
            this.recentMemberDataGridView.RowHeadersVisible = false;
            this.recentMemberDataGridView.RowTemplate.Height = 28;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "member_id";
            resources.ApplyResources(this.dataGridViewTextBoxColumn1, "dataGridViewTextBoxColumn1");
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "first_name";
            resources.ApplyResources(this.dataGridViewTextBoxColumn2, "dataGridViewTextBoxColumn2");
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "last_name";
            resources.ApplyResources(this.dataGridViewTextBoxColumn3, "dataGridViewTextBoxColumn3");
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "email";
            resources.ApplyResources(this.dataGridViewTextBoxColumn4, "dataGridViewTextBoxColumn4");
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "phone";
            resources.ApplyResources(this.dataGridViewTextBoxColumn5, "dataGridViewTextBoxColumn5");
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "join_date";
            resources.ApplyResources(this.dataGridViewTextBoxColumn7, "dataGridViewTextBoxColumn7");
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "status";
            resources.ApplyResources(this.dataGridViewTextBoxColumn10, "dataGridViewTextBoxColumn10");
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // DashboardControl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.recentMemberDataGridView);
            this.Controls.Add(this.recentMemberLabel);
            this.Controls.Add(this.totalPaymentPanel);
            this.Controls.Add(this.activePlanPanel);
            this.Controls.Add(this.totalEmployeePanel);
            this.Controls.Add(this.totalMembersPanel);
            this.Name = "DashboardControl";
            this.Load += new System.EventHandler(this.DashboardControl_Load);
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
