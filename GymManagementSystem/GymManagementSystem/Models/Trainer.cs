using System;

namespace GymManagementSystem.Models
{
    public class Trainer
    {
        public int TrainerId { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Specialization { get; set; }
        public decimal HourlyRate { get; set; }
    }
}
