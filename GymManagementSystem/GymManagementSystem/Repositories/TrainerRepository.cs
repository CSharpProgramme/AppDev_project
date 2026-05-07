using GymManagementSystem.Data;
using GymManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace GymManagementSystem.Repositories
{
    public class TrainerRepository
    {
        public List<Trainer> GetAllTrainers()
        {
            List<Trainer> trainers = new List<Trainer>();

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM Trainer";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    trainers.Add(new Trainer
                    {
                        TrainerId = (int)reader["trainer_id"],
                        FName = reader["first_name"].ToString(),
                        LName = reader["last_name"].ToString(),
                        Email = reader["email"].ToString(),
                        Phone = reader["phone"] == DBNull.Value ? null : reader["phone"].ToString(),
                        Specialization = reader["specialization"] == DBNull.Value ? null : reader["specialization"].ToString(),
                        HourlyRate = (decimal)reader["hourly_rate"]
                    });
                }
            }

            return trainers;
        }

        public void AddTrainer(Trainer trainer)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = @"INSERT INTO Trainer
                    (first_name, last_name, email, phone, specialization, hourly_rate)
                    VALUES
                    (@FirstName, @LastName, @Email, @Phone, @Specialization, @HourlyRate)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@FirstName", trainer.FName);
                cmd.Parameters.AddWithValue("@LastName", trainer.LName);
                cmd.Parameters.AddWithValue("@Email", trainer.Email);
                cmd.Parameters.AddWithValue("@Phone", string.IsNullOrWhiteSpace(trainer.Phone) ? (object)DBNull.Value : trainer.Phone);
                cmd.Parameters.AddWithValue("@Specialization", string.IsNullOrWhiteSpace(trainer.Specialization) ? (object)DBNull.Value : trainer.Specialization);
                cmd.Parameters.AddWithValue("@HourlyRate", trainer.HourlyRate);
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateTrainer(Trainer trainer)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = @"UPDATE Trainer SET
                    first_name = @FirstName,
                    last_name = @LastName,
                    email = @Email,
                    phone = @Phone,
                    specialization = @Specialization,
                    hourly_rate = @HourlyRate
                    WHERE trainer_id = @TrainerId";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@FirstName", trainer.FName);
                cmd.Parameters.AddWithValue("@LastName", trainer.LName);
                cmd.Parameters.AddWithValue("@Email", trainer.Email);
                cmd.Parameters.AddWithValue("@Phone", string.IsNullOrWhiteSpace(trainer.Phone) ? (object)DBNull.Value : trainer.Phone);
                cmd.Parameters.AddWithValue("@Specialization", string.IsNullOrWhiteSpace(trainer.Specialization) ? (object)DBNull.Value : trainer.Specialization);
                cmd.Parameters.AddWithValue("@HourlyRate", trainer.HourlyRate);
                cmd.Parameters.AddWithValue("@TrainerId", trainer.TrainerId);
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteTrainer(int trainerId)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                SqlTransaction tx = conn.BeginTransaction();
                try
                {
                    // Delete PT sessions linked to this trainer first
                    // (trainer_id is NOT NULL in PT_SESSION so we can't set it to NULL)
                    SqlCommand deleteSessions = new SqlCommand(
                        "DELETE FROM PT_SESSION WHERE trainer_id = @id", conn, tx);
                    deleteSessions.Parameters.AddWithValue("@id", trainerId);
                    deleteSessions.ExecuteNonQuery();

                    // Now safe to delete the trainer
                    SqlCommand deleteTrainer = new SqlCommand(
                        "DELETE FROM TRAINER WHERE trainer_id = @id", conn, tx);
                    deleteTrainer.Parameters.AddWithValue("@id", trainerId);
                    deleteTrainer.ExecuteNonQuery();

                    tx.Commit();
                }
                catch (Exception ex)
                {
                    tx.Rollback();
                    throw new Exception("Error deleting trainer: " + ex.Message);
                }
            }
        }
    }
}
