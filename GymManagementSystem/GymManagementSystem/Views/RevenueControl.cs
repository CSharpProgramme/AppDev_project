using GymManagementSystem.Controllers;
using GymManagementSystem.Localization;
using System;
using System.Data;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GymManagementSystem
{
    /// UserControl that displays gym revenue data.
    /// Staff can filter payments by date range and payment method.
    /// Shows a summary (total, count, average), a bar chart by month,
    /// and a detailed payment grid.
    public partial class RevenueControl : UserControl
    {
        // RevenueController bridges this view and the RevenueRepository
        private readonly RevenueController revenueController = new RevenueController();

        public RevenueControl()
        {
            InitializeComponent();
            InitializeFilters(); // Set default filter values on load

            // defined in the designer instead of auto-creating them from the data source
            paymentDataGridView.AutoGenerateColumns = false;

            LoadData(); // Load payment data immediately on open
        }

        /// Sets default values for the date pickers and method dropdown.
        /// From defaults to the 1st of the current month, To defaults to today.
        private void InitializeFilters()
        {
            // Default range: start of this month to today
            dtpFrom.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpTo.Value = DateTime.Now;

            // Populate the payment method dropdown — "All" means no method filter
            cmbMethod.Items.Clear();
            cmbMethod.Items.AddRange(new object[] { "All", "cash", "credit_card", "debit_card", "online", "bank_transfer" });
            cmbMethod.SelectedIndex = 0; // Default to "All"
        }

        /// Fetches payment data using the current filter values and updates
        /// the grid, the three stat labels, and the bar chart.
        private void LoadData()
        {
            // null method means "All" — the repository skips the method filter
            string method = cmbMethod.SelectedItem?.ToString() == "All" ? null : cmbMethod.SelectedItem?.ToString();

            try
            {
                // Fetch filtered payments and bind them to the grid
                DataTable dt = revenueController.GetPayments(dtpFrom.Value, dtpTo.Value, method);
                paymentDataGridView.DataSource = dt;

                // Calculate stats by looping through the returned rows
                decimal total = 0;
                foreach (DataRow row in dt.Rows)
                    total += row["Amount"] == DBNull.Value ? 0 : Convert.ToDecimal(row["Amount"]);

                int count = dt.Rows.Count;

                // Avoid dividing by zero when there are no payments
                decimal avg = count > 0 ? total / count : 0;

                // Update the three stat labels with formatted currency values
                lblTotalRevenue.Text = total.ToString("C");
                lblTotalPayments.Text = count.ToString();
                lblAvgPayment.Text = avg.ToString("C");

                // Refresh the bar chart with the same filters
                LoadChart(dtpFrom.Value, dtpTo.Value, method);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading revenue data: " + ex.Message);
            }
            SetGridLanguage();
        }

        /// Populates the bar chart with monthly revenue totals.
        /// Each bar represents one month's total revenue within the selected range.
        private void LoadChart(DateTime from, DateTime to, string method)
        {
            // Fetch monthly revenue totals grouped by month
            DataTable chartData = revenueController.GetMonthlyRevenue(from, to, method);

            // Clear previous chart data before adding new points
            chartRevenue.Series["Series1"].Points.Clear();
            chartRevenue.Series["Series1"].ChartType = SeriesChartType.Bar;

            // Show the revenue value as a label on each bar
            chartRevenue.Series["Series1"].IsValueShownAsLabel = true;

            // Add one bar per month — X axis shows the month label, Y axis shows revenue
            foreach (DataRow row in chartData.Rows)
            {
                string month = row["Month"].ToString();
                decimal revenue = Convert.ToDecimal(row["Revenue"]);
                chartRevenue.Series["Series1"].Points.AddXY(month, revenue);
            }
        }

        /// Applies the current filter values and reloads all revenue data.
        private void btnFilter_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        /// Resets all filters back to their defaults and reloads data.
        private void btnReset_Click(object sender, EventArgs e)
        {
            // Reset date range to start of this month → today
            dtpFrom.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpTo.Value = DateTime.Now;

            // Reset method back to "All"
            cmbMethod.SelectedIndex = 0;

            LoadData();
        }
        public void RefreshLanguage()
        {
            SetGridLanguage();
        }

        private void SetGridLanguage()
        {
            string lang = Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName;
            SetColumnHeader("PaymentId", MainPanelLocalization.TranslateFromEnglish("Payment ID", lang));
            SetColumnHeader("MemberName", MainPanelLocalization.TranslateFromEnglish("Member Name", lang));
            SetColumnHeader("Amount", MainPanelLocalization.TranslateFromEnglish("Amount", lang));
            SetColumnHeader("PlanName", MainPanelLocalization.TranslateFromEnglish("Plan Name", lang));
          SetColumnHeader("PaymentDate", MainPanelLocalization.TranslateFromEnglish("Payment Date", lang));
          
          

            SetColumnHeader("Status", MainPanelLocalization.TranslateFromEnglish("Status", lang));
        }

        private void SetColumnHeader(string dataPropertyName, string headerText)
        {
            foreach (DataGridViewColumn column in paymentDataGridView.Columns)
            {
                if (string.Equals(column.DataPropertyName, dataPropertyName, StringComparison.OrdinalIgnoreCase))
                {
                    column.HeaderText = headerText;
                    break;
                }
            }
        }
    }
}
