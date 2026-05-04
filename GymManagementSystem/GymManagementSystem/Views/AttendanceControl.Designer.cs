namespace GymManagementSystem
{
    partial class AttendanceControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.dgvCurrentlyIn = new System.Windows.Forms.DataGridView();
            this.dgvSearchResults = new System.Windows.Forms.DataGridView();
            this.dgvAttendanceLog = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.MemberID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCurId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCurName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCurCheckIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLogName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLogCheckIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLogCheckOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentlyIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendanceLog)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Member Check In / Out";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Search Member:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 571);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Currently in Gym:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(258, 129);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(259, 32);
            this.textBox1.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.AutoSize = true;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(549, 128);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 35);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.AutoSize = true;
            this.btnCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckIn.Location = new System.Drawing.Point(417, 486);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(100, 35);
            this.btnCheckIn.TabIndex = 5;
            this.btnCheckIn.Text = "Check In";
            this.btnCheckIn.UseVisualStyleBackColor = true;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.AutoSize = true;
            this.btnCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.Location = new System.Drawing.Point(549, 486);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(116, 35);
            this.btnCheckOut.TabIndex = 6;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // dgvCurrentlyIn
            // 
            this.dgvCurrentlyIn.AllowUserToResizeColumns = false;
            this.dgvCurrentlyIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCurrentlyIn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCurId,
            this.colCurName,
            this.colCurCheckIn});
            this.dgvCurrentlyIn.Location = new System.Drawing.Point(66, 616);
            this.dgvCurrentlyIn.MultiSelect = false;
            this.dgvCurrentlyIn.Name = "dgvCurrentlyIn";
            this.dgvCurrentlyIn.ReadOnly = true;
            this.dgvCurrentlyIn.RowHeadersVisible = false;
            this.dgvCurrentlyIn.RowHeadersWidth = 62;
            this.dgvCurrentlyIn.RowTemplate.Height = 28;
            this.dgvCurrentlyIn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCurrentlyIn.Size = new System.Drawing.Size(576, 363);
            this.dgvCurrentlyIn.TabIndex = 7;
            // 
            // dgvSearchResults
            // 
            this.dgvSearchResults.AllowUserToResizeColumns = false;
            this.dgvSearchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MemberID,
            this.FName,
            this.LName,
            this.Email,
            this.Phone,
            this.Status});
            this.dgvSearchResults.Location = new System.Drawing.Point(66, 199);
            this.dgvSearchResults.MultiSelect = false;
            this.dgvSearchResults.Name = "dgvSearchResults";
            this.dgvSearchResults.ReadOnly = true;
            this.dgvSearchResults.RowHeadersVisible = false;
            this.dgvSearchResults.RowHeadersWidth = 62;
            this.dgvSearchResults.RowTemplate.Height = 28;
            this.dgvSearchResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSearchResults.Size = new System.Drawing.Size(1086, 247);
            this.dgvSearchResults.TabIndex = 8;
            // 
            // dgvAttendanceLog
            // 
            this.dgvAttendanceLog.AllowUserToResizeColumns = false;
            this.dgvAttendanceLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttendanceLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLogName,
            this.colLogCheckIn,
            this.colLogCheckOut});
            this.dgvAttendanceLog.Location = new System.Drawing.Point(697, 616);
            this.dgvAttendanceLog.MultiSelect = false;
            this.dgvAttendanceLog.Name = "dgvAttendanceLog";
            this.dgvAttendanceLog.ReadOnly = true;
            this.dgvAttendanceLog.RowHeadersVisible = false;
            this.dgvAttendanceLog.RowHeadersWidth = 62;
            this.dgvAttendanceLog.RowTemplate.Height = 28;
            this.dgvAttendanceLog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAttendanceLog.Size = new System.Drawing.Size(699, 363);
            this.dgvAttendanceLog.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(692, 571);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(250, 26);
            this.label4.TabIndex = 10;
            this.label4.Text = "Today\'s Attendance Log:";
            // 
            // MemberID
            // 
            this.MemberID.DataPropertyName = "MemberID";
            this.MemberID.HeaderText = "ID";
            this.MemberID.MinimumWidth = 8;
            this.MemberID.Name = "MemberID";
            this.MemberID.ReadOnly = true;
            this.MemberID.Width = 60;
            // 
            // FName
            // 
            this.FName.DataPropertyName = "FName";
            this.FName.HeaderText = "First Name";
            this.FName.MinimumWidth = 8;
            this.FName.Name = "FName";
            this.FName.ReadOnly = true;
            this.FName.Width = 130;
            // 
            // LName
            // 
            this.LName.DataPropertyName = "LName";
            this.LName.HeaderText = "Last Name";
            this.LName.MinimumWidth = 8;
            this.LName.Name = "LName";
            this.LName.ReadOnly = true;
            this.LName.Width = 130;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 8;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 200;
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "Phone";
            this.Phone.MinimumWidth = 8;
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            this.Phone.Width = 130;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 8;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // colCurId
            // 
            this.colCurId.DataPropertyName = "MemberId";
            this.colCurId.HeaderText = "ID";
            this.colCurId.MinimumWidth = 8;
            this.colCurId.Name = "colCurId";
            this.colCurId.ReadOnly = true;
            this.colCurId.Width = 60;
            // 
            // colCurName
            // 
            this.colCurName.DataPropertyName = "MemberName";
            this.colCurName.HeaderText = "Member Name";
            this.colCurName.MinimumWidth = 8;
            this.colCurName.Name = "colCurName";
            this.colCurName.ReadOnly = true;
            this.colCurName.Width = 200;
            // 
            // colCurCheckIn
            // 
            this.colCurCheckIn.DataPropertyName = "CheckIn";
            this.colCurCheckIn.HeaderText = "Check In Time";
            this.colCurCheckIn.MinimumWidth = 8;
            this.colCurCheckIn.Name = "colCurCheckIn";
            this.colCurCheckIn.ReadOnly = true;
            this.colCurCheckIn.Width = 200;
            // 
            // colLogName
            // 
            this.colLogName.DataPropertyName = "MemberName";
            this.colLogName.HeaderText = "Member Name";
            this.colLogName.MinimumWidth = 8;
            this.colLogName.Name = "colLogName";
            this.colLogName.ReadOnly = true;
            this.colLogName.Width = 180;
            // 
            // colLogCheckIn
            // 
            this.colLogCheckIn.DataPropertyName = "CheckIn";
            this.colLogCheckIn.HeaderText = "Check In";
            this.colLogCheckIn.MinimumWidth = 8;
            this.colLogCheckIn.Name = "colLogCheckIn";
            this.colLogCheckIn.ReadOnly = true;
            this.colLogCheckIn.Width = 160;
            // 
            // colLogCheckOut
            // 
            this.colLogCheckOut.DataPropertyName = "CheckOut";
            this.colLogCheckOut.HeaderText = "Check Out";
            this.colLogCheckOut.MinimumWidth = 8;
            this.colLogCheckOut.Name = "colLogCheckOut";
            this.colLogCheckOut.ReadOnly = true;
            this.colLogCheckOut.Width = 160;
            // 
            // AttendanceControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvAttendanceLog);
            this.Controls.Add(this.dgvSearchResults);
            this.Controls.Add(this.dgvCurrentlyIn);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.btnCheckIn);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AttendanceControl";
            this.Size = new System.Drawing.Size(1458, 1018);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentlyIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendanceLog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.DataGridView dgvCurrentlyIn;
        private System.Windows.Forms.DataGridView dgvSearchResults;
        private System.Windows.Forms.DataGridView dgvAttendanceLog;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCurId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCurName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCurCheckIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLogName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLogCheckIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLogCheckOut;
    }
}
