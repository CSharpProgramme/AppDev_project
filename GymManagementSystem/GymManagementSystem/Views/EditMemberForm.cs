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

            string originalStatus = selectedMember.Status;
            string newStatus = statusComboBox.SelectedItem.ToString();

            // If activating an inactive/suspended member, open the reactivation flow
            if (newStatus == "active" && originalStatus != "active")
            {
                // Save all other field changes first (keep original status for now)
                selectedMember.FName = fNameTextBox.Text.Trim();
                selectedMember.LName = lNameTextBox.Text.Trim();
                selectedMember.Email = emailTextBox.Text.Trim();
                selectedMember.Phone = phoneTextBox.Text.Trim();
                selectedMember.DateOfBirth = birthdayPicker.Value.Date;
                selectedMember.EmergencyContactName = emergencyContactTextBox.Text.Trim();
                selectedMember.EmergencyContactPhone = emergencyPhoneTextBox.Text.Trim();

                try
                {
                    memberController.UpdateMember(selectedMember);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating member: " + ex.Message, "Error");
                    return;
                }

                // Now open reactivation form for plan + payment
                ReactivateMemberForm reactivateForm = new ReactivateMemberForm(selectedMember);
                reactivateForm.FormClosed += (s, args) => this.Close();
                reactivateForm.ShowDialog();
                return;
            }

            // Update all other fields first
            selectedMember.FName = fNameTextBox.Text.Trim();
            selectedMember.LName = lNameTextBox.Text.Trim();
            selectedMember.Email = emailTextBox.Text.Trim();
            selectedMember.Phone = phoneTextBox.Text.Trim();
            selectedMember.DateOfBirth = birthdayPicker.Value.Date;
            selectedMember.Status = newStatus;
            selectedMember.EmergencyContactName = emergencyContactTextBox.Text.Trim();
            selectedMember.EmergencyContactPhone = emergencyPhoneTextBox.Text.Trim();

            try
            {
                // Deactivating — expire subscription + release locker
                if (newStatus == "inactive" && originalStatus != "inactive")
                {
                    memberController.DeactivateMember(selectedMember.MemberID);
                    MessageBox.Show(
                        $"{selectedMember.FName} {selectedMember.LName} has been deactivated.\nSubscription expired and locker released.",
                        "Deactivated");
                }
                else
                {
                    // Suspended or any other normal update
                    memberController.UpdateMember(selectedMember);
                    MessageBox.Show("Member updated successfully!", "Success");
                }
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