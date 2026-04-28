using System;
using System.Collections.Generic;
using GymManagementSystem.Models;
using GymManagementSystem.Repositories;

namespace GymManagementSystem.Controllers
{
    /// Acts as the bridge between the View and the StaffRepository.
    /// The View calls the Controller, the Controller calls the Repository,
    /// and the Repository talks to the database.
    public class StaffController
    {
        private StaffRepository staffRepository;

        public StaffController()
        {
            staffRepository = new StaffRepository();
        }

        // GET ALL STAFF
        public List<Staff> GetAllStaff()
        {
            return staffRepository.GetAllStaff();
        }

        // GET STAFF BY ID
        public Staff GetStaffByID(int staffId)
        {
            return staffRepository.GetStaffByID(staffId);
        }

        // SEARCH STAFF (by name, email, etc.)
        public List<Staff> SearchStaff(string keyword)
        {
            return staffRepository.SearchStaff(keyword);
        }

        // GET TOTAL STAFF COUNT
        public int GetTotalStaff()
        {
            return staffRepository.GetTotalStaff();
        }

        // ADD STAFF
        public void AddStaff(Staff staff)
        {
            staffRepository.AddStaff(staff);
        }

        // UPDATE STAFF
        public void UpdateStaff(Staff staff)
        {
            staffRepository.UpdateStaff(staff);
        }

        // DELETE STAFF
        public void DeleteStaff(int staffId)
        {
            staffRepository.DeleteStaff(staffId);
        }
    }
}