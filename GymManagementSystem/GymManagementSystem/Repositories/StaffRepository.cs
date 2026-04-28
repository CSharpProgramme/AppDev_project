using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using GymManagementSystem.Data;
using GymManagementSystem.Models;

namespace GymManagementSystem.Repositories
{
    public class StaffRepository
    {
        // READ ALL STAFF
        public List<Staff> GetAllStaff()
        {
            List<Staff> staffList = new List<Staff>();

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string query = "SELECT * FROM Staff";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Staff staff = new Staff
                        {
                            StaffId = (int)reader["staff_id"],
                            FName = reader["first_name"].ToString(),
                            LName = reader["last_name"].ToString(),
                            Email = reader["email"].ToString(),
                            Phone = reader["phone"] == DBNull.Value ? null : reader["phone"].ToString(),
                            Position = reader["position"].ToString(),
                            Username = reader["username"].ToString(),
                            PasswordHash = reader["password_hash"].ToString(),
                            LastLogin = reader["last_login"] == DBNull.Value ? DateTime.MinValue : (DateTime)reader["last_login"],
                            Role = reader["role"].ToString(),
                            Salary = reader["salary"] == DBNull.Value ? 0 : (decimal)reader["salary"],
                            HireDate = (DateTime)reader["hire_Date"],
                            Status = reader["status"].ToString()
                        };

                        staffList.Add(staff);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error fetching staff: " + ex.Message);
            }

            return staffList;
        }

        // READ BY ID
        public Staff GetStaffByID(int staffId)
        {
            Staff staff = null;

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string query = "SELECT * FROM Staff WHERE staff_id = @StaffID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@StaffID", staffId);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        staff = new Staff
                        {
                            StaffId = (int)reader["staff_id"],
                            FName = reader["first_name"].ToString(),
                            LName = reader["last_name"].ToString(),
                            Email = reader["email"].ToString(),
                            Phone = reader["phone"] == DBNull.Value ? null : reader["phone"].ToString(),
                            Position = reader["position"].ToString(),
                            Username = reader["username"].ToString(),
                            PasswordHash = reader["password_hash"].ToString(),
                            LastLogin = reader["last_login"] == DBNull.Value ? DateTime.MinValue : (DateTime)reader["last_login"],
                            Role = reader["role"].ToString(),
                            Salary = reader["salary"] == DBNull.Value ? 0 : (decimal)reader["salary"],
                            HireDate = (DateTime)reader["hire_Date"],
                            Status = reader["status"].ToString()
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error fetching staff by ID: " + ex.Message);
            }

            return staff;
        }

        // SEARCH STAFF
        public List<Staff> SearchStaff(string searchText)
        {
            List<Staff> staffList = new List<Staff>();

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string query = @"
                        SELECT * FROM Staff
                        WHERE first_name LIKE @search
                        OR last_name LIKE @search
                        OR email LIKE @search";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@search", "%" + searchText + "%");

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Staff staff = new Staff
                        {
                            StaffId = (int)reader["staff_id"],
                            FName = reader["first_name"].ToString(),
                            LName = reader["last_name"].ToString(),
                            Email = reader["email"].ToString(),
                            Phone = reader["phone"] == DBNull.Value ? null : reader["phone"].ToString(),
                            Position = reader["position"].ToString(),
                            Username = reader["username"].ToString(),
                            PasswordHash = reader["password_hash"].ToString(),
                            LastLogin = reader["last_login"] == DBNull.Value ? DateTime.MinValue : (DateTime)reader["last_login"],
                            Role = reader["role"].ToString(),
                            Salary = reader["salary"] == DBNull.Value ? 0 : (decimal)reader["salary"],
                            HireDate = (DateTime)reader["hire_Date"],
                            Status = reader["status"].ToString()
                        };

                        staffList.Add(staff);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error searching staff: " + ex.Message);
            }

            return staffList;
        }

        // TOTAL STAFF
        public int GetTotalStaff()
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string query = "SELECT COUNT(*) FROM Staff";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    return (int)cmd.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error counting staff: " + ex.Message);
            }
        }

        // ADD STAFF
        public void AddStaff(Staff staff)
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string query = @"
                        INSERT INTO Staff
                        (first_name, last_name, email, phone, position, username, password_hash, last_login, role, salary, hire_Date, status)
                        VALUES
                        (@FirstName, @LastName, @Email, @Phone, @Position, @Username, @PasswordHash, @LastLogin, @Role, @Salary, @HireDate, @Status)";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@FirstName", staff.FName);
                    cmd.Parameters.AddWithValue("@LastName", staff.LName);
                    cmd.Parameters.AddWithValue("@Email", staff.Email);
                    cmd.Parameters.AddWithValue("@Phone", (object)staff.Phone ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Position", staff.Position);
                    cmd.Parameters.AddWithValue("@Username", staff.Username);
                    cmd.Parameters.AddWithValue("@PasswordHash", staff.PasswordHash);
                    cmd.Parameters.AddWithValue("@LastLogin", staff.LastLogin == DateTime.MinValue ? (object)DBNull.Value : staff.LastLogin);
                    cmd.Parameters.AddWithValue("@Role", staff.Role);
                    cmd.Parameters.AddWithValue("@Salary", staff.Salary);
                    cmd.Parameters.AddWithValue("@HireDate", staff.HireDate);
                    cmd.Parameters.AddWithValue("@Status", staff.Status);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error adding staff: " + ex.Message);
            }
        }

        // UPDATE STAFF
        public void UpdateStaff(Staff staff)
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string query = @"
                        UPDATE Staff SET
                        first_name = @FirstName,
                        last_name = @LastName,
                        email = @Email,
                        phone = @Phone,
                        position = @Position,
                        username = @Username,
                        password_hash = @PasswordHash,
                        last_login = @LastLogin,
                        role = @Role,
                        salary = @Salary,
                        hire_Date = @HireDate,
                        status = @Status
                        WHERE staff_id = @StaffID";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@FirstName", staff.FName);
                    cmd.Parameters.AddWithValue("@LastName", staff.LName);
                    cmd.Parameters.AddWithValue("@Email", staff.Email);
                    cmd.Parameters.AddWithValue("@Phone", (object)staff.Phone ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Position", staff.Position);
                    cmd.Parameters.AddWithValue("@Username", staff.Username);
                    cmd.Parameters.AddWithValue("@PasswordHash", staff.PasswordHash);
                    cmd.Parameters.AddWithValue("@LastLogin", staff.LastLogin == DateTime.MinValue ? (object)DBNull.Value : staff.LastLogin);
                    cmd.Parameters.AddWithValue("@Role", staff.Role);
                    cmd.Parameters.AddWithValue("@Salary", staff.Salary);
                    cmd.Parameters.AddWithValue("@HireDate", staff.HireDate);
                    cmd.Parameters.AddWithValue("@Status", staff.Status);
                    cmd.Parameters.AddWithValue("@StaffID", staff.StaffId);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating staff: " + ex.Message);
            }
        }

        // DELETE STAFF
        public void DeleteStaff(int staffId)
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string query = "DELETE FROM Staff WHERE staff_id = @StaffID";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@StaffID", staffId);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error deleting staff: " + ex.Message);
            }
        }
    }
}