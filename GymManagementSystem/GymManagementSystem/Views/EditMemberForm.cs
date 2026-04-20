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
    public partial class EditMemberForm : Form
    {
        private MemberController memberController;
        private Member selectedMember;

        public EditMemberForm(Member member)
        {
            InitializeComponent();
            memberController = new MemberController();
            selectedMember = member;
            // Load status options
            statusComboBox.Items.AddRange(new string[] { "active", "inactive", "suspended" });

            // Pre-fill all fields with the selected member's data
            PreFillFields();
        }

        // Pre-fills all fields with the selected member's current data
        private void PreFillFields()
        {
            fNameTextBox.Text = selectedMember.FName;
            lNameTextBox.Text = selectedMember.LName;
            emailTextBox.Text = selectedMember.Email;
            phoneTextBox.Text = selectedMember.Phone;
            birthdayPicker.Value = selectedMember.DateOfBirth == DateTime.MinValue ? DateTime.Today : selectedMember.DateOfBirth;
            statusComboBox.SelectedItem = selectedMember.Status;
            emergencyContactTextBox.Text = selectedMember.EmergencyContactName;
            emergencyPhoneTextBox.Text = selectedMember.EmergencyContactPhone;
        }

        // Validates the form fields before saving
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
            return true;
        }

        // Saves the updated member info to the database
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;

            // Update the selected member's properties with the new values
            selectedMember.FName = fNameTextBox.Text.Trim();
            selectedMember.LName = lNameTextBox.Text.Trim();
            selectedMember.Email = emailTextBox.Text.Trim();
            selectedMember.Phone = phoneTextBox.Text.Trim();
            selectedMember.DateOfBirth = birthdayPicker.Value.Date;
            selectedMember.Status = statusComboBox.SelectedItem.ToString();
            selectedMember.EmergencyContactName = emergencyContactTextBox.Text.Trim();
            selectedMember.EmergencyContactPhone = emergencyPhoneTextBox.Text.Trim();

            try
            {
                // Send updated member to the controller
                memberController.UpdateMember(selectedMember);
                MessageBox.Show("Member updated successfully!", "Success");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating member: " + ex.Message, "Error");
            }
        }

        // Closes the form without saving
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}