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

namespace HMS_Solution
{
    public partial class ADDBill : Form
    {
        public ADDBill()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(tbPatientID.Text) || cbPaymentMethod.SelectedIndex < 0 || cbStatus.SelectedIndex < 0 || string.IsNullOrWhiteSpace(tbServiceID.Text) || string.IsNullOrWhiteSpace(tbReceivedAmount.Text))
            {
                MessageBox.Show("All fields are required to create a bill, except quantity which defaults to 1.", "Empty fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                int ID = BillingService.validateAddBill(tbPatientID.Text, tbTotal.Text, cbPaymentMethod.Text, cbStatus.Text, tbReceivedAmount.Text);

                if (ID > 0)
                {
                    // Insert into detailed bill here before showing the bill ID
                    
                    for(int i=0; i<lbID.Items.Count; i++)
                    {
                        string servID = lbID.Items[i].ToString();
                        string servName = lbSelectedServices.Items[i].ToString();
                        string QTY = lbQty.Items[i].ToString();
                        string cost = lbCost.Items[i].ToString();

                        // call from here insert Into detail bill

                        try
                        {
                            int result = BillingService.validateAddDetailedBill(ID, servID, servName, cost, QTY);
                            
                            if( ! (result > 0) )
                            {
                                MessageBox.Show("Error inserting detailed bill", "Error detailed bill", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }


                    }

                    MessageBox.Show($"Bill created with ID: {ID}", "Bill Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormHelpers.ClearFormControls(this);
                    lbID.Items.Clear();
                    lbQty.Items.Clear();
                    lbSelectedServices.Items.Clear();
                }
                else
                {
                    MessageBox.Show("Bill not created", "Unknown error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            decimal Total = decimal.Parse(tbTotal.Text.ToString());

            int.TryParse(tbServiceID.Text, out int servID);

            HMSDataContext db = new HMSDataContext();

            var result = db.services.FirstOrDefault(x => x.serviceID == servID);

            lbSelectedServices.Items.Add(result.serviceName);

            lbID.Items.Add(result.serviceID);

            lbCost.Items.Add(result.serviceAmount);


            int QTY = 1;

            if( ! string.IsNullOrWhiteSpace(tbQty.Text))
            {
                if( ! int.TryParse(tbQty.Text, out QTY))
                {
                    MessageBox.Show("Please enter valid quantity", "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            
            lbQty.Items.Add(QTY);

            decimal total =  decimal.Parse(result.serviceAmount.ToString());

            tbTotal.Text = (Total + (total * QTY)).ToString();

            tbQty.Text = string.Empty;

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            FormHelpers.ClearFormControls(this);
            lbID.Items.Clear();
            lbQty.Items.Clear();
            lbSelectedServices.Items.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Width = 816; this.Height = 489;
        }

        private void btnSearchPatientID_Click(object sender, EventArgs e)
        {
            pnlSearchPatientID.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pnlSearchServiceName.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnlSearchServiceName.Visible=false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlSearchPatientID.Visible=false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var result = BillingService.validateSearchServiceName(tbSearchServiceName.Text);
                if(result.Count > 0)
                {
                    this.Height = 680;
                    dgvSearchList.DataSource = result;
                }
                else
                {
                    MessageBox.Show("No services found", "No service", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                dgvSearchList.DataSource = finalResult;
                this.Width = 816; this.Height = 680;
            }
            else
            {
                MessageBox.Show("No patient found", "No patient", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
