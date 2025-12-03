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
    public partial class ALLPatients : Form
    {
        public ALLPatients()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlAllPatients.Visible = false;
        }

        private void ALLPatients_Load(object sender, EventArgs e)
        {
            var Result = PatientService.allPatients().Select(x => new { ID = x.patientID, Name = x.name, Gender = x.gender, DateOfBirth = x.dateOfBirth, Phone = x.phone, Email = x.email }).ToList();
            dgvAllPatients.DataSource = Result;
        }

        private void btnSearchMain_Click(object sender, EventArgs e)
        {
            pnlAllPatients.Visible = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var result = PatientService.validateSearchDetails(tbSearchPatientName.Text, tbSearchPatientPhone.Text).Select(x => new { ID = x.patientID, Name = x.name, Gender = x.gender, DateOfBirth = x.dateOfBirth, Phone = x.phone, Email = x.email }).ToList();
            if(result.Any())
            {
                pnlAllPatients.Visible = false;

                dgvAllPatients.DataSource = result;
            }
            else
            {
                MessageBox.Show("Unable to find patient with provided details", "No patient found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
