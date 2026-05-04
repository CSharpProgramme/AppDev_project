using System;
using System.Collections.Generic;
using GymManagementSystem.Models;
using GymManagementSystem.Repositories;

namespace GymManagementSystem.Controllers
{
    public class ActivationController
    {
        private readonly ActivationRepository activationRepository = new ActivationRepository();
        private readonly MembershipPlanRepository planRepository = new MembershipPlanRepository();

        public List<MembershipPlan> GetAllPlans()
        {
            return planRepository.GetAllPlans();
        }

        public void ReactivateMember(int memberId, int planId, string paymentMethod, DateTime startDate, int processedBy)
        {
            activationRepository.ReactivateMember(memberId, planId, paymentMethod, startDate, processedBy);
        }
    }
}
