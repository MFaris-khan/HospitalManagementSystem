using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS_Solution.Forms
{
    public partial class UpdateLicense : Form
    {
        public UpdateLicense()
        {
            InitializeComponent();
        }

        private void btnUpdateLIcense_Click(object sender, EventArgs e)
        {
            string Licensekey = "AllahisThegreatest"; // Main License key

            string Input = tbLicenseKey.Text; // User input license key
            
            if (string.IsNullOrWhiteSpace(Input))
            {
                MessageBox.Show("Please enter license key.", "Empty fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string alpha = Input.Substring(0, Input.Length - 1); // Getting only the alphabetical part with the main license

            int months = 0;

            

            if ( ! int.TryParse(Input[Input.Length - 1].ToString(), out months))
            {
                MessageBox.Show("Error in license key","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(alpha == Licensekey)
            {
                HMSDataContext db = new HMSDataContext();
                var license = db.licenses.FirstOrDefault();

                if (license == null)
                {
                    MessageBox.Show("No license found. Unknown error", "Unknown error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }

                license.updated = DateTime.Now.AddMonths(months);

                db.SubmitChanges();
                
                MessageBox.Show("License updated successfully. Restart the application to continue.","License Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Wrong license key. Please Enter correct license key", "Wrong license", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
