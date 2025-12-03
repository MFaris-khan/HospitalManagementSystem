using HMS_Solution.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS_Solution.Forms.AppointmentForm
{
    public partial class UPDATEAppointment : Form
    {
        public UPDATEAppointment()
        {
            InitializeComponent();
        }

        private void btnSearchAppointment_Click(object sender, EventArgs e)
        {
            pnlUpdateAppointment.Visible = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlUpdateAppointment.Visible = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            FormHelpers.ClearFormControls(this);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Width = 816; this.Height = 486;
        }

        private void tbAppointmentID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                
                this.Width = 816; this.Height = 489;

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
            
            if(result.Any())
            {
                dgvSearchList.DataSource = result;
                this.Width = 816; this.Height = 680;
            }
            else
            {
                MessageBox.Show("No appointments found", "No appointment", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void UPDATEAppointment_Load(object sender, EventArgs e)
        {
            tbAppointmentID.Focus();
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbAppointmentID.Text))
            {
                MessageBox.Show("Appointment ID is required to update an appointment", "Empty fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                int ID = AppointmentService.validateUpdateAppointment(tbAppointmentID.Text, tbPatientID.Text, tbDoctorID.Text, dtpAppDate.Value, dtpAppTime.Value, tbReason.Text);
               
                if (ID > 0)
                {
                    MessageBox.Show("Appointment details updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormHelpers.ClearFormControls(this);
                }
                else
                {
                    MessageBox.Show("Appointment details could not be updated", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FormHelpers.ClearFormControls(this);
            }
        }
        
    }
}
