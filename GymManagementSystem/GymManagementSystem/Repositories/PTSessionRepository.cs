using System;
using System.Collections.Generic;
using GymManagementSystem.Models;
using System.Data.SqlClient;
using GymManagementSystem.Data;

namespace GymManagementSystem.Repositories
{
    public class PTSessionRepository
    {
        /*
        Repository class for managing PTSession entities.
        Provides CRUD operations for pt_session table.
        */

        // READ ALL
        public List<PTSession> GetAllSessions()
        {
            List<PTSession> sessions = new List<PTSession>();

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT * FROM pt_session";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        PTSession session = new PTSession
                        {
                            PTSessionID = (int)reader["pt_session_id"],
                            MemberID = (int)reader["member_id"],
                            TrainerID = (int)reader["trainer_id"],
                            ScheduledAt = (DateTime)reader["scheduled_at"],
                            DurationMinutes = (int)reader["duration_minutes"],
                            Notes = reader["notes"] == DBNull.Value ? null : reader["notes"].ToString(),
                            Status = reader["status"].ToString()
                        };

                        sessions.Add(session);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error fetching sessions: " + ex.Message);
            }

            return sessions;
        }

        // READ BY ID
        public PTSession GetByID(int sessionId)
        {
            PTSession session = null;

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT * FROM pt_session WHERE pt_session_id = @SessionID";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@SessionID", sessionId);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        session = new PTSession
                        {
                            PTSessionID = (int)reader["pt_session_id"],
                            MemberID = (int)reader["member_id"],
                            TrainerID = (int)reader["trainer_id"],
                            ScheduledAt = (DateTime)reader["scheduled_at"],
                            DurationMinutes = (int)reader["duration_minutes"],
                            Notes = reader["notes"] == DBNull.Value ? null : reader["notes"].ToString(),
                            Status = reader["status"].ToString()
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error fetching session by ID: " + ex.Message);
            }

            return session;
        }

        // ADD
        public void AddSession(PTSession session)
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string query = @"INSERT INTO pt_session 
                                    (member_id, trainer_id, scheduled_at, duration_minutes, notes, status)
                                     VALUES (@MemberID, @TrainerID, @ScheduledAt, @DurationMinutes, @Notes, @Status)";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@MemberID", session.MemberID);
                    cmd.Parameters.AddWithValue("@TrainerID", session.TrainerID);
                    cmd.Parameters.AddWithValue("@ScheduledAt", session.ScheduledAt);
                    cmd.Parameters.AddWithValue("@DurationMinutes", session.DurationMinutes);
                    cmd.Parameters.AddWithValue("@Notes", (object)session.Notes ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Status", session.Status);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error adding session: " + ex.Message);
            }
        }

        // UPDATE
        public void UpdateSession(PTSession session)
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string query = @"UPDATE pt_session SET
                                     member_id = @MemberID,
                                     trainer_id = @TrainerID,
                                     scheduled_at = @ScheduledAt,
                                     duration_minutes = @DurationMinutes,
                                     notes = @Notes,
                                     status = @Status
                                     WHERE pt_session_id = @SessionID";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@MemberID", session.MemberID);
                    cmd.Parameters.AddWithValue("@TrainerID", session.TrainerID);
                    cmd.Parameters.AddWithValue("@ScheduledAt", session.ScheduledAt);
                    cmd.Parameters.AddWithValue("@DurationMinutes", session.DurationMinutes);
                    cmd.Parameters.AddWithValue("@Notes", (object)session.Notes ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Status", session.Status);
                    cmd.Parameters.AddWithValue("@SessionID", session.PTSessionID);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating session: " + ex.Message);
            }
        }

        // DELETE
        public void DeleteSession(int sessionId)
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string query = "DELETE FROM pt_session WHERE pt_session_id = @SessionID";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@SessionID", sessionId);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error deleting session: " + ex.Message);
            }
        }
    }
}