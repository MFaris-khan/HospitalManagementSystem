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
    public partial class ALLServices : Form
    {
        public ALLServices()
        {
            InitializeComponent();
        }

        private void ALLServices_Load(object sender, EventArgs e)
        {
            try
            {
                var result = BillingService.validateAllServices();

                dgvAllServices.DataSource = result;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
