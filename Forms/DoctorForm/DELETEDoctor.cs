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
    public partial class DELETEDoctor : Form
    {
        public DELETEDoctor()
        {
            InitializeComponent();
        }

        private void btnSearchDoctorID_Click(object sender, EventArgs e)
        {
            pnlDeleteDoctor.Visible = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlDeleteDoctor.Visible = false;
        }

        private void btnCancelMain_Click(object sender, EventArgs e)
        {
            FormHelpers.ClearFormControls(this);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(tbDoctorID.Text))
            {
                MessageBox.Show("Please enter doctor ID", "Enter ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                int deleted = DoctorService.validateDeleteDcotor(tbDoctorID.Text);

                if(deleted > 0)
                {
                    MessageBox.Show("Doctor deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No doctor found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            HMSDataContext db = new HMSDataContext();

            string nameParam = string.IsNullOrWhiteSpace(tbSearchDoctorName.Text) ? null : tbSearchDoctorName.Text;
            string specParam = string.IsNullOrWhiteSpace(tbSearchDoctorSpecialization.Text) ? null : tbSearchDoctorSpecialization.Text;
            
            if(string.IsNullOrWhiteSpace(nameParam) && string.IsNullOrWhiteSpace(specParam))
            {
                MessageBox.Show("Please enter something to search", "Empty fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var rawResult = db.searchDoctorsWithDetails(nameParam, specParam).ToList();

            if (rawResult.Any())
            {
                var finalResult = rawResult.Select(x => new { ID = x.doctorID, Name = x.name, x.gender, x.dateOfBirth, x.phone }).ToList();
                dgvSearchResult.DataSource = finalResult;
                this.Width = 815; this.Height = 420;
            }
            else
            {
                MessageBox.Show("No doctor found", "No doctor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Width = 371; this.Height = 218;  
        }
    }
}
