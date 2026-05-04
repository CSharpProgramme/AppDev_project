using System;
using System.Data;
using GymManagementSystem.Repositories;

namespace GymManagementSystem.Controllers
{
    /// Acts as the bridge between RevenueControl (the View) and RevenueRepository.
    /// The View calls the Controller, the Controller calls the Repository,
    /// and the Repository talks to the database.
    public class RevenueController
    {
        // The repository that handles all revenue-related SQL queries
        private readonly RevenueRepository revenueRepository = new RevenueRepository();

        /// Returns the total revenue collected in the current month.
        /// Used by the dashboard stat card.
        public decimal GetRevenueThisMonth()
        {
            return revenueRepository.GetRevenueThisMonth();
        }

        /// Returns a DataTable of payments filtered by date range and optional payment method.
        /// Used to populate the payment grid in the Revenue screen.
        public DataTable GetPayments(DateTime from, DateTime to, string method)
        {
            return revenueRepository.GetPayments(from, to, method);
        }

        /// Returns a DataTable of total revenue grouped by month within the date range.
        /// Used to populate the bar chart in the Revenue screen.
        public DataTable GetMonthlyRevenue(DateTime from, DateTime to, string method)
        {
            return revenueRepository.GetMonthlyRevenue(from, to, method);
        }
    }
}
