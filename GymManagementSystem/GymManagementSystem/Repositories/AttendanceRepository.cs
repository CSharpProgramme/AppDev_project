using System;
using System.Data;
using System.Data.SqlClient;
using GymManagementSystem.Data;

namespace GymManagementSystem.Repositories
{
    /// Handles all database operations for the ATTENDANCE table.
    /// This is the only class that writes SQL related to attendance.
    /// The controller calls these methods — this class never talks to the UI directly.
    public class AttendanceRepository
    {
       
        /// Checks if a member is currently inside the gym.
        /// A member is "in" if they have an ATTENDANCE row where check_out is NULL.
        public bool IsCheckedIn(int memberId)
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    // Look for an open attendance record from today only
                    // Past days with NULL check_out are stale and don't count
                    SqlCommand cmd = new SqlCommand(
                        "SELECT COUNT(*) FROM ATTENDANCE WHERE member_id = @id AND check_out IS NULL AND CAST(check_in AS DATE) = CAST(GETDATE() AS DATE)", conn);

                    cmd.Parameters.AddWithValue("@id", memberId);

                    // ExecuteScalar returns a single value — the count
                    // If count > 0, member is already checked in
                    return (int)cmd.ExecuteScalar() > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error checking attendance status: " + ex.Message);
            }
        }

        /// Records a member's entry into the gym.
        /// Inserts a new row in ATTENDANCE with check_in = now and check_out = NULL.
        /// Only allows check-in if the member is active and not already inside.
        public void CheckIn(int memberId)
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    // First verify the member is active — inactive/suspended members cannot enter
                    SqlCommand statusCmd = new SqlCommand(
                        "SELECT status FROM MEMBER WHERE member_id = @id", conn);

                    statusCmd.Parameters.AddWithValue("@id", memberId);

                    string status = statusCmd.ExecuteScalar()?.ToString();

                    if (status != "active")
                        throw new Exception("Only active members can check in.");

                    // Prevent double check-in — only check today's records
                    // A NULL check_out from a previous day is stale and should not block a new check-in
                    SqlCommand checkCmd = new SqlCommand(
                        "SELECT COUNT(*) FROM ATTENDANCE WHERE member_id = @id AND check_out IS NULL AND CAST(check_in AS DATE) = CAST(GETDATE() AS DATE)", conn);

                    checkCmd.Parameters.AddWithValue("@id", memberId);
                    if ((int)checkCmd.ExecuteScalar() > 0)
                        throw new Exception("This member is already checked in today.");

                    // Insert a new attendance record — check_out is left NULL until they leave
                    SqlCommand insertCmd = new SqlCommand(
                        "INSERT INTO ATTENDANCE (member_id, check_in) VALUES (@id, @checkIn)", conn);

                    insertCmd.Parameters.AddWithValue("@id", memberId);
                    insertCmd.Parameters.AddWithValue("@checkIn", DateTime.Now); // record exact time
                    insertCmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// Records a member leaving the gym.
        /// Finds the open attendance record (check_out IS NULL) and sets check_out = now.
        public void CheckOut(int memberId)
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    // Make sure the member has an open check-in from today before checking out
                    SqlCommand checkCmd = new SqlCommand(
                        "SELECT COUNT(*) FROM ATTENDANCE WHERE member_id = @id AND check_out IS NULL AND CAST(check_in AS DATE) = CAST(GETDATE() AS DATE)", conn);

                    checkCmd.Parameters.AddWithValue("@id", memberId);

                    if ((int)checkCmd.ExecuteScalar() == 0)
                        throw new Exception("This member is not currently checked in.");

                    // Update only today's open attendance record — set check_out to right now
                    SqlCommand updateCmd = new SqlCommand(@"
                        UPDATE ATTENDANCE
                        SET check_out = @checkOut
                        WHERE member_id = @id
                          AND check_out IS NULL
                          AND CAST(check_in AS DATE) = CAST(GETDATE() AS DATE)", conn);

                    updateCmd.Parameters.AddWithValue("@checkOut", DateTime.Now);
                    updateCmd.Parameters.AddWithValue("@id", memberId);
                    updateCmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// Returns a DataTable of every attendance record for today —
        /// including members who already checked out (check_out is not NULL).
        /// This gives the full picture of who came and went today.
        public DataTable GetTodayAttendanceLog()
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    // JOIN ATTENDANCE with MEMBER to show names instead of IDs
                    // ISNULL replaces a NULL check_out with the text "Still in" for display
                    SqlCommand cmd = new SqlCommand(@"
                        SELECT
                            m.first_name + ' ' + m.last_name  AS MemberName,
                            a.check_in                         AS CheckIn,
                            ISNULL(CONVERT(VARCHAR, a.check_out, 120), 'Still in') AS CheckOut
                        FROM ATTENDANCE a
                        INNER JOIN MEMBER m ON a.member_id = m.member_id
                        WHERE CAST(a.check_in AS DATE) = CAST(GETDATE() AS DATE)
                        ORDER BY a.check_in DESC", conn);

                    DataTable dt = new DataTable();
                    new SqlDataAdapter(cmd).Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error fetching attendance log: " + ex.Message);
            }
        }

        /// Returns a DataTable of all members currently inside the gym.
        /// These are members who have a check_in today but no check_out yet.
        /// Uses a JOIN to get member names alongside their check-in times.
        public DataTable GetCurrentlyIn()
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    // JOIN ATTENDANCE with MEMBER to get the member's name
                    // Filter to today's date and only rows where check_out IS NULL (still inside)
                    SqlCommand cmd = new SqlCommand(@"
                        SELECT
                            a.attendance_id                        AS AttendanceId,
                            m.member_id                            AS MemberId,
                            m.first_name + ' ' + m.last_name       AS MemberName,
                            a.check_in                             AS CheckIn
                        FROM ATTENDANCE a
                        INNER JOIN MEMBER m ON a.member_id = m.member_id
                        WHERE a.check_out IS NULL
                          AND CAST(a.check_in AS DATE) = CAST(GETDATE() AS DATE)
                        ORDER BY a.check_in DESC", conn);

                    DataTable dt = new DataTable();
                    // SqlDataAdapter fills the DataTable with all matching rows at once
                    new SqlDataAdapter(cmd).Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error fetching currently in members: " + ex.Message);
            }
        }
    }
}
