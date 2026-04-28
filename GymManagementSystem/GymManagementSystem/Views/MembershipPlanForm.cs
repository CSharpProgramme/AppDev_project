using GymManagementSystem.Controllers;
using GymManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagementSystem.Views
{
    public partial class MembershipPlanForm : Form
    {
        private MembershipPlanController membershipPlanController;
        private MembershipPlan selectedPlan;
        public MembershipPlanForm()
        {
            InitializeComponent();
        }
    }
}
