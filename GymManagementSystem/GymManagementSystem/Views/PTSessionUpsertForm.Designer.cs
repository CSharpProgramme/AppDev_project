namespace GymManagementSystem.Views
{
    partial class PTSessionUpsertForm
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
            this.searchMembtn = new System.Windows.Forms.Button();
            this.trainerTextBox = new System.Windows.Forms.TextBox();
            this.searchMembersButton = new System.Windows.Forms.Button();
            this.memberTextBox = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gymManagementDBDataSet = new GymManagementSystem.GymManagementDBDataSet();
            this.gymManagementDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.memberTableAdapter = new GymManagementSystem.GymManagementDBDataSetTableAdapters.MemberTableAdapter();
            this.memberDataGridView = new System.Windows.Forms.DataGridView();
            this.trainerDataGridView = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.timeTextBox = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.scheduledAtPicker = new System.Windows.Forms.DateTimePicker();
            this.searchTrainersButton = new System.Windows.Forms.Button();
            this.durationLabel = new System.Windows.Forms.Label();
            this.durationTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gymManagementDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymManagementDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainerDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // searchMembtn
            // 
            this.searchMembtn.AutoSize = true;
            this.searchMembtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchMembtn.Location = new System.Drawing.Point(11, 280);
            this.searchMembtn.Margin = new System.Windows.Forms.Padding(2);
            this.searchMembtn.Name = "searchMembtn";
            this.searchMembtn.Size = new System.Drawing.Size(103, 27);
            this.searchMembtn.TabIndex = 7;
            this.searchMembtn.Text = "Search";
            this.searchMembtn.UseVisualStyleBackColor = true;
            // 
            // trainerTextBox
            // 
            this.trainerTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.trainerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trainerTextBox.Location = new System.Drawing.Point(11, 252);
            this.trainerTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.trainerTextBox.Name = "trainerTextBox";
            this.trainerTextBox.Size = new System.Drawing.Size(200, 21);
            this.trainerTextBox.TabIndex = 6;
            this.trainerTextBox.Tag = "";
            // 
            // searchMembersButton
            // 
            this.searchMembersButton.AutoSize = true;
            this.searchMembersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchMembersButton.Location = new System.Drawing.Point(215, 27);
            this.searchMembersButton.Margin = new System.Windows.Forms.Padding(2);
            this.searchMembersButton.Name = "searchMembersButton";
            this.searchMembersButton.Size = new System.Drawing.Size(103, 27);
            this.searchMembersButton.TabIndex = 9;
            this.searchMembersButton.Text = "Search";
            this.searchMembersButton.UseVisualStyleBackColor = true;
            this.searchMembersButton.Click += new System.EventHandler(this.searchMembersButton_Click);
            // 
            // memberTextBox
            // 
            this.memberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.memberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberTextBox.Location = new System.Drawing.Point(11, 27);
            this.memberTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.memberTextBox.Name = "memberTextBox";
            this.memberTextBox.Size = new System.Drawing.Size(200, 21);
            this.memberTextBox.TabIndex = 8;
            this.memberTextBox.Tag = "";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(7, 226);
            this.Label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(127, 24);
            this.Label2.TabIndex = 10;
            this.Label2.Text = "Select Trainer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 1);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Select Member";
            // 
            // gymManagementDBDataSet
            // 
            this.gymManagementDBDataSet.DataSetName = "GymManagementDBDataSet";
            this.gymManagementDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gymManagementDBDataSetBindingSource
            // 
            this.gymManagementDBDataSetBindingSource.DataSource = this.gymManagementDBDataSet;
            this.gymManagementDBDataSetBindingSource.Position = 0;
            // 
            // memberBindingSource
            // 
            this.memberBindingSource.DataMember = "Member";
            this.memberBindingSource.DataSource = this.gymManagementDBDataSetBindingSource;
            // 
            // memberTableAdapter
            // 
            this.memberTableAdapter.ClearBeforeFill = true;
            // 
            // memberDataGridView
            // 
            this.memberDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.memberDataGridView.Location = new System.Drawing.Point(11, 59);
            this.memberDataGridView.Name = "memberDataGridView";
            this.memberDataGridView.Size = new System.Drawing.Size(710, 164);
            this.memberDataGridView.TabIndex = 12;
            // 
            // trainerDataGridView
            // 
            this.trainerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.trainerDataGridView.Location = new System.Drawing.Point(11, 280);
            this.trainerDataGridView.Name = "trainerDataGridView";
            this.trainerDataGridView.Size = new System.Drawing.Size(710, 164);
            this.trainerDataGridView.TabIndex = 13;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // timeTextBox
            // 
            this.timeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeTextBox.Location = new System.Drawing.Point(145, 468);
            this.timeTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.Size = new System.Drawing.Size(88, 21);
            this.timeTextBox.TabIndex = 15;
            this.timeTextBox.Tag = "";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(608, 553);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(113, 42);
            this.exitButton.TabIndex = 16;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(480, 553);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(113, 42);
            this.createButton.TabIndex = 17;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(81, 467);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 24);
            this.label3.TabIndex = 18;
            this.label3.Text = "Time:";
            // 
            // scheduledAtPicker
            // 
            this.scheduledAtPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scheduledAtPicker.Location = new System.Drawing.Point(262, 468);
            this.scheduledAtPicker.Margin = new System.Windows.Forms.Padding(2);
            this.scheduledAtPicker.Name = "scheduledAtPicker";
            this.scheduledAtPicker.Size = new System.Drawing.Size(150, 21);
            this.scheduledAtPicker.TabIndex = 19;
            // 
            // searchTrainersButton
            // 
            this.searchTrainersButton.AutoSize = true;
            this.searchTrainersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTrainersButton.Location = new System.Drawing.Point(215, 246);
            this.searchTrainersButton.Margin = new System.Windows.Forms.Padding(2);
            this.searchTrainersButton.Name = "searchTrainersButton";
            this.searchTrainersButton.Size = new System.Drawing.Size(103, 27);
            this.searchTrainersButton.TabIndex = 20;
            this.searchTrainersButton.Text = "Search";
            this.searchTrainersButton.UseVisualStyleBackColor = true;
            this.searchTrainersButton.Click += new System.EventHandler(this.searchTrainersButton_Click);
            // 
            // durationLabel
            // 
            this.durationLabel.AutoSize = true;
            this.durationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.durationLabel.Location = new System.Drawing.Point(11, 504);
            this.durationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.durationLabel.Name = "durationLabel";
            this.durationLabel.Size = new System.Drawing.Size(128, 24);
            this.durationLabel.TabIndex = 22;
            this.durationLabel.Text = "Duration(min):";
            // 
            // durationTextBox
            // 
            this.durationTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.durationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.durationTextBox.Location = new System.Drawing.Point(145, 507);
            this.durationTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.durationTextBox.Name = "durationTextBox";
            this.durationTextBox.Size = new System.Drawing.Size(88, 21);
            this.durationTextBox.TabIndex = 21;
            this.durationTextBox.Tag = "";
            // 
            // PTSessionUpsertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 607);
            this.Controls.Add(this.durationLabel);
            this.Controls.Add(this.durationTextBox);
            this.Controls.Add(this.searchTrainersButton);
            this.Controls.Add(this.scheduledAtPicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.timeTextBox);
            this.Controls.Add(this.trainerDataGridView);
            this.Controls.Add(this.memberDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.searchMembersButton);
            this.Controls.Add(this.memberTextBox);
            this.Controls.Add(this.searchMembtn);
            this.Controls.Add(this.trainerTextBox);
            this.Name = "PTSessionUpsertForm";
            this.Text = "PTSessionUpsertForm";
            this.Load += new System.EventHandler(this.PTSessionUpsertForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gymManagementDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymManagementDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainerDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchMembtn;
        private System.Windows.Forms.TextBox trainerTextBox;
        private System.Windows.Forms.Button searchMembersButton;
        private System.Windows.Forms.TextBox memberTextBox;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource gymManagementDBDataSetBindingSource;
        private GymManagementDBDataSet gymManagementDBDataSet;
        private System.Windows.Forms.BindingSource memberBindingSource;
        private GymManagementDBDataSetTableAdapters.MemberTableAdapter memberTableAdapter;
        private System.Windows.Forms.DataGridView memberDataGridView;
        private System.Windows.Forms.DataGridView trainerDataGridView;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox timeTextBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker scheduledAtPicker;
        private System.Windows.Forms.Button searchTrainersButton;
        private System.Windows.Forms.Label durationLabel;
        private System.Windows.Forms.TextBox durationTextBox;
    }
}