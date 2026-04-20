namespace GymManagementSystem.Views
{
    partial class RegisterForm
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
            this.registerMemLabel = new System.Windows.Forms.Label();
            this.personalInfoLlabel = new System.Windows.Forms.Label();
            this.fNameTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.lNameTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.titelPanel = new System.Windows.Forms.Panel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.personalInfoPanel = new System.Windows.Forms.Panel();
            this.birthdayTimePicker = new System.Windows.Forms.DateTimePicker();
            this.membershipPanel = new System.Windows.Forms.Panel();
            this.flowLayoutPlanPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.subscriptionLabel = new System.Windows.Forms.Label();
            this.finalizeButton = new System.Windows.Forms.Button();
            this.emergencyPhoneTextBox = new System.Windows.Forms.TextBox();
            this.emergencyContactTextBox = new System.Windows.Forms.TextBox();
            this.emergencyContactLabel = new System.Windows.Forms.Label();
            this.EmergencyPanel = new System.Windows.Forms.Panel();
            this.paymentComboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.taxLabel = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.paymentLabel = new System.Windows.Forms.Label();
            this.showAmountTextBox = new System.Windows.Forms.TextBox();
            this.gymManagementDBDataSet = new GymManagementSystem.GymManagementDBDataSet();
            this.membership_PlanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.membership_PlanTableAdapter = new GymManagementSystem.GymManagementDBDataSetTableAdapters.Membership_PlanTableAdapter();
            this.tableAdapterManager = new GymManagementSystem.GymManagementDBDataSetTableAdapters.TableAdapterManager();
            this.titelPanel.SuspendLayout();
            this.personalInfoPanel.SuspendLayout();
            this.membershipPanel.SuspendLayout();
            this.EmergencyPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gymManagementDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membership_PlanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // registerMemLabel
            // 
            this.registerMemLabel.AutoSize = true;
            this.registerMemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerMemLabel.Location = new System.Drawing.Point(20, 17);
            this.registerMemLabel.Name = "registerMemLabel";
            this.registerMemLabel.Size = new System.Drawing.Size(277, 32);
            this.registerMemLabel.TabIndex = 0;
            this.registerMemLabel.Text = "Member Registration";
            // 
            // personalInfoLlabel
            // 
            this.personalInfoLlabel.AutoSize = true;
            this.personalInfoLlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personalInfoLlabel.Location = new System.Drawing.Point(21, 14);
            this.personalInfoLlabel.Name = "personalInfoLlabel";
            this.personalInfoLlabel.Size = new System.Drawing.Size(234, 29);
            this.personalInfoLlabel.TabIndex = 1;
            this.personalInfoLlabel.Text = "Personal Information";
            // 
            // fNameTextBox
            // 
            this.fNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fNameTextBox.Location = new System.Drawing.Point(26, 69);
            this.fNameTextBox.Name = "fNameTextBox";
            this.fNameTextBox.Size = new System.Drawing.Size(280, 28);
            this.fNameTextBox.TabIndex = 2;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneTextBox.Location = new System.Drawing.Point(363, 130);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(266, 28);
            this.phoneTextBox.TabIndex = 3;
            // 
            // lNameTextBox
            // 
            this.lNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNameTextBox.Location = new System.Drawing.Point(26, 130);
            this.lNameTextBox.Name = "lNameTextBox";
            this.lNameTextBox.Size = new System.Drawing.Size(280, 28);
            this.lNameTextBox.TabIndex = 4;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.Location = new System.Drawing.Point(363, 69);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(266, 28);
            this.emailTextBox.TabIndex = 5;
            // 
            // titelPanel
            // 
            this.titelPanel.Controls.Add(this.registerMemLabel);
            this.titelPanel.Location = new System.Drawing.Point(39, 21);
            this.titelPanel.Name = "titelPanel";
            this.titelPanel.Size = new System.Drawing.Size(687, 62);
            this.titelPanel.TabIndex = 9;
            // 
            // cancelButton
            // 
            this.cancelButton.AutoSize = true;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(451, 957);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(84, 35);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // personalInfoPanel
            // 
            this.personalInfoPanel.Controls.Add(this.birthdayTimePicker);
            this.personalInfoPanel.Controls.Add(this.personalInfoLlabel);
            this.personalInfoPanel.Controls.Add(this.fNameTextBox);
            this.personalInfoPanel.Controls.Add(this.emailTextBox);
            this.personalInfoPanel.Controls.Add(this.lNameTextBox);
            this.personalInfoPanel.Controls.Add(this.phoneTextBox);
            this.personalInfoPanel.Location = new System.Drawing.Point(39, 106);
            this.personalInfoPanel.Name = "personalInfoPanel";
            this.personalInfoPanel.Size = new System.Drawing.Size(687, 248);
            this.personalInfoPanel.TabIndex = 10;
            // 
            // birthdayTimePicker
            // 
            this.birthdayTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthdayTimePicker.Location = new System.Drawing.Point(26, 187);
            this.birthdayTimePicker.Name = "birthdayTimePicker";
            this.birthdayTimePicker.Size = new System.Drawing.Size(223, 28);
            this.birthdayTimePicker.TabIndex = 6;
            // 
            // membershipPanel
            // 
            this.membershipPanel.Controls.Add(this.flowLayoutPlanPanel);
            this.membershipPanel.Location = new System.Drawing.Point(65, 562);
            this.membershipPanel.Name = "membershipPanel";
            this.membershipPanel.Size = new System.Drawing.Size(661, 122);
            this.membershipPanel.TabIndex = 12;
            // 
            // flowLayoutPlanPanel
            // 
            this.flowLayoutPlanPanel.AutoScroll = true;
            this.flowLayoutPlanPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPlanPanel.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPlanPanel.Name = "flowLayoutPlanPanel";
            this.flowLayoutPlanPanel.Size = new System.Drawing.Size(661, 122);
            this.flowLayoutPlanPanel.TabIndex = 3;
            // 
            // subscriptionLabel
            // 
            this.subscriptionLabel.AutoSize = true;
            this.subscriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subscriptionLabel.Location = new System.Drawing.Point(60, 516);
            this.subscriptionLabel.Name = "subscriptionLabel";
            this.subscriptionLabel.Size = new System.Drawing.Size(202, 29);
            this.subscriptionLabel.TabIndex = 1;
            this.subscriptionLabel.Text = "Membership Plan";
            // 
            // finalizeButton
            // 
            this.finalizeButton.AutoSize = true;
            this.finalizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalizeButton.Location = new System.Drawing.Point(235, 957);
            this.finalizeButton.Name = "finalizeButton";
            this.finalizeButton.Size = new System.Drawing.Size(170, 35);
            this.finalizeButton.TabIndex = 13;
            this.finalizeButton.Text = "Register Member";
            this.finalizeButton.UseVisualStyleBackColor = true;
            this.finalizeButton.Click += new System.EventHandler(this.finalizeButton_Click);
            // 
            // emergencyPhoneTextBox
            // 
            this.emergencyPhoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emergencyPhoneTextBox.Location = new System.Drawing.Point(363, 56);
            this.emergencyPhoneTextBox.Name = "emergencyPhoneTextBox";
            this.emergencyPhoneTextBox.Size = new System.Drawing.Size(266, 28);
            this.emergencyPhoneTextBox.TabIndex = 5;
            // 
            // emergencyContactTextBox
            // 
            this.emergencyContactTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emergencyContactTextBox.Location = new System.Drawing.Point(26, 56);
            this.emergencyContactTextBox.Name = "emergencyContactTextBox";
            this.emergencyContactTextBox.Size = new System.Drawing.Size(280, 28);
            this.emergencyContactTextBox.TabIndex = 2;
            // 
            // emergencyContactLabel
            // 
            this.emergencyContactLabel.AutoSize = true;
            this.emergencyContactLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emergencyContactLabel.Location = new System.Drawing.Point(21, 13);
            this.emergencyContactLabel.Name = "emergencyContactLabel";
            this.emergencyContactLabel.Size = new System.Drawing.Size(222, 29);
            this.emergencyContactLabel.TabIndex = 1;
            this.emergencyContactLabel.Text = "Emergency Contact";
            // 
            // EmergencyPanel
            // 
            this.EmergencyPanel.Controls.Add(this.emergencyContactLabel);
            this.EmergencyPanel.Controls.Add(this.emergencyContactTextBox);
            this.EmergencyPanel.Controls.Add(this.emergencyPhoneTextBox);
            this.EmergencyPanel.Location = new System.Drawing.Point(39, 377);
            this.EmergencyPanel.Name = "EmergencyPanel";
            this.EmergencyPanel.Size = new System.Drawing.Size(687, 113);
            this.EmergencyPanel.TabIndex = 11;
            // 
            // paymentComboBox
            // 
            this.paymentComboBox.FormattingEnabled = true;
            this.paymentComboBox.Location = new System.Drawing.Point(26, 63);
            this.paymentComboBox.Name = "paymentComboBox";
            this.paymentComboBox.Size = new System.Drawing.Size(261, 28);
            this.paymentComboBox.TabIndex = 2;
            this.paymentComboBox.Text = "Select a Payment Method";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.taxLabel);
            this.panel1.Controls.Add(this.amountLabel);
            this.panel1.Controls.Add(this.paymentLabel);
            this.panel1.Controls.Add(this.paymentComboBox);
            this.panel1.Controls.Add(this.showAmountTextBox);
            this.panel1.Location = new System.Drawing.Point(39, 690);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(687, 230);
            this.panel1.TabIndex = 12;
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxLabel.Location = new System.Drawing.Point(26, 120);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(87, 22);
            this.taxLabel.TabIndex = 4;
            this.taxLabel.Text = "Tax: 15%";
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountLabel.Location = new System.Drawing.Point(26, 166);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(122, 22);
            this.amountLabel.TabIndex = 3;
            this.amountLabel.Text = "Total Amount:";
            // 
            // paymentLabel
            // 
            this.paymentLabel.AutoSize = true;
            this.paymentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentLabel.Location = new System.Drawing.Point(21, 13);
            this.paymentLabel.Name = "paymentLabel";
            this.paymentLabel.Size = new System.Drawing.Size(186, 29);
            this.paymentLabel.TabIndex = 1;
            this.paymentLabel.Text = "Payment Details";
            // 
            // showAmountTextBox
            // 
            this.showAmountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showAmountTextBox.Location = new System.Drawing.Point(154, 163);
            this.showAmountTextBox.Name = "showAmountTextBox";
            this.showAmountTextBox.ReadOnly = true;
            this.showAmountTextBox.Size = new System.Drawing.Size(280, 28);
            this.showAmountTextBox.TabIndex = 2;
            // 
            // gymManagementDBDataSet
            // 
            this.gymManagementDBDataSet.DataSetName = "GymManagementDBDataSet";
            this.gymManagementDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // membership_PlanBindingSource
            // 
            this.membership_PlanBindingSource.DataMember = "Membership_Plan";
            this.membership_PlanBindingSource.DataSource = this.gymManagementDBDataSet;
            // 
            // membership_PlanTableAdapter
            // 
            this.membership_PlanTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AttendanceTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EquipmentTableAdapter = null;
            this.tableAdapterManager.LockerTableAdapter = null;
            this.tableAdapterManager.Member_ProgressTableAdapter = null;
            this.tableAdapterManager.Membership_PlanTableAdapter = this.membership_PlanTableAdapter;
            this.tableAdapterManager.MemberTableAdapter = null;
            this.tableAdapterManager.PaymentTableAdapter = null;
            this.tableAdapterManager.PT_SessionTableAdapter = null;
            this.tableAdapterManager.StaffTableAdapter = null;
            this.tableAdapterManager.SubscriptionTableAdapter = null;
            this.tableAdapterManager.TrainerTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GymManagementSystem.GymManagementDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 1028);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.finalizeButton);
            this.Controls.Add(this.subscriptionLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.membershipPanel);
            this.Controls.Add(this.EmergencyPanel);
            this.Controls.Add(this.personalInfoPanel);
            this.Controls.Add(this.titelPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register a Member";
            this.titelPanel.ResumeLayout(false);
            this.titelPanel.PerformLayout();
            this.personalInfoPanel.ResumeLayout(false);
            this.personalInfoPanel.PerformLayout();
            this.membershipPanel.ResumeLayout(false);
            this.EmergencyPanel.ResumeLayout(false);
            this.EmergencyPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gymManagementDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membership_PlanBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label registerMemLabel;
        private System.Windows.Forms.Label personalInfoLlabel;
        private System.Windows.Forms.TextBox fNameTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox lNameTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Panel titelPanel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Panel personalInfoPanel;
        private System.Windows.Forms.Panel membershipPanel;
        private System.Windows.Forms.Label subscriptionLabel;
        private System.Windows.Forms.Button finalizeButton;
        private System.Windows.Forms.DateTimePicker birthdayTimePicker;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPlanPanel;
        private System.Windows.Forms.TextBox emergencyPhoneTextBox;
        private System.Windows.Forms.TextBox emergencyContactTextBox;
        private System.Windows.Forms.Label emergencyContactLabel;
        private System.Windows.Forms.Panel EmergencyPanel;
        private System.Windows.Forms.ComboBox paymentComboBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label paymentLabel;
        private System.Windows.Forms.TextBox showAmountTextBox;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label taxLabel;
        private GymManagementDBDataSet gymManagementDBDataSet;
        private System.Windows.Forms.BindingSource membership_PlanBindingSource;
        private GymManagementDBDataSetTableAdapters.Membership_PlanTableAdapter membership_PlanTableAdapter;
        private GymManagementDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}