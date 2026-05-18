using System;
using System.Collections.Generic;
using System.Linq;
using GymManagementSystem.Models;
using System.Data.SqlClient;
using GymManagementSystem.Data;

namespace GymManagementSystem.Repositories
{
    public class MemberRepository
    {
        /*
        Repository class for managing Member entities.
        this class provides methods to perform CRUD operations on the Member table in the database.
        */

        //READ
        public List<Member> GetAllMembers()
        {
            List<Member> members = new List<Member>();
            try
            {
                //create a connection to the database using the DatabaseHelper class
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    //open the connection
                    conn.Open();
                    string query = "SELECT * FROM Member";

                    //create a command to combine the query and the connection
                    SqlCommand cmd = new SqlCommand(query, conn);

                    //execute the query and get a reader to go through the results one at a time
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Member member = new Member
                        {
                            //map the database fields to the Member object properties
                            MemberID = (int)reader["member_id"],
                            FName = reader["first_name"].ToString(),
                            LName = reader["last_name"].ToString(),
                            Email = reader["email"].ToString(),

                            // phone can be NULL in the database so we check for DBNull before reading it
                            Phone = reader["phone"] == DBNull.Value ? null : reader["phone"].ToString(),

                            // date_of_birth can also be NULL so we return DateTime.MinValue as a safe default
                            DateOfBirth = reader["date_of_birth"] == DBNull.Value ? DateTime.MinValue : (DateTime)reader["date_of_birth"],

                            JoinDate = (DateTime)reader["join_date"],

                            // emergency contact fields can also be NULL
                            EmergencyContactName = reader["emergency_contact_name"] ==
                            DBNull.Value ? null : reader["emergency_contact_name"].ToString(),

                            EmergencyContactPhone = reader["emergency_contact_phone"] ==
                            DBNull.Value ? null : reader["emergency_contact_phone"].ToString(),

                            Status = reader["status"].ToString()
                        };
                        members.Add(member);
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error)
                throw new Exception("Error fetching members: " + ex.Message);
            }
            return members;
        }
        public List<Member> GetRecentMembers()
        {
            List<Member> members = new List<Member>();
            try
            {
                //create a connection to the database using the DatabaseHelper class
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    //open the connection
                    conn.Open();
                    string query = "SELECT * FROM Member order by join_date DESC";

                    //create a command to combine the query and the connection
                    SqlCommand cmd = new SqlCommand(query, conn);

                    //execute the query and get a reader to go through the results one at a time
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Member member = new Member
                        {
                            //map the database fields to the Member object properties
                            MemberID = (int)reader["member_id"],
                            FName = reader["first_name"].ToString(),
                            LName = reader["last_name"].ToString(),
                            Email = reader["email"].ToString(),

                            // phone can be NULL in the database so we check for DBNull before reading it
                            Phone = reader["phone"] == DBNull.Value ? null : reader["phone"].ToString(),

                            // date_of_birth can also be NULL so we return DateTime.MinValue as a safe default
                            DateOfBirth = reader["date_of_birth"] == DBNull.Value ? DateTime.MinValue : (DateTime)reader["date_of_birth"],

                            JoinDate = (DateTime)reader["join_date"],

                            // emergency contact fields can also be NULL
                            EmergencyContactName = reader["emergency_contact_name"] ==
                            DBNull.Value ? null : reader["emergency_contact_name"].ToString(),

                            EmergencyContactPhone = reader["emergency_contact_phone"] ==
                            DBNull.Value ? null : reader["emergency_contact_phone"].ToString(),

                            Status = reader["status"].ToString()
                        };
                        members.Add(member);
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error)
                throw new Exception("Error fetching members: " + ex.Message);
            }
            return members;
        }

        public Member GetByID(int memberId)
        {
            Member member = null;
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT * FROM Member WHERE member_id = @MemberID";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    //Replace @MemberID in the query with the actual value to prevent SQL injection
                    cmd.Parameters.AddWithValue("@MemberID", memberId);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        member = new Member
                        {
                            MemberID = (int)reader["member_id"],
                            FName = reader["first_name"].ToString(),
                            LName = reader["last_name"].ToString(),
                            Email = reader["email"].ToString(),
                            Phone = reader["phone"] == DBNull.Value ? null : reader["phone"].ToString(),
                            DateOfBirth = reader["date_of_birth"] == DBNull.Value ? DateTime.MinValue : (DateTime)reader["date_of_birth"],

                            JoinDate = (DateTime)reader["join_date"],

                            EmergencyContactName = reader["emergency_contact_name"] ==
                            DBNull.Value ? null : reader["emergency_contact_name"].ToString(),

                            EmergencyContactPhone = reader["emergency_contact_phone"] ==
                            DBNull.Value ? null : reader["emergency_contact_phone"].ToString(),
                            Status = reader["status"].ToString()
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error fetching member by ID: " + ex.Message);
            }
            return member;
        }

        public List<Member> SearchMembers(string searchText)
        {
            List<Member> members = new List<Member>();
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    //@here means write the string as multiple lines for better
                    //readability without needing to concatenate
                    string query = @"SELECT * FROM Member 
                            WHERE first_name LIKE @search 
                            OR last_name LIKE @search 
                            OR email LIKE @search";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    // % means match anything before or after the search text
                    cmd.Parameters.AddWithValue("@search", "%" + searchText + "%");
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Member member = new Member
                        {
                            //map the database fields to the Member object properties
                            MemberID = (int)reader["member_id"],
                            FName = reader["first_name"].ToString(),
                            LName = reader["last_name"].ToString(),
                            Email = reader["email"].ToString(),

                            // phone can be NULL in the database so we check for DBNull before reading it
                            Phone = reader["phone"] == DBNull.Value ? null : reader["phone"].ToString(),

                            // date_of_birth can also be NULL so we return DateTime.MinValue as a safe default
                            DateOfBirth = reader["date_of_birth"] == DBNull.Value ? DateTime.MinValue : (DateTime)reader["date_of_birth"],

                            JoinDate = (DateTime)reader["join_date"],

                            // emergency contact fields can also be NULL
                            EmergencyContactName = reader["emergency_contact_name"] ==
                            DBNull.Value ? null : reader["emergency_contact_name"].ToString(),

                            EmergencyContactPhone = reader["emergency_contact_phone"] ==
                            DBNull.Value ? null : reader["emergency_contact_phone"].ToString(),

                            Status = reader["status"].ToString()
                        };
                        members.Add(member);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error searching members: " + ex.Message);
            }
            return members;
        }

        public int GetTotalMembers()
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM MEMBER";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    // ExecuteScalar returns a single value instead of rows
                    return (int)cmd.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error counting members: " + ex.Message);
            }
        }


        public int GetActiveSubscriptionCount()
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(
                        "SELECT COUNT(*) FROM MEMBER WHERE status = 'active'", conn);
                    return (int)cmd.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error counting active subscriptions: " + ex.Message);
            }
        }

        //ADD
        public void AddMember(Member member)
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = @"INSERT INTO Member (first_name, last_name, email, phone, date_of_birth, join_date, emergency_contact_name, emergency_contact_phone, status) 
                                     VALUES (@FirstName, @LastName, @Email, @Phone, @DateOfBirth, @JoinDate, @EmergencyContactName, @EmergencyContactPhone, @Status)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@FirstName", member.FName);
                    cmd.Parameters.AddWithValue("@LastName", member.LName);
                    cmd.Parameters.AddWithValue("@Email", member.Email);

                    // Cast to object so ?? can compare string and DBNull which are different types
                    cmd.Parameters.AddWithValue("@Phone", (object)member.Phone ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@DateOfBirth", member.DateOfBirth == DateTime.MinValue ? (object)DBNull.Value : member.DateOfBirth);
                    cmd.Parameters.AddWithValue("@JoinDate", member.JoinDate);
                    cmd.Parameters.AddWithValue("@EmergencyContactName", (object)member.EmergencyContactName ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@EmergencyContactPhone", (object)member.EmergencyContactPhone ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Status", member.Status);

                    // ExecuteNonQuery is used for INSERT, UPDATE, DELETE since they dont return rows
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error adding a member: " + ex.Message);
            }
        }

        //UPDATE
        public void UpdateMember(Member member)
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = @"UPDATE Member SET first_name = @FirstName, last_name = @LastName, 
                                    email = @Email, phone = @Phone, date_of_birth = @DateOfBirth, join_date = @JoinDate, 
                                    emergency_contact_name = @EmergencyContactName, emergency_contact_phone = @EmergencyContactPhone, 
                                    status = @Status
                                     WHERE member_id = @MemberID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@FirstName", member.FName);
                    cmd.Parameters.AddWithValue("@LastName", member.LName);
                    cmd.Parameters.AddWithValue("@Email", member.Email);
                    cmd.Parameters.AddWithValue("@Phone", (object)member.Phone ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@DateOfBirth", member.DateOfBirth == DateTime.MinValue ? (object)DBNull.Value : member.DateOfBirth);
                    cmd.Parameters.AddWithValue("@JoinDate", member.JoinDate);
                    cmd.Parameters.AddWithValue("@EmergencyContactName", (object)member.EmergencyContactName ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@EmergencyContactPhone", (object)member.EmergencyContactPhone ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Status", member.Status);
                    cmd.Parameters.AddWithValue("@MemberID", member.MemberID);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating a member: " + ex.Message);
            }
        }

        //DEACTIVATE (inactive only — expires subscription + releases locker)
        public void DeactivateMember(int memberId)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                SqlTransaction tx = conn.BeginTransaction();
                try
                {
                    // 1. Set member status to inactive
                    SqlCommand cmd1 = new SqlCommand(
                        "UPDATE MEMBER SET status = 'inactive' WHERE member_id = @id", conn, tx);
                    cmd1.Parameters.AddWithValue("@id", memberId);
                    cmd1.ExecuteNonQuery();

                    // 2. Expire any active subscriptions
                    SqlCommand cmd2 = new SqlCommand(
                        "UPDATE SUBSCRIPTION SET status = 'expired' WHERE member_id = @id AND status = 'active'", conn, tx);
                    cmd2.Parameters.AddWithValue("@id", memberId);
                    cmd2.ExecuteNonQuery();

                    // 3. Release their locker
                    SqlCommand cmd3 = new SqlCommand(
                        "UPDATE LOCKER SET member_id = NULL, status = 'available' WHERE member_id = @id", conn, tx);
                    cmd3.Parameters.AddWithValue("@id", memberId);
                    cmd3.ExecuteNonQuery();

                    tx.Commit();
                }
                catch (Exception ex)
                {
                    tx.Rollback();
                    throw new Exception("Error deactivating member: " + ex.Message);
                }
            }
        }

        //DELETE
        public void DeleteMember(int memberId)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();

                // A transaction ensures all deletes succeed together.
                // If any one step fails, Rollback() undoes everything — no partial deletes.
                SqlTransaction tx = conn.BeginTransaction();
                try
                {
                    // Local helper function — defined inside DeleteMember to avoid repeating the same
                    // 3 lines (create command, add parameter, execute) for every DELETE statement.
                    // It captures 'conn', 'tx', and 'memberId' from the outer method automatically,
                    // so we only need to pass the SQL string each time we call it.
                    void Run(string sql)
                    {
                        SqlCommand cmd = new SqlCommand(sql, conn, tx);
                        cmd.Parameters.AddWithValue("@id", memberId); // always deleting by member_id
                        cmd.ExecuteNonQuery();
                    }

                    // PAYMENT links to SUBSCRIPTION, not MEMBER directly, so we use a subquery.
                    // We can still use Run() since the parameter name @id matches memberId.
                    Run(@"DELETE FROM PAYMENT WHERE subscription_id IN
                          (SELECT subscription_id FROM SUBSCRIPTION WHERE member_id = @id)");

                    // Delete all related records before deleting the member row itself.
                    // Order matters — child records must be removed before the parent (MEMBER) row
                    // to avoid foreign key constraint errors.
                    Run("DELETE FROM MEMBER_PROGRESS WHERE member_id = @id");
                    Run("DELETE FROM PT_SESSION    WHERE member_id = @id");
                    Run("DELETE FROM ATTENDANCE    WHERE member_id = @id");

                    // Release the locker instead of deleting it — the locker still exists, just unassigned
                    Run("UPDATE LOCKER SET member_id = NULL, status = 'available' WHERE member_id = @id");

                    Run("DELETE FROM SUBSCRIPTION  WHERE member_id = @id");

                    // Finally delete the member row — only safe once all related records are gone
                    Run("DELETE FROM MEMBER WHERE member_id = @id");

                    // All steps succeeded — commit makes all changes permanent
                    tx.Commit();
                }
                catch (Exception ex)
                {
                    // if Something failed — undo all changes to keep the database clean
                    tx.Rollback();
                    throw new Exception("Error deleting a member: " + ex.Message);
                }
            }
        }
    }
}
