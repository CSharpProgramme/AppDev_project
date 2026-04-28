namespace GymManagementSystem
{
    partial class TrainerControl
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
            this.trainerDataGridView = new System.Windows.Forms.DataGridView();
            this.editTrainerButton = new System.Windows.Forms.Button();
            this.deleteTrainerButton = new System.Windows.Forms.Button();
            this.RegisterTrainerButton = new System.Windows.Forms.Button();
            this.viewPTSessionButton = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gymManagementDBDataSet = new GymManagementSystem.GymManagementDBDataSet();
            this.trainerTableAdapter = new GymManagementSystem.GymManagementDBDataSetTableAdapters.TrainerTableAdapter();
            this.tableAdapterManager = new GymManagementSystem.GymManagementDBDataSetTableAdapters.TableAdapterManager();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trainerDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymManagementDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // trainerDataGridView
            // 
            this.trainerDataGridView.AutoGenerateColumns = false;
            this.trainerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.trainerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.trainerDataGridView.DataSource = this.trainerBindingSource;
            this.trainerDataGridView.Location = new System.Drawing.Point(25, 137);
            this.trainerDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.trainerDataGridView.Name = "trainerDataGridView";
            this.trainerDataGridView.RowHeadersVisible = false;
            this.trainerDataGridView.RowHeadersWidth = 62;
            this.trainerDataGridView.RowTemplate.Height = 28;
            this.trainerDataGridView.Size = new System.Drawing.Size(858, 363);
            this.trainerDataGridView.TabIndex = 1;
            // 
            // editTrainerButton
            // 
            this.editTrainerButton.Location = new System.Drawing.Point(530, 68);
            this.editTrainerButton.Margin = new System.Windows.Forms.Padding(2);
            this.editTrainerButton.Name = "editTrainerButton";
            this.editTrainerButton.Size = new System.Drawing.Size(115, 40);
            this.editTrainerButton.TabIndex = 9;
            this.editTrainerButton.Text = "Edit Trainer";
            this.editTrainerButton.UseVisualStyleBackColor = true;
            this.editTrainerButton.Click += new System.EventHandler(this.editTrainerButton_Click);
            // 
            // deleteTrainerButton
            // 
            this.deleteTrainerButton.Location = new System.Drawing.Point(649, 68);
            this.deleteTrainerButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteTrainerButton.Name = "deleteTrainerButton";
            this.deleteTrainerButton.Size = new System.Drawing.Size(115, 40);
            this.deleteTrainerButton.TabIndex = 8;
            this.deleteTrainerButton.Text = "Delete Trainer";
            this.deleteTrainerButton.UseVisualStyleBackColor = true;
            this.deleteTrainerButton.Click += new System.EventHandler(this.deleteTrainerButton_Click);
            // 
            // RegisterTrainerButton
            // 
            this.RegisterTrainerButton.Location = new System.Drawing.Point(411, 68);
            this.RegisterTrainerButton.Margin = new System.Windows.Forms.Padding(2);
            this.RegisterTrainerButton.Name = "RegisterTrainerButton";
            this.RegisterTrainerButton.Size = new System.Drawing.Size(115, 40);
            this.RegisterTrainerButton.TabIndex = 7;
            this.RegisterTrainerButton.Text = "Register Trainer";
            this.RegisterTrainerButton.UseVisualStyleBackColor = true;
            this.RegisterTrainerButton.Click += new System.EventHandler(this.RegisterTrainerButton_Click);
            // 
            // viewPTSessionButton
            // 
            this.viewPTSessionButton.Location = new System.Drawing.Point(248, 68);
            this.viewPTSessionButton.Margin = new System.Windows.Forms.Padding(2);
            this.viewPTSessionButton.Name = "viewPTSessionButton";
            this.viewPTSessionButton.Size = new System.Drawing.Size(115, 40);
            this.viewPTSessionButton.TabIndex = 10;
            this.viewPTSessionButton.Text = "View PT Session";
            this.viewPTSessionButton.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "trainer_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "trainer_id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "first_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "first_name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "last_name";
            this.dataGridViewTextBoxColumn3.HeaderText = "last_name";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "email";
            this.dataGridViewTextBoxColumn4.HeaderText = "email";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "phone";
            this.dataGridViewTextBoxColumn5.HeaderText = "phone";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "specialization";
            this.dataGridViewTextBoxColumn6.HeaderText = "specialization";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "hourly_rate";
            this.dataGridViewTextBoxColumn7.HeaderText = "hourly_rate";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // trainerBindingSource
            // 
            this.trainerBindingSource.DataMember = "Trainer";
            this.trainerBindingSource.DataSource = this.gymManagementDBDataSet;
            // 
            // gymManagementDBDataSet
            // 
            this.gymManagementDBDataSet.DataSetName = "GymManagementDBDataSet";
            this.gymManagementDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // trainerTableAdapter
            // 
            this.trainerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AttendanceTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EquipmentTableAdapter = null;
            this.tableAdapterManager.LockerTableAdapter = null;
            this.tableAdapterManager.Member_ProgressTableAdapter = null;
            this.tableAdapterManager.Membership_PlanTableAdapter = null;
            this.tableAdapterManager.MemberTableAdapter = null;
            this.tableAdapterManager.PaymentTableAdapter = null;
            this.tableAdapterManager.PT_SessionTableAdapter = null;
            this.tableAdapterManager.StaffTableAdapter = null;
            this.tableAdapterManager.SubscriptionTableAdapter = null;
            this.tableAdapterManager.TrainerTableAdapter = this.trainerTableAdapter;
            this.tableAdapterManager.UpdateOrder = GymManagementSystem.GymManagementDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "Trainers";
            // 
            // TrainerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.viewPTSessionButton);
            this.Controls.Add(this.editTrainerButton);
            this.Controls.Add(this.deleteTrainerButton);
            this.Controls.Add(this.RegisterTrainerButton);
            this.Controls.Add(this.trainerDataGridView);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TrainerControl";
            this.Size = new System.Drawing.Size(943, 526);
            ((System.ComponentModel.ISupportInitialize)(this.trainerDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymManagementDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GymManagementDBDataSet gymManagementDBDataSet;
        private System.Windows.Forms.BindingSource trainerBindingSource;
        private GymManagementDBDataSetTableAdapters.TrainerTableAdapter trainerTableAdapter;
        private GymManagementDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView trainerDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Button editTrainerButton;
        private System.Windows.Forms.Button deleteTrainerButton;
        private System.Windows.Forms.Button RegisterTrainerButton;
        private System.Windows.Forms.Button viewPTSessionButton;
        private System.Windows.Forms.Label label1;
    }
}
