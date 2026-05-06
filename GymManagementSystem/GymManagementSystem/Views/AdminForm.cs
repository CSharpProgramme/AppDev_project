using GymManagementSystem.Controllers;
using GymManagementSystem.Localization;
using GymManagementSystem.Views;
using System;
using System.Globalization;
using System.Threading;
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
        private bool _languageComboInitializing;

        public AdminForm()
        {
            InitializeComponent();
            InitLanguageCombo();
            SyncLanguageComboFromCulture();
            ApplyPermissions();
        }

        private void InitLanguageCombo()
        {
            languageComboBox.Items.Clear();
            languageComboBox.Items.AddRange(new object[] { "English", "Français", "Español" });
        }

        private void SyncLanguageComboFromCulture()
        {
            _languageComboInitializing = true;
            try
            {
                string two = Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName;
                languageComboBox.SelectedIndex = two == "fr" ? 1 : two == "es" ? 2 : 0;
            }
            finally
            {
                _languageComboInitializing = false;
            }
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
            RefreshDashboardLanguageInMainPanel();
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

        private void languageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_languageComboInitializing || languageComboBox.SelectedIndex < 0)
            {
                return;
            }

            string cultureName = languageComboBox.SelectedIndex == 1 ? "fr-FR" : languageComboBox.SelectedIndex == 2 ? "es-ES" : "en-US";
            var culture = new CultureInfo(cultureName);
            Thread.CurrentThread.CurrentUICulture = culture;
            Thread.CurrentThread.CurrentCulture = culture;
            ApplyLanguage(this);
            RefreshDashboardLanguageInMainPanel();
        }

        private void ApplyLanguage(Control root)
        {
            string lang = Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName;

            foreach (Control control in root.Controls)
            {
                if (control == languageComboBox)
                {
                    if (control.HasChildren)
                    {
                        ApplyLanguage(control);
                    }

                    continue;
                }

                if (!string.IsNullOrWhiteSpace(control.Text))
                {
                    control.Text = MainPanelLocalization.TranslateVisibleText(control.Text, lang);
                }

                if (control.HasChildren)
                {
                    ApplyLanguage(control);
                }
            }
        }

        private void RefreshDashboardLanguageInMainPanel()
        {
            foreach (Control c in mainPanel.Controls)
            {
                if (c is DashboardControl dashboard)
                {
                    dashboard.RefreshLanguage();
                   
                }
                if (c is EmployeeControl employeeControl)
                {
                    employeeControl.RefreshLanguage();

                }
                if (c is MemberControl memberControl)
                {
                    memberControl.RefreshLanguage();

                }
                if (c is PTSessionForm pTSessionForm)
                {
                    pTSessionForm.RefreshLanguage();

                }
                if (c is TrainerControl trainerControl)
                {
                    trainerControl.RefreshLanguage();

                }
                if (c is  AttendanceControl attendanceControl)
                {
                    attendanceControl.RefreshLanguage();

                }
                if (c is RevenueControl revenueControl)
                {
                    revenueControl.RefreshLanguage();

                }
                if (c is MembershipPlanControl membershipPlanControl)
                {
                    membershipPlanControl.RefreshLanguage();

                }
            }
        }
        public void ApplyPermissions()
        {
            if (Auth.Role == "staff")
            {
                employeeButton.Enabled = false;
                attendanceButton.Enabled = false;


            }
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
         
            loginForm.FormClosed += (s, args) => this.Close();
            loginForm.Show();
            this.Hide();
        }
    }
}
