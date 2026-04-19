using GymManagementSystem.Models;
using GymManagementSystem.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagementSystem.Controllers
{
    /*
     Acts as the bridge between the View and the MembershipPlanRepository.
    The View calls the Controller, the Controller calls the Repository,
    and the Repository talks to the database.
     */
    public class MembershipPlanController
    {
        private MembershipPlanRepository planRepository;

        public MembershipPlanController()
        {
            planRepository = new MembershipPlanRepository();
        }

        public List<MembershipPlan> GetAllPlans()
        {
            return planRepository.GetAllPlans();
        }

        public MembershipPlan GetPlanById(int id)
        {
            return planRepository.GetById(id);
        }

        public void UpdatePlan(MembershipPlan plan)
        {
            planRepository.UpdatePlan(plan);
        }

        public void DeletePlan(int id)
        {
            planRepository.DeletePlan(id);
        }

        public void AddPlan(MembershipPlan plan)
        {
            planRepository.AddPlan(plan);
        }
    }
}
