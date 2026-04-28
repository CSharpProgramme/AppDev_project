namespace GymManagementSystem
{
    partial class MembershipPlanControl
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
            this.RegisterPlanButton = new System.Windows.Forms.Button();
            this.membershipPlanDataGridView = new System.Windows.Forms.DataGridView();
            this.mEMBERSHIPPLANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gymManagementDBDataSet2 = new GymManagementSystem.GymManagementDBDataSet2();
            this.deletePlanButton = new System.Windows.Forms.Button();
            this.editPlanButton = new System.Windows.Forms.Button();
            this.mEMBERSHIP_PLANTableAdapter = new GymManagementSystem.GymManagementDBDataSet2TableAdapters.MEMBERSHIP_PLANTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.membershipPlanDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEMBERSHIPPLANBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymManagementDBDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // RegisterPlanButton
            // 
            this.RegisterPlanButton.Location = new System.Drawing.Point(304, 34);
            this.RegisterPlanButton.Margin = new System.Windows.Forms.Padding(2);
            this.RegisterPlanButton.Name = "RegisterPlanButton";
            this.RegisterPlanButton.Size = new System.Drawing.Size(115, 40);
            this.RegisterPlanButton.TabIndex = 4;
            this.RegisterPlanButton.Text = "Register Plan";
            this.RegisterPlanButton.UseVisualStyleBackColor = true;
            // 
            // membershipPlanDataGridView
            // 
            this.membershipPlanDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.membershipPlanDataGridView.Location = new System.Drawing.Point(21, 88);
            this.membershipPlanDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.membershipPlanDataGridView.Name = "membershipPlanDataGridView";
            this.membershipPlanDataGridView.RowHeadersVisible = false;
            this.membershipPlanDataGridView.RowHeadersWidth = 62;
            this.membershipPlanDataGridView.RowTemplate.Height = 28;
            this.membershipPlanDataGridView.Size = new System.Drawing.Size(707, 402);
            this.membershipPlanDataGridView.TabIndex = 3;
            // 
            // mEMBERSHIPPLANBindingSource
            // 
            this.mEMBERSHIPPLANBindingSource.DataMember = "MEMBERSHIP_PLAN";
            this.mEMBERSHIPPLANBindingSource.DataSource = this.gymManagementDBDataSet2;
            // 
            // gymManagementDBDataSet2
            // 
            this.gymManagementDBDataSet2.DataSetName = "GymManagementDBDataSet2";
            this.gymManagementDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // deletePlanButton
            // 
            this.deletePlanButton.Location = new System.Drawing.Point(423, 34);
            this.deletePlanButton.Margin = new System.Windows.Forms.Padding(2);
            this.deletePlanButton.Name = "deletePlanButton";
            this.deletePlanButton.Size = new System.Drawing.Size(115, 40);
            this.deletePlanButton.TabIndex = 5;
            this.deletePlanButton.Text = "Delete Plan";
            this.deletePlanButton.UseVisualStyleBackColor = true;
            // 
            // editPlanButton
            // 
            this.editPlanButton.Location = new System.Drawing.Point(542, 34);
            this.editPlanButton.Margin = new System.Windows.Forms.Padding(2);
            this.editPlanButton.Name = "editPlanButton";
            this.editPlanButton.Size = new System.Drawing.Size(115, 40);
            this.editPlanButton.TabIndex = 6;
            this.editPlanButton.Text = "Edit Plan";
            this.editPlanButton.UseVisualStyleBackColor = true;
            // 
            // mEMBERSHIP_PLANTableAdapter
            // 
            this.mEMBERSHIP_PLANTableAdapter.ClearBeforeFill = true;
            // 
            // MembershipPlanControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.editPlanButton);
            this.Controls.Add(this.deletePlanButton);
            this.Controls.Add(this.RegisterPlanButton);
            this.Controls.Add(this.membershipPlanDataGridView);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MembershipPlanControl";
            this.Size = new System.Drawing.Size(751, 508);
            ((System.ComponentModel.ISupportInitialize)(this.membershipPlanDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEMBERSHIPPLANBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymManagementDBDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RegisterPlanButton;
        private System.Windows.Forms.DataGridView membershipPlanDataGridView;
        private System.Windows.Forms.Button deletePlanButton;
        private System.Windows.Forms.Button editPlanButton;
        private System.Windows.Forms.BindingSource mEMBERSHIPPLANBindingSource;
        private GymManagementDBDataSet2 gymManagementDBDataSet2;
        private GymManagementDBDataSet2TableAdapters.MEMBERSHIP_PLANTableAdapter mEMBERSHIP_PLANTableAdapter;
    }
}
