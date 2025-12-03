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

namespace HMS_Solution.Forms.AppointmentForm
{
    public partial class DELETEAppointment : Form
    {
        public DELETEAppointment()
        {
            InitializeComponent();
        }

        private void btnCancelMain_Click(object sender, EventArgs e)
        {
            FormHelpers.ClearFormControls(this);
        }

        private void btnSearchAppointmentID_Click(object sender, EventArgs e)
        {
            pnlDeleteAppointment.Visible = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlDeleteAppointment.Visible = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(tbAppointmentID.Text))
            {
                MessageBox.Show("Please enter appointment ID", "No ID given", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                int check = AppointmentService.validateDeleteApp(tbAppointmentID.Text);
                if (check > 0)
                {
                    MessageBox.Show("Appointment deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormHelpers.ClearFormControls(this);
                }
                else
                {
                    MessageBox.Show("Failed to delete appointment", "Unknown error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string nameParam = string.IsNullOrWhiteSpace(tbSearchPatientName.Text) ? null : tbSearchPatientName.Text;
            string phoneParam = string.IsNullOrWhiteSpace(tbSearchPatientPhone.Text) ? null : tbSearchPatientPhone.Text;

            if(nameParam == null && phoneParam == null)
            {
                MessageBox.Show("Please enter something to search", "Empty fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            HMSDataContext db = new HMSDataContext();

            var result = db.searchAppWithPatient(nameParam, phoneParam).ToList();

            if (result.Any())
            {
                dgvSearchResult.DataSource = result;
                this.Width = 815; this.Height = 420;
            }
            else
            {
                MessageBox.Show("No appointments found", "No appointment", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Width = 371; this.Height = 218;
        }
    }
}
