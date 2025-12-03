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
    public partial class DELETEPatient : Form
    {
        public DELETEPatient()
        {
            InitializeComponent();
        }

        private void btnSearchPatientID_Click(object sender, EventArgs e)
        {
            pnlDeletePatient.Visible = true;
        }

        private void btnCancelMain_Click(object sender, EventArgs e)
        {
            tbPatientID.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult yesORno = MessageBox.Show("Are you sure you want to delete patient?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (yesORno == DialogResult.Yes)
            {
                try
                {
                    int result = PatientService.validatePatientID(tbPatientID.Text);
                    if (result > 0)
                    {
                        MessageBox.Show("Patient deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FormHelpers.ClearFormControls(this);
                    }
                    else if (result == 0)
                    {
                        MessageBox.Show("No patient found", "No patient", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (result == -1)
                    {
                        MessageBox.Show("Patient with appointment cannot be deleted", "Foriegn key violation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                tbPatientID.Clear();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            tbSearchPatientName.Text = string.Empty;
            tbSearchPatientPhone.Text = string.Empty;
            pnlDeletePatient.Visible = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(tbSearchPatientName.Text) && string.IsNullOrWhiteSpace(tbSearchPatientPhone.Text))
            {
                MessageBox.Show("Please enter something to search", "Empty fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            List<searchPatientsWithDetailsResult> result = PatientService.validateSearchDetails(tbSearchPatientName.Text, tbSearchPatientPhone.Text);

            if (result.Any())
            {
                var SearchResult = result.Select(x => new { ID = x.patientID, Name = x.name, Gender = x.gender, DOB = x.dateOfBirth, Phone = x.phone } ).ToList();
                dgvSearchResult.DataSource = SearchResult;
                this.Width = 815; this.Height = 420;
            }
            else
            {
                MessageBox.Show("No patients found", "No patients", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Width = 371; this.Height = 218;
        }
    }
}
