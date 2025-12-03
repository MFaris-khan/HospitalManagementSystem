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

namespace HMS_Solution.Forms.AppointmentForm
{
    public partial class SearchByAppointment : Form
    {
        public SearchByAppointment()
        {
            InitializeComponent();
        }

        private void btnSingle_Click(object sender, EventArgs e)
        {
            if(dtpSingle.Value == null)
            {
                MessageBox.Show("Please select a valid date", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                List<viewAppointmentSingleResult> result = AppointmentService.validateViewAppointmentSingle(dtpSingle.Value);
                if (result.Count <= 0)
                {
                    MessageBox.Show($"No appointments found for: {dtpSingle.Value:dd-MM-yyyy}", "No appointments", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                dgvFilterAppointments.DataSource = result;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRange_Click(object sender, EventArgs e)
        {
            if (dtpFrom.Value == null || dtpTill.Value == null)
            {
                MessageBox.Show("Please select a valid range", "Invalid range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                List<viewAppointmentRangeResult> result = AppointmentService.validateAppointmentRange(dtpFrom.Value.Date, dtpTill.Value.Date);
                if (result.Count <= 0)
                {
                    MessageBox.Show($"No appointments found for range: {dtpFrom.Value:dd-MM-yyyy} - {dtpTill.Value:dd-MM-yyyy}", "No appointments", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                dgvFilterAppointments.DataSource = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
