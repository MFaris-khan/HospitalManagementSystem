using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace HMS_Solution.Forms.PatientForm
{
    public partial class VIEWPatient : Form
    {
        public VIEWPatient()
        {
            InitializeComponent();
        }

        private void tbPatientID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // Prevent the 'ding' sound on enter press
                this.Width = 816; this.Height = 489;

                if (int.TryParse(tbPatientID.Text, out int patientId))
                {
                    HMSDataContext db = new HMSDataContext();

                    var patient = db.patients.FirstOrDefault(p => p.patientID == patientId);

                    if (patient == null)
                    {
                        MessageBox.Show("Patient not found.", "No patient", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FormHelpers.ClearFormControls(this);
                        return;
                    }

                    // setting all the textboxes with the relevat ID

                    tbPatientName.Text = patient.name;
                    cbGender.Text = patient.gender;
                    dtpDateOfBirth.Value = patient.dateOfBirth;
                    tbPhone.Text = patient.phone;
                    tbEmail.Text = patient.email;
                    tbAddress.Text = patient.address;
                    dtpRegistration.Value = (DateTime)patient.dateOfRegistration;
                    tbEmergencyName.Text = patient.emergemcyContactName;
                    tbEmergencyPhone.Text = patient.emergemcyContactNumber;
                    cbBloodGroup.Text = patient.bloodGroup;
                    tbAllergies.Text = patient.allergies;
                    tbMedicalHistory.Text = patient.medicalHistory;
                    cb1.Checked = (bool)patient.cb1;
                    cb2.Checked = (bool)patient.cb2;
                    cb3.Checked = (bool)patient.cb3;
                    cb4.Checked = (bool)patient.cb4;
                    cb5.Checked = (bool)patient.cb5;
                    cb6.Checked = (bool)patient.cb6;
                    cb7.Checked = (bool)patient.cb7;
                    cb8.Checked = (bool)patient.cb8;
                    cb9.Checked = (bool)patient.cb9;
                    cb10.Checked = (bool)patient.cb10;
                }
                else
                {
                    MessageBox.Show("Please enter a valid numeric ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    FormHelpers.ClearFormControls(this);
                }
            }

        }

        private void btnSearchPatientID_Click(object sender, EventArgs e)
        {
            pnlViewPatient.Visible = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        { 
            HMSDataContext db = new HMSDataContext();

            string nameParam = string.IsNullOrWhiteSpace(tbSearchPatientName.Text) ? null : tbSearchPatientName.Text;
            string phoneParam = string.IsNullOrWhiteSpace(tbSearchPatientPhone.Text) ? null : tbSearchPatientPhone.Text;

            if (string.IsNullOrWhiteSpace(nameParam) && string.IsNullOrWhiteSpace(phoneParam))
            {
                MessageBox.Show("Please enter something to search", "Empty fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var rawResult = db.searchPatientsWithDetails(nameParam, phoneParam).ToList();

            if (rawResult.Any())
            {
                var finalResult = rawResult.Select(x => new { ID = x.patientID, Name = x.name, x.gender, x.dateOfBirth, x.phone }).ToList();
                dgvSearchResult.DataSource = finalResult;
                this.Width = 816; this.Height = 680;
            }
            else
            {
                MessageBox.Show("No patient found", "No patient", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlViewPatient.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Width = 816; this.Height = 489; // This will close the search result list
        }

        private void btnViewFiles_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbPatientID.Text))
            {
                MessageBox.Show("Please select a patient first.", "Select patient", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.Width = 816; this.Height = 680;
            int patientID = int.Parse(tbPatientID.Text);
            LoadAttachedFiles(patientID);
        }

        private void LoadAttachedFiles(int patientID)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseHelper.GetConnectionString()))
            {
                conn.Open();
                string query = $"SELECT fileID, fileName, filePath, uploadedOn FROM PatientFiles WHERE patientID = {patientID} ORDER BY uploadedOn DESC";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                System.Data.DataTable dt = new System.Data.DataTable();
                da.Fill(dt);
                dgvSearchResult.DataSource = dt;
            }
        }

        private void dgvSearchResult_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string path = dgvSearchResult.Rows[e.RowIndex].Cells["filePath"].Value.ToString();
                if (File.Exists(path))
                    System.Diagnostics.Process.Start(path);

            }
        }
    }
}
