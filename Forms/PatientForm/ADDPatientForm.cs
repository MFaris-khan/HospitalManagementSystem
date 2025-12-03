using HMS_Solution.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS_Solution.Forms.PatientForm
{
    public partial class ADDPatientForm : Form
    {
        public ADDPatientForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbPatientName.Text) || string.IsNullOrWhiteSpace(tbPhone.Text) || cbGender.SelectedIndex == -1 || dtpDateOfBirth.Value == DateTime.Today)
            {
                MessageBox.Show("These fields are required to enter a patient \n1. Patient Name \n2. Gender \n3. Date of birth \n4. Phone", "Required fields are empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {   // Main call that will turn into a DB Call
                int check = PatientService.ValidateAddPatient(tbPatientName.Text, cbGender.Text.ToLower(), dtpDateOfBirth.Value, tbPhone.Text, cb1.Checked, cb2.Checked, cb3.Checked, cb4.Checked, cb5.Checked, cb6.Checked, cb7.Checked, cb8.Checked, cb9.Checked, cb10.Checked, tbEmail.Text, tbAddress.Text, cbBloodGroup.Text, tbMedicalHistory.Text, tbAllergies.Text, tbEmergencyName.Text, tbEmergencyPhone.Text);
                
                if (check > 0)
                {
                    MessageBox.Show($"New patient added with ID: {check}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormHelpers.ClearFormControls(this);
                }
                else
                {
                    MessageBox.Show("Unknown error occured while adding patinet", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            FormHelpers.ClearFormControls(this);

        }
    }
}
