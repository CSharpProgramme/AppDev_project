using System;
using System.Data;
using System.Data.SqlClient;
using GymManagementSystem.Data;

namespace GymManagementSystem.Repositories
{
    /// Handles all database operations related to revenue and payments.
    /// This is the only class that writes SQL for revenue data.
    /// The controller calls these methods — this class never talks to the UI directly.
    public class RevenueRepository
    {
        /// Returns a DataTable of payments within a date range, optionally filtered by method.
        /// JOINs PAYMENT → SUBSCRIPTION → MEMBER → MEMBERSHIP_PLAN to show readable names
        /// instead of raw foreign key IDs.
        public DataTable GetPayments(DateTime from, DateTime to, string method)
        {
            // Build the base query with JOINs to get member name and plan name
            string query = @"
                SELECT
                    p.payment_id       AS PaymentId,
                    m.first_name + ' ' + m.last_name AS MemberName,
                    mp.name            AS PlanName,
                    p.amount           AS Amount,
                    p.payment_date     AS PaymentDate,
                    p.method           AS Method,
                    p.status           AS Status
                FROM PAYMENT p
                INNER JOIN SUBSCRIPTION s     ON p.subscription_id = s.subscription_id
                INNER JOIN MEMBER m           ON s.member_id = m.member_id
                INNER JOIN MEMBERSHIP_PLAN mp ON s.plan_id = mp.plan_id
                WHERE p.payment_date >= @from
                  AND p.payment_date <  @to";

            // Append method filter only if a specific method was selected (not "All")
            if (!string.IsNullOrEmpty(method))
                query += " AND p.method = @method";

            // Show most recent payments first
            query += " ORDER BY p.payment_date DESC";

            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // @to uses AddDays(1) so the selected end date is fully included
                    cmd.Parameters.AddWithValue("@from", from.Date);
                    cmd.Parameters.AddWithValue("@to", to.Date.AddDays(1));
                    if (!string.IsNullOrEmpty(method))
                        cmd.Parameters.AddWithValue("@method", method);

                    conn.Open();
                    // SqlDataAdapter fills the DataTable with all matching rows at once
                    new SqlDataAdapter(cmd).Fill(dt);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error fetching payments: " + ex.Message);
            }
            return dt;
        }

        /// Returns the total revenue for the current calendar month.
        /// ISNULL ensures we return 0 instead of NULL when there are no payments.
        /// Used by the dashboard stat card.
        public decimal GetRevenueThisMonth()
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                using (SqlCommand cmd = new SqlCommand(@"
                    SELECT ISNULL(SUM(amount), 0) FROM PAYMENT
                    WHERE status = 'completed'
                      AND MONTH(payment_date) = MONTH(GETDATE())
                      AND YEAR(payment_date)  = YEAR(GETDATE())", conn))
                {
                    conn.Open();
                    // ExecuteScalar returns a single value — the total sum
                    return (decimal)cmd.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error fetching monthly revenue: " + ex.Message);
            }
        }

        /// Returns a DataTable of total revenue grouped by month within the date range.
        /// FORMAT gives a readable month label (e.g. "Jan 2026").
        /// Year and MonthNum are included so we can ORDER BY chronologically.
        /// Used to populate the bar chart.
        public DataTable GetMonthlyRevenue(DateTime from, DateTime to, string method)
        {
            string query = @"
                SELECT
                    FORMAT(p.payment_date, 'MMM yyyy') AS Month,
                    YEAR(p.payment_date)               AS Year,
                    MONTH(p.payment_date)              AS MonthNum,
                    SUM(p.amount)                      AS Revenue
                FROM PAYMENT p
                WHERE p.payment_date >= @from
                  AND p.payment_date <  @to";

            // Append method filter only if a specific method was selected
            if (!string.IsNullOrEmpty(method))
                query += " AND p.method = @method";

            // GROUP BY month so each row represents one month's total revenue
            // ORDER BY Year then MonthNum to keep the chart in chronological order
            query += @" GROUP BY FORMAT(p.payment_date, 'MMM yyyy'),
                                 YEAR(p.payment_date),
                                 MONTH(p.payment_date)
                        ORDER BY Year, MonthNum";

            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@from", from.Date);
                    cmd.Parameters.AddWithValue("@to", to.Date.AddDays(1));
                    if (!string.IsNullOrEmpty(method))
                        cmd.Parameters.AddWithValue("@method", method);

                    conn.Open();
                    new SqlDataAdapter(cmd).Fill(dt);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error fetching monthly revenue: " + ex.Message);
            }
            return dt;
        }
    }
}
