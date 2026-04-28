using System;

namespace GymManagementSystem.Models
{
    public class Staff
    {
        private int staffId;
        private string fName;
        private string lName;
        private string email;
        private string phone;
        private string position;
        private string username;
        private string passwordHash;
        private DateTime lastLogin;
        private string role;
        private decimal salary;
        private DateTime hireDate;
        private string status;

        // Constructor
        public Staff(int staff_id, string fName, string lName, string email, string phone,
            string position, string username, string password_hash,
            DateTime last_login, string role, decimal salary, DateTime hireDate, string status)
        {
            StaffId = staff_id;
            FName = fName;
            LName = lName;
            Email = email;
            Phone = phone;
            Position = position;
            Username = username;
            PasswordHash = password_hash;
            LastLogin = last_login;
            Role = role;
            Salary = salary;
            HireDate = hireDate;
            Status = status;
        }

        public Staff() { }

        // Properties
        public int StaffId
        {
            get { return staffId; }
            set { staffId = value; }
        }

        public string FName
        {
            get { return fName; }
            set { fName = value; }
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

        public string Position
        {
            get { return position; }
            set { position = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string PasswordHash
        {
            get { return passwordHash; }
            set { passwordHash = value; }
        }

        public DateTime LastLogin
        {
            get { return lastLogin; }
            set { lastLogin = value; }
        }

        public string Role
        {
            get { return role; }
            set { role = value; }
        }

        public decimal Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public DateTime HireDate
        {
            get { return hireDate; }
            set { hireDate = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        // Methods
        public override string ToString()
        {
            return $"Staff[{StaffId}] - {FName} {LName}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Staff other = (Staff)obj;
            return this.StaffId == other.StaffId;
        }

        public override int GetHashCode()
        {
            return StaffId.GetHashCode();
        }
    }
}