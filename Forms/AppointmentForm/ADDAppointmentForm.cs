using HMS_Solution.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS_Solution.Forms.AppointmentForm
{
    public partial class ADDAppointmentForm : Form
    {
        public ADDAppointmentForm()
        {
            InitializeComponent();
        }

        private void btnSearchPatientID_Click(object sender, EventArgs e)
        {
            pnlSearchPatients.Visible = true;
        }

        private void btnSearchDoctorID_Click(object sender, EventArgs e)
        {
            pnlSearchDoctors.Visible = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            FormHelpers.ClearFormControls(this);
        }

        private void btnCancelPpnl_Click(object sender, EventArgs e)
        {
            pnlSearchPatients.Visible = false;
        }

        private void btnCancelDpnl_Click(object sender, EventArgs e)
        {
            pnlSearchDoctors.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Width = 816; this.Height = 489;
        }

        private void btnSearchPpnl_Click(object sender, EventArgs e)
        {
            string nameParam = string.IsNullOrWhiteSpace(tbSearchPatientName.Text) ? null : tbSearchPatientName.Text;
            string phoneParam = string.IsNullOrWhiteSpace(tbSearchPatientPhone.Text) ? null : tbSearchPatientPhone.Text;

            if(nameParam == null && phoneParam == null)
            {
                MessageBox.Show("Please enter something to search", "Empty fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            HMSDataContext db = new HMSDataContext();

            var result = db.searchPatientsWithDetails(nameParam, phoneParam).Select(x => new { ID = x.patientID, Name = x.name, Gender = x.gender, DateOfBirth = x.dateOfBirth, Phone = x.phone, Email = x.email}).ToList();
            if (result.Any())
            {
                dgvSearchList.DataSource = result;
                this.Width = 816; this.Height = 680;
            }
            else
            {
                MessageBox.Show("No patient found", "No patient", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSearchDpnl_Click(object sender, EventArgs e)
        {
            string nameParam = string.IsNullOrWhiteSpace(tbSearchDoctorName.Text) ? null : tbSearchDoctorName.Text;
            string specParam = string.IsNullOrWhiteSpace(tbSearchSpecialization.Text) ? null : tbSearchSpecialization.Text;

            if (nameParam == null && specParam == null)
            {
                MessageBox.Show("Please enter something to search", "Empty fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            HMSDataContext db = new HMSDataContext();

            var result = db.searchDoctorsWithDetails(nameParam, specParam).Select(x => new { ID = x.doctorID, Name = x.name, Gender = x.gender, Specialization = x.specialization, Qualification = x.qualification, Timings = x.shiftTime, Phone = x.phone}).ToList();
            
            if (result.Any())
            {
                dgvSearchList.DataSource = result;
                this.Width = 816; this.Height = 680;
            }
            else
            {
                MessageBox.Show("No doctor found", "No doctor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(tbPatientID.Text) || string.IsNullOrWhiteSpace(tbDoctorID.Text))
            {
                MessageBox.Show("Below fields are required to make an appointment\n1. Patient ID\n2. Doctor ID", "Empty fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                int ID = AppointmentService.validateAddAppointment(tbPatientID.Text, tbDoctorID.Text, dtpAppDate.Value, dtpAppTime.Value, tbReason.Text);
                if (ID > 0)
                {
                    MessageBox.Show($"New appointment created with ID: {ID}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormHelpers.ClearFormControls(this);
                    this.Height = 489;
                }
                else
                {
                    MessageBox.Show("Appointment could not be created", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ADDAppointmentForm_Load(object sender, EventArgs e)
        {
            tbPatientID.Focus();
        }
    }
}
