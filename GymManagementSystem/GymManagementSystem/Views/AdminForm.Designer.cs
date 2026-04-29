namespace GymManagementSystem
{
    partial class AdminForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.sidebarNavPanel = new System.Windows.Forms.Panel();
            this.EnglishBtn = new System.Windows.Forms.Button();
            this.adminTitleLabel = new System.Windows.Forms.Label();
            this.membershipPlanButton = new System.Windows.Forms.Button();
            this.facilityButton = new System.Windows.Forms.Button();
            this.paymentButton = new System.Windows.Forms.Button();
            this.trainersButton = new System.Windows.Forms.Button();
            this.employeeButton = new System.Windows.Forms.Button();
            this.membersButton = new System.Windows.Forms.Button();
            this.dashBoardButton = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.gymManagementDBDataSet = new GymManagementSystem.GymManagementDBDataSet();
            this.pAYMENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new GymManagementSystem.GymManagementDBDataSetTableAdapters.TableAdapterManager();
            this.mEMBERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mEMBERBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mEMBERBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.sidebarNavPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gymManagementDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAYMENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEMBERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEMBERBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEMBERBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebarNavPanel
            // 
            resources.ApplyResources(this.sidebarNavPanel, "sidebarNavPanel");
            this.sidebarNavPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.sidebarNavPanel.Controls.Add(this.EnglishBtn);
            this.sidebarNavPanel.Controls.Add(this.adminTitleLabel);
            this.sidebarNavPanel.Controls.Add(this.membershipPlanButton);
            this.sidebarNavPanel.Controls.Add(this.facilityButton);
            this.sidebarNavPanel.Controls.Add(this.paymentButton);
            this.sidebarNavPanel.Controls.Add(this.trainersButton);
            this.sidebarNavPanel.Controls.Add(this.employeeButton);
            this.sidebarNavPanel.Controls.Add(this.membersButton);
            this.sidebarNavPanel.Controls.Add(this.dashBoardButton);
            this.sidebarNavPanel.Name = "sidebarNavPanel";
            // 
            // EnglishBtn
            // 
            this.EnglishBtn.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.EnglishBtn, "EnglishBtn");
            this.EnglishBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EnglishBtn.Name = "EnglishBtn";
            this.EnglishBtn.UseVisualStyleBackColor = true;
            this.EnglishBtn.Click += new System.EventHandler(this.languageBtn_Click);
            // 
            // adminTitleLabel
            // 
            resources.ApplyResources(this.adminTitleLabel, "adminTitleLabel");
            this.adminTitleLabel.ForeColor = System.Drawing.Color.White;
            this.adminTitleLabel.Name = "adminTitleLabel";
            // 
            // membershipPlanButton
            // 
            resources.ApplyResources(this.membershipPlanButton, "membershipPlanButton");
            this.membershipPlanButton.FlatAppearance.BorderSize = 0;
            this.membershipPlanButton.ForeColor = System.Drawing.Color.White;
            this.membershipPlanButton.Name = "membershipPlanButton";
            this.membershipPlanButton.UseVisualStyleBackColor = true;
            this.membershipPlanButton.Click += new System.EventHandler(this.membershipPlanButton_Click);
            // 
            // facilityButton
            // 
            resources.ApplyResources(this.facilityButton, "facilityButton");
            this.facilityButton.FlatAppearance.BorderSize = 0;
            this.facilityButton.ForeColor = System.Drawing.Color.White;
            this.facilityButton.Name = "facilityButton";
            this.facilityButton.UseVisualStyleBackColor = true;
            this.facilityButton.Click += new System.EventHandler(this.auditLogButton_Click);
            // 
            // paymentButton
            // 
            resources.ApplyResources(this.paymentButton, "paymentButton");
            this.paymentButton.FlatAppearance.BorderSize = 0;
            this.paymentButton.ForeColor = System.Drawing.Color.White;
            this.paymentButton.Name = "paymentButton";
            this.paymentButton.UseVisualStyleBackColor = true;
            this.paymentButton.Click += new System.EventHandler(this.paymentButton_Click);
            // 
            // trainersButton
            // 
            resources.ApplyResources(this.trainersButton, "trainersButton");
            this.trainersButton.FlatAppearance.BorderSize = 0;
            this.trainersButton.ForeColor = System.Drawing.Color.White;
            this.trainersButton.Name = "trainersButton";
            this.trainersButton.UseVisualStyleBackColor = true;
            this.trainersButton.Click += new System.EventHandler(this.trainersButton_Click);
            // 
            // employeeButton
            // 
            resources.ApplyResources(this.employeeButton, "employeeButton");
            this.employeeButton.FlatAppearance.BorderSize = 0;
            this.employeeButton.ForeColor = System.Drawing.Color.White;
            this.employeeButton.Name = "employeeButton";
            this.employeeButton.UseVisualStyleBackColor = true;
            this.employeeButton.Click += new System.EventHandler(this.employeeButton_Click);
            // 
            // membersButton
            // 
            resources.ApplyResources(this.membersButton, "membersButton");
            this.membersButton.FlatAppearance.BorderSize = 0;
            this.membersButton.ForeColor = System.Drawing.Color.White;
            this.membersButton.Name = "membersButton";
            this.membersButton.UseVisualStyleBackColor = true;
            this.membersButton.Click += new System.EventHandler(this.membersButton_Click);
            // 
            // dashBoardButton
            // 
            resources.ApplyResources(this.dashBoardButton, "dashBoardButton");
            this.dashBoardButton.FlatAppearance.BorderSize = 0;
            this.dashBoardButton.ForeColor = System.Drawing.Color.White;
            this.dashBoardButton.Name = "dashBoardButton";
            this.dashBoardButton.UseVisualStyleBackColor = true;
            this.dashBoardButton.Click += new System.EventHandler(this.dashBoardButton_Click);
            // 
            // mainPanel
            // 
            resources.ApplyResources(this.mainPanel, "mainPanel");
            this.mainPanel.Name = "mainPanel";
            // 
            // gymManagementDBDataSet
            // 
            this.gymManagementDBDataSet.DataSetName = "GymManagementDBDataSet";
            this.gymManagementDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pAYMENTBindingSource
            // 
            this.pAYMENTBindingSource.DataMember = "PAYMENT";
            this.pAYMENTBindingSource.DataSource = this.gymManagementDBDataSet;
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
            // mEMBERBindingSource
            // 
            this.mEMBERBindingSource.DataMember = "MEMBER";
            this.mEMBERBindingSource.DataSource = this.gymManagementDBDataSet;
            // 
            // mEMBERBindingSource1
            // 
            this.mEMBERBindingSource1.DataMember = "MEMBER";
            this.mEMBERBindingSource1.DataSource = this.gymManagementDBDataSet;
            // 
            // mEMBERBindingSource2
            // 
            this.mEMBERBindingSource2.DataMember = "MEMBER";
            this.mEMBERBindingSource2.DataSource = this.gymManagementDBDataSet;
            // 
            // AdminForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.sidebarNavPanel);
            this.Name = "AdminForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.sidebarNavPanel.ResumeLayout(false);
            this.sidebarNavPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gymManagementDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAYMENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEMBERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEMBERBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEMBERBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidebarNavPanel;
        private System.Windows.Forms.Label adminTitleLabel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button membershipPlanButton;
        private System.Windows.Forms.Button facilityButton;
        private System.Windows.Forms.Button paymentButton;
        private System.Windows.Forms.Button trainersButton;
        private System.Windows.Forms.Button employeeButton;
        private System.Windows.Forms.Button membersButton;
        private System.Windows.Forms.Button dashBoardButton;
        private GymManagementDBDataSet gymManagementDBDataSet;
        private System.Windows.Forms.BindingSource pAYMENTBindingSource;
        private GymManagementDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource mEMBERBindingSource;
        private System.Windows.Forms.BindingSource mEMBERBindingSource2;
        private System.Windows.Forms.BindingSource mEMBERBindingSource1;
        private System.Windows.Forms.Button EnglishBtn;
    }
}

