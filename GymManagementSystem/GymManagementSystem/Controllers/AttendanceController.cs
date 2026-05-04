using System.Data;
using GymManagementSystem.Repositories;

namespace GymManagementSystem.Controllers
{
    /// <summary>
    /// Acts as the bridge between AttendanceControl (the View) and AttendanceRepository.
    /// The View calls the Controller, the Controller calls the Repository,
    /// and the Repository talks to the database.
    /// </summary>
    public class AttendanceController
    {
        // The repository that handles all attendance SQL queries
        private readonly AttendanceRepository attendanceRepository = new AttendanceRepository();

        /// <summary>
        /// Returns true if the member is currently inside the gym (has no check_out).
        /// </summary>
        public bool IsCheckedIn(int memberId)
        {
            return attendanceRepository.IsCheckedIn(memberId);
        }

        /// <summary>
        /// Records a member entering the gym. Validates active status and no double check-in.
        /// </summary>
        public void CheckIn(int memberId)
        {
            attendanceRepository.CheckIn(memberId);
        }

        /// <summary>
        /// Records a member leaving the gym. Closes their open attendance record.
        /// </summary>
        public void CheckOut(int memberId)
        {
            attendanceRepository.CheckOut(memberId);
        }

        /// <summary>
        /// Returns a DataTable of all members currently inside the gym today.
        /// </summary>
        public DataTable GetCurrentlyIn()
        {
            return attendanceRepository.GetCurrentlyIn();
        }

        /// <summary>
        /// Returns a DataTable of every check-in/out today — full attendance history.
        /// Members still inside show "Still in" for their check-out time.
        /// </summary>
        public DataTable GetTodayAttendanceLog()
        {
            return attendanceRepository.GetTodayAttendanceLog();
        }
    }
}
