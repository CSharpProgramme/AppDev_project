using GymManagementSystem.Controllers;
using GymManagementSystem.Data;
using GymManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace GymManagementSystem.Views
{
    
    /*
     * Form for registering a new member.
     * Uses a transaction to insert into MEMBER, SUBSCRIPTION and PAYMENT tables.
     * If any of the 3 inserts fail, all changes are rolled back.
     */
    public partial class RegisterForm : Form
    {
        private MemberController memberController;
        private MembershipPlanController planController;

        // Keeps track of selected plan button
        private Button selectedPlanButton = null;
        private int selectedPlanId = -1;
        private decimal selectedPlanPrice = 0;
        private int selectedPlanDuration = 0;

        // TODO: Replace with actual logged in staff ID when login is implemented
        private int processedBy = 1;

        public RegisterForm()
        {
            InitializeComponent();
            memberController = new MemberController();
            planController = new MembershipPlanController();

            // Placeholders for personal info
            SetPlaceholder(fNameTextBox, "First Name");
            SetPlaceholder(lNameTextBox, "Last Name");
            SetPlaceholder(emailTextBox, "Email Address");
            SetPlaceholder(phoneTextBox, "Phone Number");

            // Placeholders for emergency contact
            SetPlaceholder(emergencyContactTextBox, "Emergency Contact Name");
            SetPlaceholder(emergencyPhoneTextBox, "Emergency Contact Phone");

            // Load payment method options into ComboBox
            paymentComboBox.Items.AddRange(new string[] { "Cash", "Credit Card", "Debit Card" });
            paymentComboBox.SelectedIndex = 0;

            // Load plan buttons from database
            LoadPlanButtons();
        }

        // Dynamically creates a button for each membership plan
        private void LoadPlanButtons()
        {
            flowLayoutPlanPanel.Controls.Clear();

            List<MembershipPlan> plans = planController.GetAllPlans();

            foreach (MembershipPlan plan in plans)
            {
                Button btn = new Button();
                btn.Size = new Size(130, 60);
                btn.Text = plan.Name + "\n$" + plan.Price.ToString("0.00");
                btn.Tag = plan;
                btn.FlatStyle = FlatStyle.Flat;
                btn.Margin = new Padding(5);

                btn.Click += (sender, e) =>
                {
                    // Reset previously selected button
                    if (selectedPlanButton != null)
                        selectedPlanButton.BackColor = SystemColors.Control;

                    // Highlight selected button
                    btn.BackColor = Color.LightGreen;
                    selectedPlanButton = btn;

                    // Store selected plan details
                    MembershipPlan selected = (MembershipPlan)btn.Tag;
                    selectedPlanId = selected.PlanId;
                    selectedPlanPrice = selected.Price;
                    selectedPlanDuration = selected.DurationDays;

                    // Calculate total with 15% tax and display it
                    decimal tax = selectedPlanPrice * 0.15m;
                    decimal total = selectedPlanPrice + tax;
                    showAmountTextBox.Text = "$" + total.ToString("0.00");
                };

                flowLayoutPlanPanel.Controls.Add(btn);
            }
        }

        // Reusable method to set placeholder on any TextBox
        private void SetPlaceholder(TextBox textBox, string placeholder)
        {
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

        // Validates the form fields before registering
        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(fNameTextBox.Text))
            {
                MessageBox.Show("Please enter a first name.", "Validation Error");
                return false;
            }
            if (string.IsNullOrWhiteSpace(lNameTextBox.Text))
            {
                MessageBox.Show("Please enter a last name.", "Validation Error");
                return false;
            }
            if (string.IsNullOrWhiteSpace(emailTextBox.Text))
            {
                MessageBox.Show("Please enter an email.", "Validation Error");
                return false;
            }
            if (selectedPlanId == -1)
            {
                MessageBox.Show("Please select a membership plan.", "Validation Error");
                return false;
            }
            return true;
        }

        // Handles the Register button click - runs the transaction
        private void finalizeButton_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();

                // Start the transaction
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    //Insert member and get the new member ID
                    string memberQuery = @"INSERT INTO MEMBER 
                                        (first_name, last_name, email, phone, date_of_birth,
                                         join_date, emergency_contact_name, emergency_contact_phone, status)
                                        VALUES 
                                        (@fName, @lName, @email, @phone, @dateOfBirth,
                                         @joinDate, @emergencyContactName, @emergencyContactPhone, @status);
                                        SELECT SCOPE_IDENTITY();";

                    SqlCommand memberCmd = new SqlCommand(memberQuery, conn, transaction);
                    memberCmd.Parameters.AddWithValue("@fName", fNameTextBox.Text.Trim());
                    memberCmd.Parameters.AddWithValue("@lName", lNameTextBox.Text.Trim());
                    memberCmd.Parameters.AddWithValue("@email", emailTextBox.Text.Trim());
                    memberCmd.Parameters.AddWithValue("@phone", string.IsNullOrWhiteSpace(phoneTextBox.Text) ? (object)DBNull.Value : phoneTextBox.Text.Trim());
                    memberCmd.Parameters.AddWithValue("@dateOfBirth", birthdayTimePicker.Value.Date);
                    memberCmd.Parameters.AddWithValue("@joinDate", DateTime.Today);
                    memberCmd.Parameters.AddWithValue("@emergencyContactName", string.IsNullOrWhiteSpace(emergencyContactTextBox.Text) ? (object)DBNull.Value : emergencyContactTextBox.Text.Trim());
                    memberCmd.Parameters.AddWithValue("@emergencyContactPhone", string.IsNullOrWhiteSpace(emergencyPhoneTextBox.Text) ? (object)DBNull.Value : emergencyPhoneTextBox.Text.Trim());
                    
                    // Status defaults to active for new members
                    memberCmd.Parameters.AddWithValue("@status", "active");

                    // ExecuteScalar returns the new member ID from SELECT SCOPE_IDENTITY()
                    int newMemberId = Convert.ToInt32(memberCmd.ExecuteScalar());

                    //Insert subscription using the new member ID
                    DateTime startDate = DateTime.Today;
                    DateTime endDate = startDate.AddDays(selectedPlanDuration);

                    string subQuery = @"INSERT INTO SUBSCRIPTION (member_id, plan_id, start_date, end_date, status)
                                      VALUES (@memberId, @planId, @startDate, @endDate, @status);
                                      SELECT SCOPE_IDENTITY();";

                    SqlCommand subCmd = new SqlCommand(subQuery, conn, transaction);
                    subCmd.Parameters.AddWithValue("@memberId", newMemberId);
                    subCmd.Parameters.AddWithValue("@planId", selectedPlanId);
                    subCmd.Parameters.AddWithValue("@startDate", startDate);
                    subCmd.Parameters.AddWithValue("@endDate", endDate);
                    subCmd.Parameters.AddWithValue("@status", "active");

                    int newSubscriptionId = Convert.ToInt32(subCmd.ExecuteScalar());

                    // Step 3 - Insert payment using the new subscription ID
                    string payQuery = @"INSERT INTO PAYMENT 
                                      (subscription_id, processed_by, amount, payment_date, method, status)
                                      VALUES 
                                      (@subId, @processedBy, @amount, @paymentDate, @method, @status)";

                    SqlCommand payCmd = new SqlCommand(payQuery, conn, transaction);
                    payCmd.Parameters.AddWithValue("@subId", newSubscriptionId);
                    payCmd.Parameters.AddWithValue("@processedBy", processedBy);
                    payCmd.Parameters.AddWithValue("@amount", selectedPlanPrice);
                    payCmd.Parameters.AddWithValue("@paymentDate", DateTime.Today);
                    // Convert display value (e.g. "Credit Card") to DB constraint value (e.g. "credit_card")
                    payCmd.Parameters.AddWithValue("@method", paymentComboBox.SelectedItem.ToString().ToLower().Replace(" ", "_"));
                    payCmd.Parameters.AddWithValue("@status", "completed");

                    payCmd.ExecuteNonQuery();

                    // All 3 inserts succeeded so commit the transaction
                    transaction.Commit();

                    MessageBox.Show("Member registered successfully!", "Success");
                    this.Close();
                }
                catch (Exception ex)
                {
                    // Something failed so roll back all changes
                    transaction.Rollback();
                    MessageBox.Show("Error registering member: " + ex.Message, "Error");
                }
            }
        }

        // Closes the form without saving
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}