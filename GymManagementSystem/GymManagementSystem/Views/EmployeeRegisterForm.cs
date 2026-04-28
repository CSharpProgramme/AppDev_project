using GymManagementSystem.Data;
using GymManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagementSystem.Views.AllRegisterForms
{
    public partial class EmployeeRegisterForm : Form
    {
        private readonly Dictionary<TextBox, string> _placeholders = new Dictionary<TextBox, string>();
        private readonly Staff _staffToEdit;
        private readonly bool _isEditMode;

        public EmployeeRegisterForm()
        {
            InitializeComponent();
            InitializeFormForMode();
        }

        public EmployeeRegisterForm(Staff staffToEdit)
        {
            InitializeComponent();
            _staffToEdit = staffToEdit;
            _isEditMode = staffToEdit != null;
            InitializeFormForMode();
        }

        private void InitializeFormForMode()
        {
            SetPlaceholder(firstName_textbox, "first Name");
            SetPlaceholder(lastName_textBox, "Last Name");
            SetPlaceholder(email_textBox, "Email");
            SetPlaceholder(phone_textBox, "Phone");
            SetPlaceholder(salary_textBox, "Salary");
            SetPlaceholder(position_textBox, "Position");
            SetPlaceholder(role_textBox, "Role");
            SetPlaceholder(password_textBox, "Password");
            SetPlaceholder(username_textBox, "username");

            if (_isEditMode)
            {
                Text = "Edit Employee";
                confirmButton.Text = "Update Employee";

                firstName_textbox.Text = _staffToEdit.FName ?? string.Empty;
                lastName_textBox.Text = _staffToEdit.LName ?? string.Empty;
                email_textBox.Text = _staffToEdit.Email ?? string.Empty;
                phone_textBox.Text = _staffToEdit.Phone ?? string.Empty;
                salary_textBox.Text = _staffToEdit.Salary.ToString("0.##");
                position_textBox.Text = _staffToEdit.Position ?? string.Empty;
                role_textBox.Text = _staffToEdit.Role ?? string.Empty;
                username_textBox.Text = _staffToEdit.Username ?? string.Empty;
                password_textBox.Text = _staffToEdit.PasswordHash ?? string.Empty;

                firstName_textbox.ForeColor = Color.Black;
                lastName_textBox.ForeColor = Color.Black;
                email_textBox.ForeColor = Color.Black;
                phone_textBox.ForeColor = Color.Black;
                salary_textBox.ForeColor = Color.Black;
                position_textBox.ForeColor = Color.Black;
                role_textBox.ForeColor = Color.Black;
                username_textBox.ForeColor = Color.Black;
                password_textBox.ForeColor = Color.Black;
            }
        }

        private void SetPlaceholder(TextBox textBox, string placeholder)
        {
            _placeholders[textBox] = placeholder;
            textBox.Text = placeholder;
            textBox.ForeColor = Color.Gray;

            textBox.Enter += (sender, e) =>
            {
                if (textBox.Text == placeholder)
                {
                    textBox.Text = "";
                    textBox.ForeColor = Color.Black;
                }
            };

            textBox.Leave += (sender, e) =>
            {
                if (textBox.Text == "")
                {
                    textBox.Text = placeholder;
                    textBox.ForeColor = Color.Gray;
                }
            };
        }

        private string GetTrimmedValue(TextBox textBox)
        {
            string value = textBox.Text.Trim();
            return _placeholders.TryGetValue(textBox, out string placeholder) && value == placeholder ? string.Empty : value;
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            string firstName = GetTrimmedValue(firstName_textbox);
            string lastName = GetTrimmedValue(lastName_textBox);
            string email = GetTrimmedValue(email_textBox);
            string phone = GetTrimmedValue(phone_textBox);
            string position = GetTrimmedValue(position_textBox);
            string role = GetTrimmedValue(role_textBox);
            string username = GetTrimmedValue(username_textBox);
            string password = GetTrimmedValue(password_textBox);
            string salaryRaw = GetTrimmedValue(salary_textBox);

            if (string.IsNullOrWhiteSpace(firstName) ||
                string.IsNullOrWhiteSpace(lastName) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(position) ||
                string.IsNullOrWhiteSpace(role) ||
                string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(salaryRaw))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            if (!decimal.TryParse(salaryRaw, out decimal salary) || salary < 0)
            {
                MessageBox.Show("Invalid salary!");
                return;
            }

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (SqlTransaction transaction = conn.BeginTransaction())
                {

                    try
                    {
                        string query;
                        if (_isEditMode)
                        {
                            query = @"UPDATE STAFF SET
            first_name = @fName,
            last_name = @lName,
            email = @email,
            phone = @phone,
            position = @position,
            salary = @salary,
            username = @username,
            password_hash = @password_hash,
            role = @role
            WHERE staff_id = @staffId";
                        }
                        else
                        {
                            query = @"INSERT INTO STAFF 
            (first_name, last_name, email, phone, position, salary, username, password_hash, role, last_login)
            VALUES 
            (@fName, @lName, @email, @phone, @position, @salary, @username, @password_hash, @role, @last_login)";
                        }

                        SqlCommand cmd = new SqlCommand(query, conn, transaction);

                        cmd.Parameters.AddWithValue("@fName", firstName);
                        cmd.Parameters.AddWithValue("@lName", lastName);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@phone", string.IsNullOrWhiteSpace(phone) ? (object)DBNull.Value : phone);

                        cmd.Parameters.AddWithValue("@position", position);
                        cmd.Parameters.AddWithValue("@salary", salary);

                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password_hash", password); // later hash this
                        cmd.Parameters.AddWithValue("@role", role);
                        if (_isEditMode)
                        {
                            cmd.Parameters.AddWithValue("@staffId", _staffToEdit.StaffId);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@last_login", DBNull.Value);
                        }

                        cmd.ExecuteNonQuery();

                        transaction.Commit();

                        MessageBox.Show(_isEditMode ? "Employee updated successfully!" : "Employee added successfully!");
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }
    }
}


                
    