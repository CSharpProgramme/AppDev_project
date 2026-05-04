using System;
using System.Data.SqlClient;
using GymManagementSystem.Data;

namespace GymManagementSystem.Repositories
{
    public class ActivationRepository
    {
        public void ReactivateMember(int memberId, int planId, string paymentMethod, DateTime startDate, int processedBy)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                SqlTransaction tx = conn.BeginTransaction();
                try
                {
                    // 1. Get plan price and duration
                    decimal price = 0;
                    int durationDays = 30;
                    using (SqlCommand cmd = new SqlCommand(
                        "SELECT price, duration_days FROM MEMBERSHIP_PLAN WHERE plan_id = @planId", conn, tx))
                    {
                        cmd.Parameters.AddWithValue("@planId", planId);
                        using (SqlDataReader r = cmd.ExecuteReader())
                        {
                            if (r.Read())
                            {
                                price = (decimal)r["price"];
                                durationDays = (int)r["duration_days"];
                            }
                        }
                    }

                    DateTime endDate = startDate.AddDays(durationDays);

                    // 2. Insert subscription, get its ID back
                    int subscriptionId;
                    using (SqlCommand cmd = new SqlCommand(@"
                        INSERT INTO SUBSCRIPTION (member_id, plan_id, start_date, end_date, status)
                        OUTPUT INSERTED.subscription_id
                        VALUES (@memberId, @planId, @startDate, @endDate, 'active')", conn, tx))
                    {
                        cmd.Parameters.AddWithValue("@memberId", memberId);
                        cmd.Parameters.AddWithValue("@planId", planId);
                        cmd.Parameters.AddWithValue("@startDate", startDate.Date);
                        cmd.Parameters.AddWithValue("@endDate", endDate.Date);
                        subscriptionId = (int)cmd.ExecuteScalar();
                    }

                    // Verify processed_by staff exists; fall back to first staff if not
                    using (SqlCommand cmd = new SqlCommand(
                        "SELECT COUNT(*) FROM STAFF WHERE staff_id = @id", conn, tx))
                    {
                        cmd.Parameters.AddWithValue("@id", processedBy);
                        if ((int)cmd.ExecuteScalar() == 0)
                        {
                            SqlCommand getFirst = new SqlCommand(
                                "SELECT TOP 1 staff_id FROM STAFF ORDER BY staff_id", conn, tx);
                            object result = getFirst.ExecuteScalar();
                            if (result == null)
                                throw new Exception("No staff found in the database. Please seed staff data first.");
                            processedBy = (int)result;
                        }
                    }

                    // 3. Insert payment for this subscription
                    using (SqlCommand cmd = new SqlCommand(@"
                        INSERT INTO PAYMENT (subscription_id, processed_by, amount, payment_date, method, status)
                        VALUES (@subId, @processedBy, @amount, @payDate, @method, 'completed')", conn, tx))
                    {
                        cmd.Parameters.AddWithValue("@subId", subscriptionId);
                        cmd.Parameters.AddWithValue("@processedBy", processedBy);
                        cmd.Parameters.AddWithValue("@amount", price);
                        cmd.Parameters.AddWithValue("@payDate", startDate.Date);
                        cmd.Parameters.AddWithValue("@method", paymentMethod);
                        cmd.ExecuteNonQuery();
                    }

                    // 4. Set member status to active
                    using (SqlCommand cmd = new SqlCommand(
                        "UPDATE MEMBER SET status = 'active' WHERE member_id = @memberId", conn, tx))
                    {
                        cmd.Parameters.AddWithValue("@memberId", memberId);
                        cmd.ExecuteNonQuery();
                    }

                    tx.Commit();
                }
                catch
                {
                    tx.Rollback();
                    throw;
                }
            }
        }
    }
}
