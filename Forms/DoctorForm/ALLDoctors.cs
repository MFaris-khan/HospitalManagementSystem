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
    public partial class ALLDoctors : Form
    {
        public ALLDoctors()
        {
            InitializeComponent();
        }

        private void btnSearchMain_Click(object sender, EventArgs e)
        {
            pnlAllDoctors.Visible = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlAllDoctors.Visible = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string nameParam = string.IsNullOrWhiteSpace(tbSearchDoctorName.Text) ? null : tbSearchDoctorName.Text;
            string specParam = string.IsNullOrWhiteSpace(tbSearchDoctorSpecialization.Text) ? null : tbSearchDoctorSpecialization.Text;

            if (nameParam == null && specParam == null)
            {
                MessageBox.Show("Please enter something to search", "Empty fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            HMSDataContext db = new HMSDataContext();
            var result = db.searchDoctorsWithDetails(nameParam, specParam).Select(x => new { ID = x.doctorID, Name = x.name, Gender = x.gender, Specialization = x.specialization, Qualification = x.qualification, ShiftTime = x.shiftTime, Phone = x.phone}).ToList();
            if (result.Any())
            {
                dataGridView1.DataSource = result;
            }
            else
            {
                MessageBox.Show("No doctor found", "No doctor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ALLDoctors_Load(object sender, EventArgs e)
        {
            HMSDataContext db = new HMSDataContext();
            var result = db.viewAllDoctors().Select(x => new { ID = x.doctorID, Name = x.name, Gender = x.gender, Specialization = x.specialization, Qualification = x.qualification, ShiftTime = x.shiftTime, Phone = x.phone }).ToList();
            dataGridView1.DataSource = result;
        }
    }
}
