using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using GymManagementSystem.Data;
using GymManagementSystem.Models;

namespace GymManagementSystem.Repositories
{
    /*
     * Handles all database operations for the MEMBERSHIP_PLAN table. 
     * This is the only class that writes SQL for membership plans.
     * The controller calls these methods instead of querying the database directly.
     */
    public class MembershipPlanRepository
    {
        // read
        public List<MembershipPlan> GetAllPlans()
        {
            List<MembershipPlan> plans = new List<MembershipPlan>();
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT * FROM MEMBERSHIP_PLAN";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    // Execute the query and get a reader to go through results row by row
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        MembershipPlan plan = new MembershipPlan
                        {
                            PlanId = (int)reader["plan_id"],
                            Name = reader["name"].ToString(),
                            // description can be NULL in the database
                            Description = reader["description"] == DBNull.Value ? null : reader["description"].ToString(),
                            Price = (decimal)reader["price"],
                            DurationDays = (int)reader["duration_days"]
                        };
                        plans.Add(plan);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error fetching membership plans: " + ex.Message);
            }
            return plans;
        }

        public MembershipPlan GetById(int id)
        {
            MembershipPlan plan = null;
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT * FROM Membership_Plan WHERE plan_id = @id";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    // Replace @id with the actual value to prevent SQL injection
                    cmd.Parameters.AddWithValue("@id", id);

                    // Execute and read - we use "if" since we only expect one result
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        plan = new MembershipPlan
                        {
                            PlanId = (int)reader["plan_id"],
                            Name = reader["name"].ToString(),
                            Description = reader["description"] == DBNull.Value ? null : reader["description"].ToString(),
                            Price = (decimal)reader["price"],
                            DurationDays = (int)reader["duration_days"]
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error fetching membership plan: " + ex.Message);
            }
            return plan;
        }

        // create
        public void AddPlan(MembershipPlan plan)
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = @"INSERT INTO Membership_Plan (name, description, price, duration_days) 
                                     VALUES (@name, @description, @price, @durationDays)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", plan.Name);
                    // Cast to object so ?? can compare string and DBNull which are different types
                    cmd.Parameters.AddWithValue("@description", (object)plan.Description ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@price", plan.Price);
                    cmd.Parameters.AddWithValue("@durationDays", plan.DurationDays);

                    // ExecuteNonQuery is used for INSERT, UPDATE, DELETE since they dont return rows
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error adding membership plan: " + ex.Message);
            }
        }

        // Updates
        public void UpdatePlan(MembershipPlan plan)
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = @"UPDATE Membership_Plan SET 
                                     name = @name, 
                                     description = @description, 
                                     price = @price, 
                                     duration_days = @durationDays 
                                     WHERE plan_id = @id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", plan.Name);
                    // Cast to object so ?? can compare string and DBNull which are different types
                    cmd.Parameters.AddWithValue("@description", (object)plan.Description ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@price", plan.Price);
                    cmd.Parameters.AddWithValue("@durationDays", plan.DurationDays);
                    cmd.Parameters.AddWithValue("@id", plan.PlanId);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating membership plan: " + ex.Message);
            }
        }

        // Delete
        public void DeletePlan(int id)
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "DELETE FROM Membership_Plan WHERE plan_id = @id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    // Replace @id with the actual value to prevent SQL injection
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error deleting membership plan: " + ex.Message);
            }
        }
    }
}