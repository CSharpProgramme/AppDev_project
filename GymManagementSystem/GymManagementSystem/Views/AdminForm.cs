using GymManagementSystem.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
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
        private bool isFrenchUi;
        private readonly Dictionary<string, string> englishToFrench = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            { "Dashboard", "Tableau de bord" },
            { "Members", "Membres" },
            { "Employees", "Employes" },
            { "Trainers", "Entraineurs" },
            { "Revenue", "Revenu" },
            { "Member's Attendance", "Présence des membres" },
            { "Membership Plan", "Abonnements" },
            { "Membership Plans", "Abonnements" },
            { "Admin Panel", "Panneau admin" },
            { "Register a Member", "Inscrire un membre" },
            { "Edit a Member", "Modifier un membre" },
            { "Delete Member", "Supprimer membre" },
            { "Search", "Rechercher" },
            { "Member List", "Liste des membres" },
            { "Register Member", "Inscrire membre" },
            { "Register Trainer", "Inscrire entraineur" },
            { "Edit Trainer", "Modifier entraineur" },
            { "Delete Trainer", "Supprimer entraineur" },
            { "View PT Session", "Voir session PT" },
            { "Register Plan", "Inscrire plan" },
            { "Delete Plan", "Supprimer plan" },
            { "Edit Plan", "Modifier plan" },
            { "PT Sessions", "Sessions PT" },
            { "Create Session", "Creer session" },
            { "Edit Session", "Modifier session" },
            { "Cancel Session", "Annuler session" },
                { "Register Staff", "Ajouter personnel" },
            { "Edit Staff Info", "Modifier personnel" },
            { "Delete Staff", "Suprimmer personnel" }
        };

        public AdminForm()
        {
            InitializeComponent();
        
            isFrenchUi = Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName == "fr";
            ApplyPermissions();
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
            ApplyLanguage(this);
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
            LoadControl(new RevenueControl());
        }

        private void auditLogButton_Click(object sender, EventArgs e)
        {
            LoadControl(new AttendanceControl());
        }

        private void membershipPlanButton_Click(object sender, EventArgs e)
        {
            LoadControl(new MembershipPlanControl());
        }

        private void languageBtn_Click(object sender, EventArgs e)
        {
            isFrenchUi = !isFrenchUi;
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(isFrenchUi ? "fr-FR" : "en-US");
            Thread.CurrentThread.CurrentCulture = new CultureInfo(isFrenchUi ? "fr-FR" : "en-US");
            ApplyLanguage(this);
        }

        private void ApplyLanguage(Control root)
        {
            foreach (Control control in root.Controls)
            {
                if (!string.IsNullOrWhiteSpace(control.Text))
                {
                    control.Text = TranslateText(control.Text);
                }

                if (control.HasChildren)
                {
                    ApplyLanguage(control);
                }
            }

            EnglishBtn.Text = isFrenchUi ? "English" : "Francais";
        }

        private string TranslateText(string source)
        {
            if (isFrenchUi)
            {
                return englishToFrench.TryGetValue(source, out string frenchText) ? frenchText : source;
            }

            foreach (var pair in englishToFrench)
            {
                if (string.Equals(source, pair.Value, StringComparison.OrdinalIgnoreCase))
                {
                    return pair.Key;
                }
            }

            return source;
        }
        public void ApplyPermissions()
        {
            if (Auth.Role == "staff")
            {
                employeeButton.Enabled = false;
                attendanceButton.Enabled = false;


            }
        }
    }
}
