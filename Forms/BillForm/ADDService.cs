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

namespace HMS_Solution.Forms.BillForm
{
    public partial class ADDService : Form
    {
        public ADDService()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            FormHelpers.ClearFormControls(this);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(tbServiceName.Text) || string.IsNullOrEmpty(tbServiceAmount.Text))
            {
                MessageBox.Show("All fields are required to add a service", "Empty fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                int ID = BillingService.validateAddService(tbServiceName.Text, tbServiceAmount.Text);

                if (ID > 0)
                {
                    MessageBox.Show($"Service added with ID: {ID}", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormHelpers.ClearFormControls(this);
                }
                else
                {
                    MessageBox.Show("Could not add service", "Service not added", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
