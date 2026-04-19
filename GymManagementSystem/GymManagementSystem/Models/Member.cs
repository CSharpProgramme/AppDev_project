using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagementSystem.Models
{
    public class Member
    {
        //Attributes
        private int memberID;
        private string fName;
        private string lName;
        private string email;
        private string phone;
        private DateTime dateOfBirth;
        private DateTime joinDate;
        private string emergencyContactName;
        private string emergencyContactPhone;
        private string status;

        // Constructor
        public Member(int memberID, string fName, string lName, string email, string phone, 
            DateTime dateOfBirth, DateTime joinDate, string emergencyContactName, 
            string emergencyContactPhone, string status)
        {
            MemberID = memberID;
            FName = fName;
            LName = lName;
            Email = email;
            Phone = phone;
            DateOfBirth = dateOfBirth;
            JoinDate = joinDate;
            EmergencyContactName = emergencyContactName;
            EmergencyContactPhone = emergencyContactPhone;
            Status = status;
        }

        public Member()
        {
            // Default constructor
        }

        // Getters and Setters
        public int MemberID
        {
            get{ return memberID; }
            set{ memberID = value; }
        }

        public string FName
        {
            get{ return fName; }
            set{ fName = value; }
        }
        public string LName
        {
            get { return lName; }
            set { lName = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }

        public DateTime JoinDate
        {
            get { return joinDate; }
            set { joinDate = value; }
        }

        public string EmergencyContactName
        {
            get { return emergencyContactName; }
            set { emergencyContactName = value; }
        }

        public string EmergencyContactPhone
        {
            get { return emergencyContactPhone; }
            set { emergencyContactPhone = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        // Methods
        public override string ToString()
        {
            return $"Member[{MemberID}] - {FName} {LName}";
        }

        public override bool Equals(object obj)
        {
            // Check if obj is null
            if (obj == null) return false;

            // Check if they are the same type
            if (this.GetType() != obj.GetType()) return false;

            // Cast and compare by ID
            Member other = (Member)obj;
            return this.MemberID == other.MemberID;
        }

        /*
         * Used by collections like Dictionary and HashSet for fast object lookup.
         * Rule: if two objects are equal, they must have the same hash code.
         * We use MemberID since it uniquely identifies each member.
         */
        public override int GetHashCode()
        {
            return MemberID.GetHashCode();
        }
    }
}
