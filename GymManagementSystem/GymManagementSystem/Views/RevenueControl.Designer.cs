namespace GymManagementSystem
{
    partial class RevenueControl
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.label1 = new System.Windows.Forms.Label();
            this.fromLabel = new System.Windows.Forms.Label();
            this.toLabel = new System.Windows.Forms.Label();
            this.methodLabel = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.cmbMethod = new System.Windows.Forms.ComboBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.pnlTotalRevenue = new System.Windows.Forms.Panel();
            this.lblTotalRevenue = new System.Windows.Forms.Label();
            this.lblTotalRevenueTitle = new System.Windows.Forms.Label();
            this.lblTotalPaymentsTitle = new System.Windows.Forms.Label();
            this.lblTotalPayments = new System.Windows.Forms.Label();
            this.lblAvgPaymentTitle = new System.Windows.Forms.Label();
            this.lblAvgPayment = new System.Windows.Forms.Label();
            this.pnlTotalPayments = new System.Windows.Forms.Panel();
            this.pnlAvgPayment = new System.Windows.Forms.Panel();
            this.chartRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.paymentDataGridView = new System.Windows.Forms.DataGridView();
            this.colPaymentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMemberName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlanName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPaymentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gymManagementDBDataSet = new GymManagementSystem.GymManagementDBDataSet();
            this.paymentTableAdapter = new GymManagementSystem.GymManagementDBDataSetTableAdapters.PaymentTableAdapter();
            this.tableAdapterManager = new GymManagementSystem.GymManagementDBDataSetTableAdapters.TableAdapterManager();
            this.pnlTotalRevenue.SuspendLayout();
            this.pnlTotalPayments.SuspendLayout();
            this.pnlAvgPayment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymManagementDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 32);
            this.label1.TabIndex = 17;
            this.label1.Text = "Revenue";
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromLabel.Location = new System.Drawing.Point(48, 106);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(76, 29);
            this.fromLabel.TabIndex = 18;
            this.fromLabel.Text = "From:";
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toLabel.Location = new System.Drawing.Point(352, 108);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(49, 29);
            this.toLabel.TabIndex = 19;
            this.toLabel.Text = "To:";
            // 
            // methodLabel
            // 
            this.methodLabel.AutoSize = true;
            this.methodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.methodLabel.Location = new System.Drawing.Point(647, 105);
            this.methodLabel.Name = "methodLabel";
            this.methodLabel.Size = new System.Drawing.Size(100, 29);
            this.methodLabel.TabIndex = 20;
            this.methodLabel.Text = "Method:";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(130, 105);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(148, 32);
            this.dtpFrom.TabIndex = 21;
            // 
            // dtpTo
            // 
            this.dtpTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(407, 108);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(148, 32);
            this.dtpTo.TabIndex = 22;
            // 
            // cmbMethod
            // 
            this.cmbMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMethod.FormattingEnabled = true;
            this.cmbMethod.Location = new System.Drawing.Point(753, 103);
            this.cmbMethod.Name = "cmbMethod";
            this.cmbMethod.Size = new System.Drawing.Size(147, 34);
            this.cmbMethod.TabIndex = 23;
            // 
            // btnFilter
            // 
            this.btnFilter.AutoSize = true;
            this.btnFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.Location = new System.Drawing.Point(53, 170);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(78, 39);
            this.btnFilter.TabIndex = 24;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnReset
            // 
            this.btnReset.AutoSize = true;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(165, 170);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(86, 39);
            this.btnReset.TabIndex = 25;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // pnlTotalRevenue
            // 
            this.pnlTotalRevenue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTotalRevenue.Controls.Add(this.lblTotalRevenue);
            this.pnlTotalRevenue.Controls.Add(this.lblTotalRevenueTitle);
            this.pnlTotalRevenue.Location = new System.Drawing.Point(53, 249);
            this.pnlTotalRevenue.Name = "pnlTotalRevenue";
            this.pnlTotalRevenue.Size = new System.Drawing.Size(178, 103);
            this.pnlTotalRevenue.TabIndex = 26;
            // 
            // lblTotalRevenue
            // 
            this.lblTotalRevenue.AutoSize = true;
            this.lblTotalRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRevenue.Location = new System.Drawing.Point(25, 58);
            this.lblTotalRevenue.Name = "lblTotalRevenue";
            this.lblTotalRevenue.Size = new System.Drawing.Size(71, 29);
            this.lblTotalRevenue.TabIndex = 1;
            this.lblTotalRevenue.Text = "$0.00";
            // 
            // lblTotalRevenueTitle
            // 
            this.lblTotalRevenueTitle.AutoSize = true;
            this.lblTotalRevenueTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRevenueTitle.Location = new System.Drawing.Point(25, 15);
            this.lblTotalRevenueTitle.Name = "lblTotalRevenueTitle";
            this.lblTotalRevenueTitle.Size = new System.Drawing.Size(128, 22);
            this.lblTotalRevenueTitle.TabIndex = 0;
            this.lblTotalRevenueTitle.Text = "Total Revenue";
            // 
            // lblTotalPaymentsTitle
            // 
            this.lblTotalPaymentsTitle.AutoSize = true;
            this.lblTotalPaymentsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPaymentsTitle.Location = new System.Drawing.Point(22, 19);
            this.lblTotalPaymentsTitle.Name = "lblTotalPaymentsTitle";
            this.lblTotalPaymentsTitle.Size = new System.Drawing.Size(135, 22);
            this.lblTotalPaymentsTitle.TabIndex = 2;
            this.lblTotalPaymentsTitle.Text = "Total Payments";
            // 
            // lblTotalPayments
            // 
            this.lblTotalPayments.AutoSize = true;
            this.lblTotalPayments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPayments.Location = new System.Drawing.Point(22, 54);
            this.lblTotalPayments.Name = "lblTotalPayments";
            this.lblTotalPayments.Size = new System.Drawing.Size(26, 29);
            this.lblTotalPayments.TabIndex = 3;
            this.lblTotalPayments.Text = "0";
            // 
            // lblAvgPaymentTitle
            // 
            this.lblAvgPaymentTitle.AutoSize = true;
            this.lblAvgPaymentTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvgPaymentTitle.Location = new System.Drawing.Point(13, 18);
            this.lblAvgPaymentTitle.Name = "lblAvgPaymentTitle";
            this.lblAvgPaymentTitle.Size = new System.Drawing.Size(152, 22);
            this.lblAvgPaymentTitle.TabIndex = 4;
            this.lblAvgPaymentTitle.Text = "Average Payment";
            // 
            // lblAvgPayment
            // 
            this.lblAvgPayment.AutoSize = true;
            this.lblAvgPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvgPayment.Location = new System.Drawing.Point(13, 54);
            this.lblAvgPayment.Name = "lblAvgPayment";
            this.lblAvgPayment.Size = new System.Drawing.Size(71, 29);
            this.lblAvgPayment.TabIndex = 5;
            this.lblAvgPayment.Text = "$0.00";
            // 
            // pnlTotalPayments
            // 
            this.pnlTotalPayments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTotalPayments.Controls.Add(this.lblTotalPayments);
            this.pnlTotalPayments.Controls.Add(this.lblTotalPaymentsTitle);
            this.pnlTotalPayments.Location = new System.Drawing.Point(276, 249);
            this.pnlTotalPayments.Name = "pnlTotalPayments";
            this.pnlTotalPayments.Size = new System.Drawing.Size(178, 103);
            this.pnlTotalPayments.TabIndex = 27;
            // 
            // pnlAvgPayment
            // 
            this.pnlAvgPayment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAvgPayment.Controls.Add(this.lblAvgPayment);
            this.pnlAvgPayment.Controls.Add(this.lblAvgPaymentTitle);
            this.pnlAvgPayment.Location = new System.Drawing.Point(506, 252);
            this.pnlAvgPayment.Name = "pnlAvgPayment";
            this.pnlAvgPayment.Size = new System.Drawing.Size(178, 100);
            this.pnlAvgPayment.TabIndex = 28;
            // 
            // chartRevenue
            // 
            chartArea1.Name = "ChartArea1";
            this.chartRevenue.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartRevenue.Legends.Add(legend1);
            this.chartRevenue.Location = new System.Drawing.Point(53, 385);
            this.chartRevenue.Name = "chartRevenue";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartRevenue.Series.Add(series1);
            this.chartRevenue.Size = new System.Drawing.Size(864, 317);
            this.chartRevenue.TabIndex = 29;
            this.chartRevenue.Text = "Monthly Revenue";
            title1.Name = "Title1";
            title1.Text = "Monthly Revenue";
            this.chartRevenue.Titles.Add(title1);
            // 
            // paymentDataGridView
            // 
            this.paymentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paymentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPaymentId,
            this.colMemberName,
            this.colPlanName,
            this.colAmount,
            this.colPaymentDate,
            this.colMethod,
            this.colStatus});
            this.paymentDataGridView.Location = new System.Drawing.Point(53, 747);
            this.paymentDataGridView.MultiSelect = false;
            this.paymentDataGridView.Name = "paymentDataGridView";
            this.paymentDataGridView.ReadOnly = true;
            this.paymentDataGridView.RowHeadersVisible = false;
            this.paymentDataGridView.RowHeadersWidth = 62;
            this.paymentDataGridView.RowTemplate.Height = 28;
            this.paymentDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.paymentDataGridView.Size = new System.Drawing.Size(1258, 218);
            this.paymentDataGridView.TabIndex = 31;
            // 
            // colPaymentId
            // 
            this.colPaymentId.DataPropertyName = "PaymentId";
            this.colPaymentId.HeaderText = "Payment ID";
            this.colPaymentId.MinimumWidth = 8;
            this.colPaymentId.Name = "colPaymentId";
            this.colPaymentId.ReadOnly = true;
            this.colPaymentId.Width = 90;
            // 
            // colMemberName
            // 
            this.colMemberName.DataPropertyName = "MemberName";
            this.colMemberName.HeaderText = "Member";
            this.colMemberName.MinimumWidth = 8;
            this.colMemberName.Name = "colMemberName";
            this.colMemberName.ReadOnly = true;
            this.colMemberName.Width = 180;
            // 
            // colPlanName
            // 
            this.colPlanName.DataPropertyName = "PlanName";
            this.colPlanName.HeaderText = "Plan";
            this.colPlanName.MinimumWidth = 8;
            this.colPlanName.Name = "colPlanName";
            this.colPlanName.ReadOnly = true;
            this.colPlanName.Width = 130;
            // 
            // colAmount
            // 
            this.colAmount.DataPropertyName = "Amount";
            this.colAmount.HeaderText = "Amount";
            this.colAmount.MinimumWidth = 8;
            this.colAmount.Name = "colAmount";
            this.colAmount.ReadOnly = true;
            // 
            // colPaymentDate
            // 
            this.colPaymentDate.DataPropertyName = "PaymentDate";
            this.colPaymentDate.HeaderText = "Date";
            this.colPaymentDate.MinimumWidth = 8;
            this.colPaymentDate.Name = "colPaymentDate";
            this.colPaymentDate.ReadOnly = true;
            this.colPaymentDate.Width = 130;
            // 
            // colMethod
            // 
            this.colMethod.DataPropertyName = "Method";
            this.colMethod.HeaderText = "Method";
            this.colMethod.MinimumWidth = 8;
            this.colMethod.Name = "colMethod";
            this.colMethod.ReadOnly = true;
            this.colMethod.Width = 120;
            // 
            // colStatus
            // 
            this.colStatus.DataPropertyName = "Status";
            this.colStatus.HeaderText = "Status";
            this.colStatus.MinimumWidth = 8;
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            // 
            // paymentBindingSource
            // 
            this.paymentBindingSource.DataMember = "Payment";
            this.paymentBindingSource.DataSource = this.gymManagementDBDataSet;
            // 
            // gymManagementDBDataSet
            // 
            this.gymManagementDBDataSet.DataSetName = "GymManagementDBDataSet";
            this.gymManagementDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paymentTableAdapter
            // 
            this.paymentTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.PaymentTableAdapter = this.paymentTableAdapter;
            this.tableAdapterManager.PT_SessionTableAdapter = null;
            this.tableAdapterManager.StaffTableAdapter = null;
            this.tableAdapterManager.SubscriptionTableAdapter = null;
            this.tableAdapterManager.TrainerTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GymManagementSystem.GymManagementDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // RevenueControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.paymentDataGridView);
            this.Controls.Add(this.chartRevenue);
            this.Controls.Add(this.pnlAvgPayment);
            this.Controls.Add(this.pnlTotalPayments);
            this.Controls.Add(this.pnlTotalRevenue);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.cmbMethod);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.methodLabel);
            this.Controls.Add(this.toLabel);
            this.Controls.Add(this.fromLabel);
            this.Controls.Add(this.label1);
            this.Name = "RevenueControl";
            this.Size = new System.Drawing.Size(1340, 985);
            this.pnlTotalRevenue.ResumeLayout(false);
            this.pnlTotalRevenue.PerformLayout();
            this.pnlTotalPayments.ResumeLayout(false);
            this.pnlTotalPayments.PerformLayout();
            this.pnlAvgPayment.ResumeLayout(false);
            this.pnlAvgPayment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymManagementDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.Label methodLabel;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.ComboBox cmbMethod;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Panel pnlTotalRevenue;
        private System.Windows.Forms.Label lblAvgPayment;
        private System.Windows.Forms.Label lblAvgPaymentTitle;
        private System.Windows.Forms.Label lblTotalRevenue;
        private System.Windows.Forms.Label lblTotalRevenueTitle;
        private System.Windows.Forms.Label lblTotalPaymentsTitle;
        private System.Windows.Forms.Label lblTotalPayments;
        private System.Windows.Forms.Panel pnlTotalPayments;
        private System.Windows.Forms.Panel pnlAvgPayment;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRevenue;
        private GymManagementDBDataSet gymManagementDBDataSet;
        private System.Windows.Forms.BindingSource paymentBindingSource;
        private GymManagementDBDataSetTableAdapters.PaymentTableAdapter paymentTableAdapter;
        private GymManagementDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView paymentDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaymentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMemberName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlanName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaymentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
    }
}
