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
    public partial class VIEWDoctor : Form
    {
        public VIEWDoctor()
        {
            InitializeComponent();
        }

        private void tbDoctorID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // Prevent the 'ding' sound on enter press
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
                    tbName.Text = doctor.name;
                    cbGender.Text = doctor.gender;
                    dtpDateOfBirth.Value = doctor.dateOfBirth;
                    tbPhone.Text = doctor.phone;
                    tbEmail.Text = doctor.email;
                    tbAddress.Text = doctor.address;
                    dtpJoiningDate.Value =(DateTime)doctor.joiningDate;
                    cbTimings.Text = doctor.shiftTime;
                    cbSpecialization.Text = doctor.specialization;
                    cbqualification.Text = doctor.qualification;
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

        private void button1_Click(object sender, EventArgs e)
        {
            pnlViewDoctor.Visible = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlViewDoctor.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Width = 816; this.Height = 489; // This will close the search result list
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            HMSDataContext db = new HMSDataContext();

            string nameParam = string.IsNullOrWhiteSpace(tbSearchPatientName.Text) ? null : tbSearchPatientName.Text;
            string specParam = string.IsNullOrWhiteSpace(tbSearchPatientPhone.Text) ? null : tbSearchPatientPhone.Text;

            if (string.IsNullOrWhiteSpace(nameParam) && string.IsNullOrWhiteSpace(specParam))
            {
                MessageBox.Show("Please enter something to search", "Empty fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var rawResult = db.searchDoctorsWithDetails(nameParam, specParam).ToList();

            if (rawResult.Any())
            {
                var finalResult = rawResult.Select(x => new { ID = x.doctorID, Name = x.name, x.gender, x.dateOfBirth, x.phone }).ToList();
                dgvSearchResult.DataSource = finalResult;
                this.Width = 816; this.Height = 680;
            }
            else
            {
                MessageBox.Show("No doctor found", "No doctor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
