using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagementSystem.Models
{
    public class MembershipPlan
    {
        //Attributes
        private int planId;
        private string name;
        private string description;
        private decimal price;
        private int durationDays;

        //constructor
        public MembershipPlan(int planId, string name, string description, decimal price, int durationDays)
        {
            PlanId = planId;
            Name = name;
            Description = description;
            Price = price;
            DurationDays = durationDays;
        }

        // Default constructor
        public MembershipPlan() { }

        // Properties
        public int PlanId
        {
            get { return planId; }
            set { planId = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        public int DurationDays
        {
            get { return durationDays; }
            set { durationDays = value; }
        }

        public override string ToString()
        {
            return $"Plan[{planId}] - {name} (${price})";
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;

            if (this.GetType() != obj.GetType()) return false;

            MembershipPlan other = (MembershipPlan)obj;
            return this.planId == other.planId;
        }

        public override int GetHashCode()
        {
            return planId.GetHashCode();
        }
    }
}
