using System;

namespace GymManagementSystem.Models
{
    public class PTSession
    {
        // Attributes
        private int ptSessionID;
        private int memberID;
        private int trainerID;
        private DateTime scheduledAt;
        private int durationMinutes;
        private string notes;
        private string status;

        // Constructor
        public PTSession(int ptSessionID, int memberID, int trainerID,
                         DateTime scheduledAt, int durationMinutes,
                         string notes, string status)
        {
            PTSessionID = ptSessionID;
            MemberID = memberID;
            TrainerID = trainerID;
            ScheduledAt = scheduledAt;
            DurationMinutes = durationMinutes;
            Notes = notes;
            Status = status;
        }

        // Default constructor
        public PTSession()
        {
        }

        // Getters and Setters

        public int PTSessionID
        {
            get { return ptSessionID; }
            set { ptSessionID = value; }
        }

        public int MemberID
        {
            get { return memberID; }
            set { memberID = value; }
        }

        public int TrainerID
        {
            get { return trainerID; }
            set { trainerID = value; }
        }

        public DateTime ScheduledAt
        {
            get { return scheduledAt; }
            set { scheduledAt = value; }
        }

        public int DurationMinutes
        {
            get { return durationMinutes; }
            set { durationMinutes = value; }
        }

        public string Notes
        {
            get { return notes; }
            set { notes = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        // Methods

        public override string ToString()
        {
            return $"Session[{PTSessionID}] - Member {MemberID} with Trainer {TrainerID}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (this.GetType() != obj.GetType()) return false;

            PTSession other = (PTSession)obj;
            return this.PTSessionID == other.PTSessionID;
        }

        public override int GetHashCode()
        {
            return PTSessionID.GetHashCode();
        }
    }
}