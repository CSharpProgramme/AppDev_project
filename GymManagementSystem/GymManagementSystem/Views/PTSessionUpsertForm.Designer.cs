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
            this.searchMemTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gymManagementDBDataSet = new GymManagementSystem.GymManagementDBDataSet();
            this.gymManagementDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.memberTableAdapter = new GymManagementSystem.GymManagementDBDataSetTableAdapters.MemberTableAdapter();
            this.memberDataGridView = new System.Windows.Forms.DataGridView();
            this.trainerDataGridView = new System.Windows.Forms.DataGridView();
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
            this.searchMembtn.Location = new System.Drawing.Point(11, 308);
            this.searchMembtn.Margin = new System.Windows.Forms.Padding(2);
            this.searchMembtn.Name = "searchMembtn";
            this.searchMembtn.Size = new System.Drawing.Size(103, 27);
            this.searchMembtn.TabIndex = 7;
            this.searchMembtn.Text = "Search";
            this.searchMembtn.UseVisualStyleBackColor = true;
            // 
            // searchMemTextBox
            // 
            this.searchMemTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchMemTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchMemTextBox.Location = new System.Drawing.Point(11, 280);
            this.searchMemTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.searchMemTextBox.Name = "searchMemTextBox";
            this.searchMemTextBox.Size = new System.Drawing.Size(200, 21);
            this.searchMemTextBox.TabIndex = 6;
            this.searchMemTextBox.Tag = "";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(11, 55);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 27);
            this.button1.TabIndex = 9;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(11, 27);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 21);
            this.textBox1.TabIndex = 8;
            this.textBox1.Tag = "";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(7, 254);
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
            this.memberDataGridView.Location = new System.Drawing.Point(11, 87);
            this.memberDataGridView.Name = "memberDataGridView";
            this.memberDataGridView.Size = new System.Drawing.Size(710, 164);
            this.memberDataGridView.TabIndex = 12;
            // 
            // trainerDataGridView
            // 
            this.trainerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.trainerDataGridView.Location = new System.Drawing.Point(11, 308);
            this.trainerDataGridView.Name = "trainerDataGridView";
            this.trainerDataGridView.Size = new System.Drawing.Size(710, 164);
            this.trainerDataGridView.TabIndex = 13;
            // 
            // PTSessionUpsertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 572);
            this.Controls.Add(this.trainerDataGridView);
            this.Controls.Add(this.memberDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.searchMembtn);
            this.Controls.Add(this.searchMemTextBox);
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
        private System.Windows.Forms.TextBox searchMemTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource gymManagementDBDataSetBindingSource;
        private GymManagementDBDataSet gymManagementDBDataSet;
        private System.Windows.Forms.BindingSource memberBindingSource;
        private GymManagementDBDataSetTableAdapters.MemberTableAdapter memberTableAdapter;
        private System.Windows.Forms.DataGridView memberDataGridView;
        private System.Windows.Forms.DataGridView trainerDataGridView;
    }
}