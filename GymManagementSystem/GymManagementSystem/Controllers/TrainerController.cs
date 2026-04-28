using GymManagementSystem.Models;
using GymManagementSystem.Repositories;
using System.Collections.Generic;

namespace GymManagementSystem.Controllers
{
    public class TrainerController
    {
        private readonly TrainerRepository trainerRepository;

        public TrainerController()
        {
            trainerRepository = new TrainerRepository();
        }

        public List<Trainer> GetAllTrainers()
        {
            return trainerRepository.GetAllTrainers();
        }

        public void AddTrainer(Trainer trainer)
        {
            trainerRepository.AddTrainer(trainer);
        }

        public void UpdateTrainer(Trainer trainer)
        {
            trainerRepository.UpdateTrainer(trainer);
        }

        public void DeleteTrainer(int trainerId)
        {
            trainerRepository.DeleteTrainer(trainerId);
        }
    }
}
