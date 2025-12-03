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

namespace HMS_Solution.Forms
{
    public partial class ADDDoctorForm : Form
    {
        public ADDDoctorForm()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            FormHelpers.ClearFormControls(this);
        }
        /*
        @name varchar(50),
        @gender varchar(10),
        @dateOfBirth date,
        @phone varchar(15),
        @shiftTime varchar(20),
        @specialization varchar(50),
        @qualification varchar(50),
        @email varchar(50) = NULL,
        @address varchar(50) = NULL,
        @yearsOfExperience int = NULL,
        @email varchar(50) = NULL,
        @address varchar(50) = NULL,
        @licenseNo varchar(50) = NULL
        */
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbDoctorName.Text) || !(cbGender.SelectedIndex >= 0 && cbGender.SelectedIndex < 3) || dtpDateOfBirth.Value == DateTime.Today || string.IsNullOrWhiteSpace(tbPhone.Text) || !(cbTimings.SelectedIndex >= 0 && cbTimings.SelectedIndex < 3) || !(cbSpecialization.SelectedIndex >= 0 && cbSpecialization.SelectedIndex < 19 ) || !(cbQualification.SelectedIndex >= 0 && cbQualification.SelectedIndex < cbQualification.Items.Count) ) /*0-18*/
            {
                MessageBox.Show("Below fields are required to add a doctor\n1. Name\n2. Gender\n3. Date of Birth\n4. Phone\n5. Shift Timing\n6. Specialization\n7. Qualification", "Empty fields", MessageBoxButtons.OK, MessageBoxIcon.Error );
                return;
            }
            try
            {
                int ID = DoctorService.validateDoctorDetails(tbDoctorName.Text, cbGender.Text.ToLower(), dtpDateOfBirth.Value, tbPhone.Text, cbTimings.Text.ToLower(), cbSpecialization.Text, cbQualification.Text, tbEmail.Text, tbAddress.Text, tbExperience.Text, tbLicenseNo.Text);
                if(ID <=0)
                {
                    MessageBox.Show("Unable to add doctor", "Doctor not added", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(ID > 0)
                {
                    MessageBox.Show($"Doctor added with ID: {ID}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormHelpers.ClearFormControls(this);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
