namespace GymManagementSystem.Views
{
    partial class PTSessionForm
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
            this.editSessionButton = new System.Windows.Forms.Button();
            this.cancelSessionButton = new System.Windows.Forms.Button();
            this.createSessionButton = new System.Windows.Forms.Button();
            this.sessionDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sessionDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // editSessionButton
            // 
            this.editSessionButton.Location = new System.Drawing.Point(534, 38);
            this.editSessionButton.Margin = new System.Windows.Forms.Padding(2);
            this.editSessionButton.Name = "editSessionButton";
            this.editSessionButton.Size = new System.Drawing.Size(115, 40);
            this.editSessionButton.TabIndex = 31;
            this.editSessionButton.Text = "Edit Session";
            this.editSessionButton.UseVisualStyleBackColor = true;
            this.editSessionButton.Click += new System.EventHandler(this.editSessionButton_Click);
            // 
            // cancelSessionButton
            // 
            this.cancelSessionButton.Location = new System.Drawing.Point(653, 38);
            this.cancelSessionButton.Margin = new System.Windows.Forms.Padding(2);
            this.cancelSessionButton.Name = "cancelSessionButton";
            this.cancelSessionButton.Size = new System.Drawing.Size(115, 40);
            this.cancelSessionButton.TabIndex = 30;
            this.cancelSessionButton.Text = "Cancel Session";
            this.cancelSessionButton.UseVisualStyleBackColor = true;
            this.cancelSessionButton.Click += new System.EventHandler(this.cancelSessionButton_Click);
            // 
            // createSessionButton
            // 
            this.createSessionButton.Location = new System.Drawing.Point(415, 38);
            this.createSessionButton.Margin = new System.Windows.Forms.Padding(2);
            this.createSessionButton.Name = "createSessionButton";
            this.createSessionButton.Size = new System.Drawing.Size(115, 40);
            this.createSessionButton.TabIndex = 29;
            this.createSessionButton.Text = "Create Session";
            this.createSessionButton.UseVisualStyleBackColor = true;
            this.createSessionButton.Click += new System.EventHandler(this.createSessionButton_Click);
            // 
            // sessionDataGridView
            // 
            this.sessionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sessionDataGridView.Location = new System.Drawing.Point(11, 82);
            this.sessionDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.sessionDataGridView.Name = "sessionDataGridView";
            this.sessionDataGridView.RowHeadersVisible = false;
            this.sessionDataGridView.RowHeadersWidth = 62;
            this.sessionDataGridView.RowTemplate.Height = 28;
            this.sessionDataGridView.Size = new System.Drawing.Size(758, 356);
            this.sessionDataGridView.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 24);
            this.label1.TabIndex = 27;
            this.label1.Text = "PT Sessions";
            // 
            // PTSessionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 449);
            this.Controls.Add(this.editSessionButton);
            this.Controls.Add(this.cancelSessionButton);
            this.Controls.Add(this.createSessionButton);
            this.Controls.Add(this.sessionDataGridView);
            this.Controls.Add(this.label1);
            this.Name = "PTSessionForm";
            this.Text = "PTSessionForm";
            ((System.ComponentModel.ISupportInitialize)(this.sessionDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button editSessionButton;
        private System.Windows.Forms.Button cancelSessionButton;
        private System.Windows.Forms.Button createSessionButton;
        private System.Windows.Forms.DataGridView sessionDataGridView;
        private System.Windows.Forms.Label label1;
    }
}