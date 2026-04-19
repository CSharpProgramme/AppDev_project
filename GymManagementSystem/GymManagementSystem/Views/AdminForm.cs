using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagementSystem
{
    /*
     * Acts as the Front Controller for the application.
        All navigation goes through this form.
        It controls which UserControl (View) is loaded into the main content panel
        based on the sidebar button the user clicks.
    */
    
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadControl(new DashboardControl());
        }

        //HELPER METHOD TO LOAD USER CONTROLS INTO THE MAIN PANEL
        private void LoadControl(UserControl uc)
        {
            mainPanel.Controls.Clear();//CLEAR EXISTING CONTROLS
            uc.Dock = DockStyle.Fill;//FILL THE PANEL WITH THE NEW CONTROL
            mainPanel.Controls.Add(uc);//ADD THE NEW CONTROL TO THE PANEL
        }

        private void dashBoardButton_Click(object sender, EventArgs e)
        {
            LoadControl(new DashboardControl());
        }

        private void membersButton_Click(object sender, EventArgs e)
        {
            LoadControl(new MemberControl());
        }

        private void employeeButton_Click(object sender, EventArgs e)
        {
            LoadControl(new EmployeeControl());
        }

        private void trainersButton_Click(object sender, EventArgs e)
        {
            LoadControl(new TrainerControl());
        }

        private void paymentButton_Click(object sender, EventArgs e)
        {
            LoadControl(new PaymentControl());
        }

        private void auditLogButton_Click(object sender, EventArgs e)
        {
            LoadControl(new FacilityControl());
        }

        private void membershipPlanButton_Click(object sender, EventArgs e)
        {
            LoadControl(new MembershipPlanControl());
        }
    }
}
