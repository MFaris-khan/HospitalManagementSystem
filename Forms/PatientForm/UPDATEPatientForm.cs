using HMS_Solution.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS_Solution.Forms.PatientForm
{
    public partial class UPDATEPatientForm : Form
    {
        public UPDATEPatientForm()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e) // This will clearn all the textboxes and other controls in the form
        {
            FormHelpers.ClearFormControls(this);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbPatientName.Text) || string.IsNullOrWhiteSpace(tbPhone.Text) || cbGender.SelectedIndex == -1 || dtpDateOfBirth.Value == DateTime.Today)
            {
                MessageBox.Show("These fields are required to enter a patient \n1. Patient Name \n2. Gender \n3. Date of birth \n4. Phone", "Required fields are empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                // check is the actual value which is returned from the database @@rowcount
                int check = PatientService.ValidateUpdatePatient(tbPatientID.Text, tbPatientName.Text, cbGender.Text.ToLower(), dtpDateOfBirth.Value, tbPhone.Text, cb1.Checked, cb2.Checked, cb3.Checked, cb4.Checked, cb5.Checked, cb6.Checked, cb7.Checked, cb8.Checked, cb9.Checked, cb10.Checked, tbEmail.Text, tbAddress.Text, cbBloodGroup.Text, tbMedicalHistory.Text, tbAllergies.Text, tbEmergencyName.Text, tbEmergencyPhone.Text);

                if (check > 0)
                {
                    MessageBox.Show("Patient updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormHelpers.ClearFormControls(this);
                }
                else
                {
                    MessageBox.Show("No patient found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    FormHelpers.ClearFormControls(this);
                }
            }
            catch(Exception ex) // in case if any error happens
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FormHelpers.ClearFormControls(this);
            }

        }

        private void btnSearchPatientID_Click(object sender, EventArgs e)
        {
            pnlUpdatePatient.Visible = true; // this will open a panel to search patient by name or phone
            tbSearchPatientName.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlUpdatePatient.Visible = false; // this will hide the panel 
        }

        private void tbPatientID_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar == (char)Keys.Enter) // Check if the pressed key is the Enter key.
            {
                e.Handled = true; // Prevent the 'ding' sound on enter press.

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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            HMSDataContext db = new HMSDataContext();

            string nameParam = string.IsNullOrWhiteSpace(tbSearchPatientName.Text) ? null : tbSearchPatientName.Text;
            string phoneParam = string.IsNullOrWhiteSpace(tbSearchPatientPhone.Text) ? null : tbSearchPatientPhone.Text;
            
            if(string.IsNullOrWhiteSpace(nameParam) && string.IsNullOrWhiteSpace(phoneParam))
            {
                MessageBox.Show("Please enter something to search", "Empty fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var rawResult = db.searchPatientsWithDetails(nameParam, phoneParam).ToList();
            
            if(rawResult.Any())
            {
                var finalResult = rawResult.Select(x => new { ID = x.patientID, Name = x.name, x.gender, x.dateOfBirth, x.phone } ).ToList();
                dgvSearchResult.DataSource = finalResult;
                this.Width = 816; this.Height = 680;
            }
            else
            {
                MessageBox.Show("No patient found", "No patient", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Width = 816; this.Height = 489; // This will close the search result list
        }

        private void btnAttachFile_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbPatientID.Text))
            {
                MessageBox.Show("Please select a patient first.", "Select patient", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            int patientID = int.Parse(tbPatientID.Text);

            OpenFileDialog ofd = new OpenFileDialog
            {
                Title = "Select files to attach",
                Filter = "All Files|*.*",
                Multiselect = true
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string mainFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "HMS", "Patients");
                if (!Directory.Exists(mainFolder))
                    Directory.CreateDirectory(mainFolder);

                string patientFolder = Path.Combine(mainFolder, $"Patient_{patientID}");
                if (!Directory.Exists(patientFolder))
                    Directory.CreateDirectory(patientFolder);

                foreach (string file in ofd.FileNames)
                {
                    string fileName = Path.GetFileName(file);
                    string destPath = Path.Combine(patientFolder, fileName);

                    File.Copy(file, destPath, true);

                    
                    using (SqlConnection conn = new SqlConnection(DatabaseHelper.GetConnectionString()))
                    {
                        conn.Open();
                        string query = $"EXEC insertPatientFilePath {patientID}, '{fileName.Replace("'", "''")}', '{destPath.Replace("'", "''")}'";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Files attached successfully!", "Files attached", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        

    }
}
}
    

