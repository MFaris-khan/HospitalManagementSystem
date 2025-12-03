using HMS_Solution.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS_Solution.Forms.BillForm
{
    public partial class UPDATEService : Form
    {
        public UPDATEService()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            FormHelpers.ClearFormControls(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Width = 816; this.Height = 489;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                var result = BillingService.validateSearchServiceName(tbSearchServiceName.Text);

                if (result.Count > 0 )
                {
                    dgvSearchList.DataSource = result;
                    this.Width = 816; this.Height = 680;
                }
                else
                {
                    MessageBox.Show("No services found", "No services", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(tbServiceID.Text) || string.IsNullOrWhiteSpace(tbServiceName.Text) || string.IsNullOrWhiteSpace(tbServiceAmount.Text))
            {
                MessageBox.Show("All fileds are required to update service", "Empty fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                int result = BillingService.validateUpdateService(tbServiceID.Text, tbServiceName.Text, tbServiceAmount.Text);

                if(result > 0)
                {
                    MessageBox.Show("Service updated successfully", "Service updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormHelpers.ClearFormControls(this);
                }
                else
                {
                    MessageBox.Show("Service cannot be updated", "Cannot update", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearchServiceID_Click(object sender, EventArgs e)
        {
            pnlSearchService.Visible = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlSearchService.Visible = false;
        }

        private void tbServiceID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) // Check if the pressed key is the Enter key.
            {
                e.Handled = true; // Prevent the 'ding' sound on enter press.

                this.Width = 816; this.Height = 489;

                var result = BillingService.validateSearchServiveWithID(tbServiceID.Text);

                if(result != null)
                {
                    tbServiceName.Text = result.serviceName.ToString();
                    tbServiceAmount.Text = result.serviceAmount.ToString();
                }
                else
                {
                    MessageBox.Show($"No services found with ID: {tbServiceID.Text}", "No services", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    FormHelpers.ClearFormControls(this);
                }
            }
        }
    }
}
