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
            this.sidebarNavPanel = new System.Windows.Forms.Panel();
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
            this.sidebarNavPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sidebarNavPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.sidebarNavPanel.Controls.Add(this.adminTitleLabel);
            this.sidebarNavPanel.Controls.Add(this.membershipPlanButton);
            this.sidebarNavPanel.Controls.Add(this.facilityButton);
            this.sidebarNavPanel.Controls.Add(this.paymentButton);
            this.sidebarNavPanel.Controls.Add(this.trainersButton);
            this.sidebarNavPanel.Controls.Add(this.employeeButton);
            this.sidebarNavPanel.Controls.Add(this.membersButton);
            this.sidebarNavPanel.Controls.Add(this.dashBoardButton);
            this.sidebarNavPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarNavPanel.Location = new System.Drawing.Point(0, 0);
            this.sidebarNavPanel.Name = "sidebarNavPanel";
            this.sidebarNavPanel.Size = new System.Drawing.Size(200, 849);
            this.sidebarNavPanel.TabIndex = 0;
            // 
            // adminTitleLabel
            // 
            this.adminTitleLabel.AutoSize = true;
            this.adminTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminTitleLabel.ForeColor = System.Drawing.Color.White;
            this.adminTitleLabel.Location = new System.Drawing.Point(21, 25);
            this.adminTitleLabel.Name = "adminTitleLabel";
            this.adminTitleLabel.Size = new System.Drawing.Size(160, 29);
            this.adminTitleLabel.TabIndex = 1;
            this.adminTitleLabel.Text = "Admin Panel";
            // 
            // membershipPlanButton
            // 
            this.membershipPlanButton.AutoSize = true;
            this.membershipPlanButton.FlatAppearance.BorderSize = 0;
            this.membershipPlanButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.membershipPlanButton.ForeColor = System.Drawing.Color.White;
            this.membershipPlanButton.Location = new System.Drawing.Point(0, 483);
            this.membershipPlanButton.Name = "membershipPlanButton";
            this.membershipPlanButton.Size = new System.Drawing.Size(200, 32);
            this.membershipPlanButton.TabIndex = 8;
            this.membershipPlanButton.Text = "Membership Plan";
            this.membershipPlanButton.UseVisualStyleBackColor = true;
            this.membershipPlanButton.Click += new System.EventHandler(this.membershipPlanButton_Click);
            // 
            // facilityButton
            // 
            this.facilityButton.AutoSize = true;
            this.facilityButton.FlatAppearance.BorderSize = 0;
            this.facilityButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.facilityButton.ForeColor = System.Drawing.Color.White;
            this.facilityButton.Location = new System.Drawing.Point(0, 424);
            this.facilityButton.Name = "facilityButton";
            this.facilityButton.Size = new System.Drawing.Size(200, 32);
            this.facilityButton.TabIndex = 7;
            this.facilityButton.Text = "Gym Facility";
            this.facilityButton.UseVisualStyleBackColor = true;
            this.facilityButton.Click += new System.EventHandler(this.auditLogButton_Click);
            // 
            // paymentButton
            // 
            this.paymentButton.AutoSize = true;
            this.paymentButton.FlatAppearance.BorderSize = 0;
            this.paymentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.paymentButton.ForeColor = System.Drawing.Color.White;
            this.paymentButton.Location = new System.Drawing.Point(0, 365);
            this.paymentButton.Name = "paymentButton";
            this.paymentButton.Size = new System.Drawing.Size(200, 32);
            this.paymentButton.TabIndex = 6;
            this.paymentButton.Text = "Payments";
            this.paymentButton.UseVisualStyleBackColor = true;
            this.paymentButton.Click += new System.EventHandler(this.paymentButton_Click);
            // 
            // trainersButton
            // 
            this.trainersButton.AutoSize = true;
            this.trainersButton.FlatAppearance.BorderSize = 0;
            this.trainersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.trainersButton.ForeColor = System.Drawing.Color.White;
            this.trainersButton.Location = new System.Drawing.Point(-3, 306);
            this.trainersButton.Name = "trainersButton";
            this.trainersButton.Size = new System.Drawing.Size(200, 32);
            this.trainersButton.TabIndex = 5;
            this.trainersButton.Text = "Trainers";
            this.trainersButton.UseVisualStyleBackColor = true;
            this.trainersButton.Click += new System.EventHandler(this.trainersButton_Click);
            // 
            // employeeButton
            // 
            this.employeeButton.AutoSize = true;
            this.employeeButton.FlatAppearance.BorderSize = 0;
            this.employeeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employeeButton.ForeColor = System.Drawing.Color.White;
            this.employeeButton.Location = new System.Drawing.Point(3, 247);
            this.employeeButton.Name = "employeeButton";
            this.employeeButton.Size = new System.Drawing.Size(197, 32);
            this.employeeButton.TabIndex = 4;
            this.employeeButton.Text = "Employees";
            this.employeeButton.UseVisualStyleBackColor = true;
            this.employeeButton.Click += new System.EventHandler(this.employeeButton_Click);
            // 
            // membersButton
            // 
            this.membersButton.AutoSize = true;
            this.membersButton.FlatAppearance.BorderSize = 0;
            this.membersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.membersButton.ForeColor = System.Drawing.Color.White;
            this.membersButton.Location = new System.Drawing.Point(0, 188);
            this.membersButton.Name = "membersButton";
            this.membersButton.Size = new System.Drawing.Size(200, 32);
            this.membersButton.TabIndex = 3;
            this.membersButton.Text = "Members";
            this.membersButton.UseVisualStyleBackColor = true;
            this.membersButton.Click += new System.EventHandler(this.membersButton_Click);
            // 
            // dashBoardButton
            // 
            this.dashBoardButton.AutoSize = true;
            this.dashBoardButton.FlatAppearance.BorderSize = 0;
            this.dashBoardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashBoardButton.ForeColor = System.Drawing.Color.White;
            this.dashBoardButton.Location = new System.Drawing.Point(0, 129);
            this.dashBoardButton.Name = "dashBoardButton";
            this.dashBoardButton.Size = new System.Drawing.Size(200, 32);
            this.dashBoardButton.TabIndex = 2;
            this.dashBoardButton.Text = "Dashboard";
            this.dashBoardButton.UseVisualStyleBackColor = true;
            this.dashBoardButton.Click += new System.EventHandler(this.dashBoardButton_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(200, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1479, 849);
            this.mainPanel.TabIndex = 2;
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1679, 849);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.sidebarNavPanel);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Page";
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
    }
}

