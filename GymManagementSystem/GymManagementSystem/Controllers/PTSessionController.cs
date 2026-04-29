using GymManagementSystem.Models;
using GymManagementSystem.Repositories;
using System.Collections.Generic;

namespace GymManagementSystem.Controllers
{
    /*
     Acts as the bridge between the View and PTSessionRepository.
     The View calls this Controller, and it communicates with the Repository.
    */
    public class PTSessionController
    {
        private readonly PTSessionRepository sessionRepository;

        public PTSessionController()
        {
            sessionRepository = new PTSessionRepository();
        }

        // READ ALL
        public List<PTSession> GetAllSessions()
        {
            return sessionRepository.GetAllSessions();
        }

        // READ BY ID
        public PTSession GetSessionById(int id)
        {
            return sessionRepository.GetByID(id);
        }

        // ADD
        public void AddSession(PTSession session)
        {
            sessionRepository.AddSession(session);
        }

        // UPDATE
        public void UpdateSession(PTSession session)
        {
            sessionRepository.UpdateSession(session);
        }

        // DELETE
        public void DeleteSession(int id)
        {
            sessionRepository.DeleteSession(id);
        }
    }
}