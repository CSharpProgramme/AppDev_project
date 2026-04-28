namespace GymManagementSystem.Views.AllRegisterForms
{
    partial class EmployeeRegisterForm
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
            this.firstName_textbox = new System.Windows.Forms.TextBox();
            this.email_textBox = new System.Windows.Forms.TextBox();
            this.phone_textBox = new System.Windows.Forms.TextBox();
            this.lastName_textBox = new System.Windows.Forms.TextBox();
            this.position_textBox = new System.Windows.Forms.TextBox();
            this.salary_textBox = new System.Windows.Forms.TextBox();
            this.confirmButton = new System.Windows.Forms.Button();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.username_textBox = new System.Windows.Forms.TextBox();
            this.role_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // firstName_textbox
            // 
            this.firstName_textbox.Location = new System.Drawing.Point(61, 96);
            this.firstName_textbox.Name = "firstName_textbox";
            this.firstName_textbox.Size = new System.Drawing.Size(165, 22);
            this.firstName_textbox.TabIndex = 0;
            // 
            // email_textBox
            // 
            this.email_textBox.Location = new System.Drawing.Point(61, 151);
            this.email_textBox.Name = "email_textBox";
            this.email_textBox.Size = new System.Drawing.Size(165, 22);
            this.email_textBox.TabIndex = 1;
            // 
            // phone_textBox
            // 
            this.phone_textBox.Location = new System.Drawing.Point(313, 151);
            this.phone_textBox.Name = "phone_textBox";
            this.phone_textBox.Size = new System.Drawing.Size(165, 22);
            this.phone_textBox.TabIndex = 3;
            // 
            // lastName_textBox
            // 
            this.lastName_textBox.Location = new System.Drawing.Point(313, 96);
            this.lastName_textBox.Name = "lastName_textBox";
            this.lastName_textBox.Size = new System.Drawing.Size(165, 22);
            this.lastName_textBox.TabIndex = 2;
            // 
            // position_textBox
            // 
            this.position_textBox.Location = new System.Drawing.Point(61, 223);
            this.position_textBox.Name = "position_textBox";
            this.position_textBox.Size = new System.Drawing.Size(165, 22);
            this.position_textBox.TabIndex = 4;
            // 
            // salary_textBox
            // 
            this.salary_textBox.Location = new System.Drawing.Point(313, 223);
            this.salary_textBox.Name = "salary_textBox";
            this.salary_textBox.Size = new System.Drawing.Size(165, 22);
            this.salary_textBox.TabIndex = 6;
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(218, 673);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(168, 44);
            this.confirmButton.TabIndex = 7;
            this.confirmButton.Text = "Confirm Button";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // password_textBox
            // 
            this.password_textBox.Location = new System.Drawing.Point(313, 292);
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.Size = new System.Drawing.Size(165, 22);
            this.password_textBox.TabIndex = 9;
            // 
            // username_textBox
            // 
            this.username_textBox.Location = new System.Drawing.Point(61, 292);
            this.username_textBox.Name = "username_textBox";
            this.username_textBox.Size = new System.Drawing.Size(165, 22);
            this.username_textBox.TabIndex = 8;
            // 
            // role_textBox
            // 
            this.role_textBox.Location = new System.Drawing.Point(61, 372);
            this.role_textBox.Name = "role_textBox";
            this.role_textBox.Size = new System.Drawing.Size(165, 22);
            this.role_textBox.TabIndex = 10;
            // 
            // EmployeeRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 778);
            this.Controls.Add(this.role_textBox);
            this.Controls.Add(this.password_textBox);
            this.Controls.Add(this.username_textBox);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.salary_textBox);
            this.Controls.Add(this.position_textBox);
            this.Controls.Add(this.phone_textBox);
            this.Controls.Add(this.lastName_textBox);
            this.Controls.Add(this.email_textBox);
            this.Controls.Add(this.firstName_textbox);
            this.Name = "EmployeeRegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Register Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstName_textbox;
        private System.Windows.Forms.TextBox email_textBox;
        private System.Windows.Forms.TextBox phone_textBox;
        private System.Windows.Forms.TextBox lastName_textBox;
        private System.Windows.Forms.TextBox position_textBox;
        private System.Windows.Forms.TextBox salary_textBox;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.TextBox password_textBox;
        private System.Windows.Forms.TextBox username_textBox;
        private System.Windows.Forms.TextBox role_textBox;
    }
}