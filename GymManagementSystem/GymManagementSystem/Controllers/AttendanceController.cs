using System.Data;
using GymManagementSystem.Repositories;

namespace GymManagementSystem.Controllers
{
    /// Acts as the bridge between AttendanceControl (the View) and AttendanceRepository.
    /// The View calls the Controller, the Controller calls the Repository,
    /// and the Repository talks to the database.
    public class AttendanceController
    {
        // The repository that handles all attendance SQL queries
        private readonly AttendanceRepository attendanceRepository = new AttendanceRepository();

 
        /// Returns true if the member is currently inside the gym (has no check_out).
        public bool IsCheckedIn(int memberId)
        {
            return attendanceRepository.IsCheckedIn(memberId);
        }

        /// Records a member entering the gym. Validates active status and no double check-in.
        public void CheckIn(int memberId)
        {
            attendanceRepository.CheckIn(memberId);
        }

        /// Records a member leaving the gym. Closes their open attendance record.
        public void CheckOut(int memberId)
        {
            attendanceRepository.CheckOut(memberId);
        }

        /// Returns a DataTable of all members currently inside the gym today.
        public DataTable GetCurrentlyIn()
        {
            return attendanceRepository.GetCurrentlyIn();
        }

        /// Returns a DataTable of every check-in/out today — full attendance history.
        /// Members still inside show "Still in" for their check-out time.
        public DataTable GetTodayAttendanceLog()
        {
            return attendanceRepository.GetTodayAttendanceLog();
        }
    }
}
