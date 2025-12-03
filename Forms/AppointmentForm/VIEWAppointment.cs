using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS_Solution.Forms.AppointmentForm
{
    public partial class VIEWAppointment : Form
    {
        public VIEWAppointment()
        {
            InitializeComponent();
        }

        private void btnSearchAppointment_Click(object sender, EventArgs e)
        {
            pnlSearchAppointment.Visible = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlSearchAppointment.Visible = false;
        }

        private void tbAppointmentID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;

                if (int.TryParse(tbAppointmentID.Text, out int appID))
                {
                    HMSDataContext db = new HMSDataContext();

                    var app = db.appointments.FirstOrDefault(p => p.appointmentID == appID);

                    if (app == null)
                    {
                        MessageBox.Show("Appointment not found.", "No appointment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FormHelpers.ClearFormControls(this);
                        return;
                    }

                    // setting all the textboxes with the relevat ID

                    DateTime appTime = app.appointmentDate.Add(app.appointmentTime);

                    tbPatientID.Text = app.patient_ID.ToString();
                    tbDoctorID.Text = app.doctor_ID.ToString();
                    dtpAppDate.Value = app.appointmentDate;
                    dtpAppTime.Value = appTime;
                    tbReason.Text = app.reason;
                    tbCreatedOn.Text = app.createdOn.ToString();
                    
                }
                else
                {
                    MessageBox.Show("Please enter a valid numeric ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    FormHelpers.ClearFormControls(this);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string nameParam = string.IsNullOrWhiteSpace(tbSearchPatientName.Text) ? null : tbSearchPatientName.Text;
            string phoneParam = string.IsNullOrWhiteSpace(tbSearchPatientPhone.Text) ? null : tbSearchPatientPhone.Text;

            if (nameParam == null && phoneParam == null)
            {
                MessageBox.Show("Please enter something to search", "Empty fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            HMSDataContext db = new HMSDataContext();

            var result = db.searchAppWithPatient(nameParam, phoneParam).ToList();

            if (result.Any())
            {
                dgvSearchList.DataSource = result;
                this.Width = 816; this.Height = 680;
            }
            else
            {
                MessageBox.Show("No appointments found", "No appointment", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Width = 816; this.Height = 486;
        }
    }
}
