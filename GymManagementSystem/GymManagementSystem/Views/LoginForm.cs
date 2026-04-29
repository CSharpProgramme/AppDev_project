using GymManagementSystem.Controllers;
using GymManagementSystem.Models;
using GymManagementSystem.Repositories;
using GymManagementSystem.Views;
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
    public partial class LoginForm : Form
    {
        StaffRepository staffRepository = new StaffRepository();
       
        
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Staff staff = staffRepository.Login(txtUsername.Text, txtPassword.Text);

            if (staff != null)
            {
                Auth.Role = staff.Role;
                Auth.UserId = staff.StaffId;

                MessageBox.Show("Login successful");

                AdminForm admin = new AdminForm();
                admin.FormClosed += (s, args) => this.Close();
                admin.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid login");
            }

        }
    }
}
