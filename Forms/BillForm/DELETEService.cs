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
    public partial class DELETEService : Form
    {
        public DELETEService()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Width = 371; this.Height = 218;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                var result = BillingService.validateSearchServiceName(tbSearchServiceName.Text);

                if(result.Count > 0)
                {
                    dgvSearchResult.DataSource = result;
                    this.Width = 815; this.Height = 420;
                }
                else
                {
                    MessageBox.Show("No services found", "Mo services", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCancelMain_Click(object sender, EventArgs e)
        {
            FormHelpers.ClearFormControls(this);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlDeleteAppointment.Visible = false;
        }

        private void btnSearchServiceID_Click(object sender, EventArgs e)
        {
            pnlDeleteAppointment.Visible = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int result = BillingService.validateDeleteService(tbServiceID.Text);

                if (result > 0)
                {
                    MessageBox.Show("Service deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Service cannot be deleted", "Cannot delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
