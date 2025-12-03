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

namespace HMS_Solution.Forms.DoctorForm
{
    public partial class UPDATEDoctor : Form
    {
        public UPDATEDoctor()
        {
            InitializeComponent();
        }

        private void btnSearchDoctorID_Click(object sender, EventArgs e)
        {
            pnlUpdateDoctor.Visible = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlUpdateDoctor.Visible = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            FormHelpers.ClearFormControls(this);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            HMSDataContext db = new HMSDataContext();

            string nameParam = string.IsNullOrWhiteSpace(tbSearchDoctorName.Text) ? null : tbSearchDoctorName.Text;
            string specParam = string.IsNullOrWhiteSpace(tbSearchDoctorSpecialization.Text) ? null : tbSearchDoctorSpecialization.Text;

            if (string.IsNullOrWhiteSpace(nameParam) && string.IsNullOrWhiteSpace(specParam))
            {
                MessageBox.Show("Please enter something to search", "Empty fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var rawResult = db.searchDoctorsWithDetails(nameParam, specParam).ToList();

            if (rawResult.Any())
            {
                var finalResult = rawResult.Select(x => new { ID = x.doctorID, Name = x.name, x.gender, x.dateOfBirth, x.phone }).ToList();
                dgvSearchList.DataSource = finalResult;
                this.Width = 816; this.Height = 680;
            }
            else
            {
                MessageBox.Show("No doctor found", "No doctor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Width = 816; this.Height = 489; // This will close the search result list
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbDoctorName.Text) || !(cbGender.SelectedIndex >= 0 && cbGender.SelectedIndex < 3) || dtpDateOfBirth.Value == DateTime.Today || string.IsNullOrWhiteSpace(tbPhone.Text) || !(cbTimings.SelectedIndex >= 0 && cbTimings.SelectedIndex < 3) || !(cbSpecialization.SelectedIndex >= 0 && cbSpecialization.SelectedIndex < 19) || !(cbQualification.SelectedIndex >= 0 && cbQualification.SelectedIndex < cbQualification.Items.Count)) /*0-18*/
            {
                MessageBox.Show("Below fields are required to update a doctor\n1. Name\n2. Gender\n3. Date of Birth\n4. Phone\n5. Shift Timing\n6. Specialization\n7. Qualification", "Empty fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                int ID = DoctorService.validateUpdateDoctorDetails(tbDoctorID.Text ,tbDoctorName.Text, cbGender.Text.ToLower(), dtpDateOfBirth.Value, tbPhone.Text, cbTimings.Text.ToLower(), cbSpecialization.Text, cbQualification.Text, tbEmail.Text, tbAddress.Text, tbExperience.Text, tbLicenseNo.Text);
                if (ID <= 0)
                {
                    MessageBox.Show("Unable to add doctor", "Doctor not added", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (ID > 0)
                {
                    MessageBox.Show("Doctor details updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormHelpers.ClearFormControls(this);
                    tbDoctorID.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbDoctorID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) // Check if the pressed key is the Enter key.
            {
                e.Handled = true; // Prevent the 'ding' sound on enter press.

                this.Width = 816; this.Height = 489;

                if (int.TryParse(tbDoctorID.Text, out int doctorId))
                {
                    HMSDataContext db = new HMSDataContext();

                    var doctor = db.doctors.FirstOrDefault(p => p.doctorID == doctorId);

                    if (doctor == null)
                    {
                        MessageBox.Show("Doctor not found.", "No doctor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FormHelpers.ClearFormControls(this);
                        return;
                    }

                    // setting all the textboxes with the relevat ID

                    tbDoctorName.Text = doctor.name;
                    cbGender.Text = doctor.gender;
                    dtpDateOfBirth.Value = doctor.dateOfBirth;
                    tbPhone.Text = doctor.phone;
                    tbEmail.Text = doctor.email;
                    tbAddress.Text = doctor.address;
                    tbJoiningDtae.Text = doctor.joiningDate.ToString();
                    cbTimings.Text = doctor.shiftTime;
                    cbSpecialization.Text = doctor.specialization;
                    cbQualification.Text = doctor.qualification;
                    tbExperience.Text = doctor.yearsOfExperience.ToString();
                    tbLicenseNo.Text = doctor.licenseNo;
                }
                else
                {
                    MessageBox.Show("Please enter a valid numeric ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    FormHelpers.ClearFormControls(this);
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
