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
    public partial class ALLBills : Form
    {
        public ALLBills()
        {
            InitializeComponent();
        }

        private void ALLBills_Load(object sender, EventArgs e)
        {
            var result = BillingService.callViewAllBills();

            if(result!=null)
            {
                dgvAllBills.DataSource = result;
            }
            else
            {
                MessageBox.Show("No bills to show", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void btnSearchMain_Click(object sender, EventArgs e)
        {
            pnlAllPatients.Visible = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string nameParam = string.IsNullOrWhiteSpace(tbSearchPatientName.Text) ? null : tbSearchPatientName.Text;
            string phoneParam = string.IsNullOrWhiteSpace(tbSearchPatientPhone.Text) ? null : tbSearchPatientPhone.Text;

            if (nameParam == null && phoneParam == null)
            {
                MessageBox.Show("Please enter something to search", "Empty fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            HMSDataContext db = new HMSDataContext();

            var result = db.searchBillWithPatient(nameParam, phoneParam).ToList();

            if (result.Any())
            {
                dgvAllBills.DataSource = result;
            }
            else
            {
                MessageBox.Show("No bills found", "No bills", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlAllPatients.Visible = false; 
        }
    }
}
