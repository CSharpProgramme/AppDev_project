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
            this.titelPanel.SuspendLayout();
            this.personalInfoPanel.SuspendLayout();
            this.membershipPanel.SuspendLayout();
            this.EmergencyPanel.SuspendLayout();
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
            this.fNameTextBox.Location = new System.Drawing.Point(17, 69);
            this.fNameTextBox.Name = "fNameTextBox";
            this.fNameTextBox.Size = new System.Drawing.Size(232, 26);
            this.fNameTextBox.TabIndex = 2;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(289, 130);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(228, 26);
            this.phoneTextBox.TabIndex = 3;
            // 
            // lNameTextBox
            // 
            this.lNameTextBox.Location = new System.Drawing.Point(17, 130);
            this.lNameTextBox.Name = "lNameTextBox";
            this.lNameTextBox.Size = new System.Drawing.Size(232, 26);
            this.lNameTextBox.TabIndex = 4;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(289, 69);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(228, 26);
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
            this.cancelButton.Location = new System.Drawing.Point(409, 829);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 30);
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
            this.birthdayTimePicker.Location = new System.Drawing.Point(26, 187);
            this.birthdayTimePicker.Name = "birthdayTimePicker";
            this.birthdayTimePicker.Size = new System.Drawing.Size(223, 26);
            this.birthdayTimePicker.TabIndex = 6;
            // 
            // membershipPanel
            // 
            this.membershipPanel.Controls.Add(this.flowLayoutPlanPanel);
            this.membershipPanel.Location = new System.Drawing.Point(39, 562);
            this.membershipPanel.Name = "membershipPanel";
            this.membershipPanel.Size = new System.Drawing.Size(783, 250);
            this.membershipPanel.TabIndex = 12;
            // 
            // flowLayoutPlanPanel
            // 
            this.flowLayoutPlanPanel.AutoScroll = true;
            this.flowLayoutPlanPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPlanPanel.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPlanPanel.Name = "flowLayoutPlanPanel";
            this.flowLayoutPlanPanel.Size = new System.Drawing.Size(783, 250);
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
            this.finalizeButton.Location = new System.Drawing.Point(225, 829);
            this.finalizeButton.Name = "finalizeButton";
            this.finalizeButton.Size = new System.Drawing.Size(141, 30);
            this.finalizeButton.TabIndex = 13;
            this.finalizeButton.Text = "Register Member";
            this.finalizeButton.UseVisualStyleBackColor = true;
            this.finalizeButton.Click += new System.EventHandler(this.finalizeButton_Click);
            // 
            // emergencyPhoneTextBox
            // 
            this.emergencyPhoneTextBox.Location = new System.Drawing.Point(289, 56);
            this.emergencyPhoneTextBox.Name = "emergencyPhoneTextBox";
            this.emergencyPhoneTextBox.Size = new System.Drawing.Size(228, 26);
            this.emergencyPhoneTextBox.TabIndex = 5;
            // 
            // emergencyContactTextBox
            // 
            this.emergencyContactTextBox.Location = new System.Drawing.Point(17, 56);
            this.emergencyContactTextBox.Name = "emergencyContactTextBox";
            this.emergencyContactTextBox.Size = new System.Drawing.Size(232, 26);
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
            this.EmergencyPanel.Location = new System.Drawing.Point(39, 378);
            this.EmergencyPanel.Name = "EmergencyPanel";
            this.EmergencyPanel.Size = new System.Drawing.Size(687, 113);
            this.EmergencyPanel.TabIndex = 11;
            // 
            // paymentComboBox
            // 
            this.paymentComboBox.FormattingEnabled = true;
            this.paymentComboBox.Location = new System.Drawing.Point(831, 680);
            this.paymentComboBox.Name = "paymentComboBox";
            this.paymentComboBox.Size = new System.Drawing.Size(216, 28);
            this.paymentComboBox.TabIndex = 2;
            this.paymentComboBox.Text = "Select a Payment";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 886);
            this.Controls.Add(this.paymentComboBox);
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
    }
}