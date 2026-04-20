namespace GymManagementSystem
{
    partial class MemberControl
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
            this.gymManagementDBDataSet = new GymManagementSystem.GymManagementDBDataSet();
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.memberTableAdapter = new GymManagementSystem.GymManagementDBDataSetTableAdapters.MemberTableAdapter();
            this.tableAdapterManager = new GymManagementSystem.GymManagementDBDataSetTableAdapters.TableAdapterManager();
            this.member_ProgressTableAdapter = new GymManagementSystem.GymManagementDBDataSetTableAdapters.Member_ProgressTableAdapter();
            this.subscriptionTableAdapter = new GymManagementSystem.GymManagementDBDataSetTableAdapters.SubscriptionTableAdapter();
            this.memberDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emergency_contact_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emergency_contact_phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subscriptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.member_ProgressBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.registerMemberBtn = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.searchMemTextBox = new System.Windows.Forms.TextBox();
            this.searchMembtn = new System.Windows.Forms.Button();
            this.memberListLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gymManagementDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subscriptionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.member_ProgressBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gymManagementDBDataSet
            // 
            this.gymManagementDBDataSet.DataSetName = "GymManagementDBDataSet";
            this.gymManagementDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // memberBindingSource
            // 
            this.memberBindingSource.DataMember = "Member";
            this.memberBindingSource.DataSource = this.gymManagementDBDataSet;
            // 
            // memberTableAdapter
            // 
            this.memberTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AttendanceTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EquipmentTableAdapter = null;
            this.tableAdapterManager.LockerTableAdapter = null;
            this.tableAdapterManager.Member_ProgressTableAdapter = this.member_ProgressTableAdapter;
            this.tableAdapterManager.Membership_PlanTableAdapter = null;
            this.tableAdapterManager.MemberTableAdapter = this.memberTableAdapter;
            this.tableAdapterManager.PaymentTableAdapter = null;
            this.tableAdapterManager.PT_SessionTableAdapter = null;
            this.tableAdapterManager.StaffTableAdapter = null;
            this.tableAdapterManager.SubscriptionTableAdapter = this.subscriptionTableAdapter;
            this.tableAdapterManager.TrainerTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GymManagementSystem.GymManagementDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // member_ProgressTableAdapter
            // 
            this.member_ProgressTableAdapter.ClearBeforeFill = true;
            // 
            // subscriptionTableAdapter
            // 
            this.subscriptionTableAdapter.ClearBeforeFill = true;
            // 
            // memberDataGridView
            // 
            this.memberDataGridView.AllowUserToAddRows = false;
            this.memberDataGridView.AllowUserToDeleteRows = false;
            this.memberDataGridView.AllowUserToResizeColumns = false;
            this.memberDataGridView.AllowUserToResizeRows = false;
            this.memberDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.memberDataGridView.AutoGenerateColumns = false;
            this.memberDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.memberDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.memberDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.memberDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.memberDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.emergency_contact_name,
            this.emergency_contact_phone,
            this.dataGridViewTextBoxColumn10});
            this.memberDataGridView.DataSource = this.memberBindingSource;
            this.memberDataGridView.Location = new System.Drawing.Point(76, 245);
            this.memberDataGridView.MultiSelect = false;
            this.memberDataGridView.Name = "memberDataGridView";
            this.memberDataGridView.ReadOnly = true;
            this.memberDataGridView.RowHeadersVisible = false;
            this.memberDataGridView.RowHeadersWidth = 62;
            this.memberDataGridView.RowTemplate.Height = 28;
            this.memberDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.memberDataGridView.Size = new System.Drawing.Size(1249, 587);
            this.memberDataGridView.TabIndex = 1;
            this.memberDataGridView.SelectionChanged += new System.EventHandler(this.memberDataGridView_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "member_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "member_id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "first_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "first_name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "last_name";
            this.dataGridViewTextBoxColumn3.HeaderText = "last_name";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "email";
            this.dataGridViewTextBoxColumn4.HeaderText = "email";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 82;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "phone";
            this.dataGridViewTextBoxColumn5.HeaderText = "phone";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "date_of_birth";
            this.dataGridViewTextBoxColumn6.HeaderText = "date_of_birth";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "join_date";
            this.dataGridViewTextBoxColumn7.HeaderText = "join_date";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // emergency_contact_name
            // 
            this.emergency_contact_name.DataPropertyName = "emergency_contact_name";
            this.emergency_contact_name.HeaderText = "emergency_contact_name";
            this.emergency_contact_name.MinimumWidth = 8;
            this.emergency_contact_name.Name = "emergency_contact_name";
            this.emergency_contact_name.ReadOnly = true;
            this.emergency_contact_name.Width = 234;
            // 
            // emergency_contact_phone
            // 
            this.emergency_contact_phone.DataPropertyName = "emergency_contact_phone";
            this.emergency_contact_phone.HeaderText = "emergency_contact_phone";
            this.emergency_contact_phone.MinimumWidth = 8;
            this.emergency_contact_phone.Name = "emergency_contact_phone";
            this.emergency_contact_phone.ReadOnly = true;
            this.emergency_contact_phone.Width = 239;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn10.DataPropertyName = "status";
            this.dataGridViewTextBoxColumn10.HeaderText = "status";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // subscriptionBindingSource
            // 
            this.subscriptionBindingSource.DataMember = "Subscription";
            this.subscriptionBindingSource.DataSource = this.gymManagementDBDataSet;
            // 
            // member_ProgressBindingSource
            // 
            this.member_ProgressBindingSource.DataMember = "Member_Progress";
            this.member_ProgressBindingSource.DataSource = this.gymManagementDBDataSet;
            // 
            // registerMemberBtn
            // 
            this.registerMemberBtn.AutoSize = true;
            this.registerMemberBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerMemberBtn.Location = new System.Drawing.Point(420, 120);
            this.registerMemberBtn.Name = "registerMemberBtn";
            this.registerMemberBtn.Size = new System.Drawing.Size(186, 35);
            this.registerMemberBtn.TabIndex = 2;
            this.registerMemberBtn.Text = "Register a Member";
            this.registerMemberBtn.UseVisualStyleBackColor = true;
            this.registerMemberBtn.Click += new System.EventHandler(this.btnRegisterMember_Click);
            // 
            // editButton
            // 
            this.editButton.AutoSize = true;
            this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.Location = new System.Drawing.Point(658, 120);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(187, 35);
            this.editButton.TabIndex = 3;
            this.editButton.Text = "Edit a Member";
            this.editButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // searchMemTextBox
            // 
            this.searchMemTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchMemTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchMemTextBox.Location = new System.Drawing.Point(76, 125);
            this.searchMemTextBox.Name = "searchMemTextBox";
            this.searchMemTextBox.Size = new System.Drawing.Size(299, 28);
            this.searchMemTextBox.TabIndex = 4;
            this.searchMemTextBox.Tag = "";
            this.searchMemTextBox.Click += new System.EventHandler(this.clickTextBox);
            this.searchMemTextBox.Leave += new System.EventHandler(this.clickAwayTextBox);
            // 
            // searchMembtn
            // 
            this.searchMembtn.AutoSize = true;
            this.searchMembtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchMembtn.Location = new System.Drawing.Point(76, 168);
            this.searchMembtn.Name = "searchMembtn";
            this.searchMembtn.Size = new System.Drawing.Size(154, 35);
            this.searchMembtn.TabIndex = 5;
            this.searchMembtn.Text = "Search";
            this.searchMembtn.UseVisualStyleBackColor = true;
            this.searchMembtn.Click += new System.EventHandler(this.searchMembtn_Click);
            // 
            // memberListLabel
            // 
            this.memberListLabel.AutoSize = true;
            this.memberListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberListLabel.Location = new System.Drawing.Point(70, 56);
            this.memberListLabel.Name = "memberListLabel";
            this.memberListLabel.Size = new System.Drawing.Size(169, 32);
            this.memberListLabel.TabIndex = 6;
            this.memberListLabel.Text = "Member List";
            // 
            // MemberControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.memberListLabel);
            this.Controls.Add(this.searchMembtn);
            this.Controls.Add(this.searchMemTextBox);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.registerMemberBtn);
            this.Controls.Add(this.memberDataGridView);
            this.Name = "MemberControl";
            this.Size = new System.Drawing.Size(1400, 879);
            ((System.ComponentModel.ISupportInitialize)(this.gymManagementDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subscriptionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.member_ProgressBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GymManagementDBDataSet gymManagementDBDataSet;
        private System.Windows.Forms.BindingSource memberBindingSource;
        private GymManagementDBDataSetTableAdapters.MemberTableAdapter memberTableAdapter;
        private GymManagementDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView memberDataGridView;
        private GymManagementDBDataSetTableAdapters.Member_ProgressTableAdapter member_ProgressTableAdapter;
        private GymManagementDBDataSetTableAdapters.SubscriptionTableAdapter subscriptionTableAdapter;
        private System.Windows.Forms.BindingSource subscriptionBindingSource;
        private System.Windows.Forms.BindingSource member_ProgressBindingSource;
        private System.Windows.Forms.Button registerMemberBtn;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.TextBox searchMemTextBox;
        private System.Windows.Forms.Button searchMembtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn emergency_contact_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn emergency_contact_phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.Label memberListLabel;
    }
}
