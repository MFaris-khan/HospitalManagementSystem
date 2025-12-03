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
    public partial class ALLAppointments : Form
    {
        public ALLAppointments()
        {
            InitializeComponent();
        }

        private void btnSearchMain_Click(object sender, EventArgs e)
        {
            pnlAllAppointments.Visible = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlAllAppointments.Visible = false;
        }

        private void ALLAppointments_Load(object sender, EventArgs e)
        {
            HMSDataContext db = new HMSDataContext();
            var result = db.viewAllAppointments().ToList();
            if(result.Any())
            {
                dgvAllAppointments.DataSource = result;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string nameParam = string.IsNullOrWhiteSpace(tbSearchPatientName.Text) ? null : tbSearchPatientName.Text;
            string phoneParam = string.IsNullOrWhiteSpace(tbSearchPatientPhone.Text) ? null : tbSearchPatientPhone.Text;

            HMSDataContext db = new HMSDataContext();

            
            var result = db.searchAppWithPatient(nameParam, phoneParam).ToList();

            if (result.Any())
            {
                pnlAllAppointments.Visible = false;

                dgvAllAppointments.DataSource = result;
            }
            else
            {
                MessageBox.Show("Unable to find appointment with provided details", "No appointment found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
