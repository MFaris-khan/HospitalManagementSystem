using HMS_Solution.BLL;
using HMS_Solution.DAL;
using MigraDoc;
using MigraDoc.DocumentObjectModel;
using MigraDoc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HMS_Solution.Forms.BillForm
{
    public partial class VIEWBill : Form
    {
        public VIEWBill()
        {
            InitializeComponent();
        }

        private void btnSearchBillID_Click(object sender, EventArgs e)
        {
            pnlSearchPatientID.Visible = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlSearchPatientID.Visible = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            FormHelpers.ClearFormControls(this);
            lbID.Items.Clear();
            lbCost.Items.Clear();
            lbSelectedServices.Items.Clear();
            lbQty.Items.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Height = 489;
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
                dgvSearchList.DataSource = result;
                this.Width = 816; this.Height = 680;
            }
            else
            {
                MessageBox.Show("No bills found", "No bills", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbBillID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                this.Width = 816; this.Height = 489;

                lbID.Items.Clear();
                lbSelectedServices.Items.Clear();
                lbCost.Items.Clear();
                lbQty.Items.Clear();

                try
                {
                    bill resultBill = BillingService.validateViewBill(tbBillID.Text);
                    tbPatientID.Text = resultBill.patientID.ToString();
                    tbPatientName.Text = resultBill.patient.name.ToString();
                    tbTotal.Text = resultBill.amount.ToString();
                    cbPaymentMethod.Text = resultBill.paymentMethod.ToString();
                    cbStatus.Text = resultBill.status.ToString();
                    tbBillDate.Text = resultBill.billDate.ToString();
                    tbReceivedAmount.Text = resultBill.paid.ToString();
                    tbPending.Text = resultBill.remaining.ToString();

                    var list = BillingService.ValidateGetDetailedBill(tbBillID.Text);
                    
                    if(list.Count > 0)
                    {
                        foreach (var row in list)
                        {
                            lbID.Items.Add(row.serviceID);
                            lbSelectedServices.Items.Add(row.serviceName);
                            lbCost.Items.Add(row.cost);
                            lbQty.Items.Add(row.qty);
                        }
                    }
                    else
                    {
                        lbID.Items.Clear();
                        lbSelectedServices.Items.Clear();
                        lbCost.Items.Clear();
                        lbQty.Items.Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    FormHelpers.ClearFormControls(this);
                }
            }
        }

        private void btnPayOpenPNL_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbBillID.Text))
            {
                MessageBox.Show("Please enter bill ID to pay installments", "Empty bill", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                int result = BillingService.validateInstallment(tbBillID.Text, tbInstAmount.Text, tbPending.Text);

                if (result > 0)
                {
                    MessageBox.Show("Installment has been paid!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormHelpers.ClearFormControls(this);
                    lbID.Items.Clear();
                    lbSelectedServices.Items.Clear();
                    lbCost.Items.Clear();
                    lbQty.Items.Clear();
                }
                else
                {
                    MessageBox.Show("Unknow error occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                List<installmentHistoryResult> resultHistory = BillingService.validateInstHistory(tbBillID.Text);

                if (resultHistory.Count <= 0)
                {
                    MessageBox.Show("No installments history for this bill", "No history", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var final = resultHistory.Select(x => new { Installment_ID = x.instID, Bill_ID = x.billID, Payment_Date = x.instDate, Amount = x.amount }).ToList();

                this.Width = 816; this.Height = 680;
                dgvSearchList.DataSource = final;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GenerateBillPdf()
        {
            if (string.IsNullOrWhiteSpace(tbBillID.Text))
            {
                MessageBox.Show("Please enter bill ID to generate PDF Bill", "Enter Bill ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var doc = new MigraDoc.DocumentObjectModel.Document();

            // Set default style
            var normal = doc.Styles["Normal"];
            normal.Font.Name = "Arial";
            normal.Font.Size = 11;

            var section = doc.AddSection();

            // Clinic Header
            var clinicTitle = section.AddParagraph("");// Add clinic Name here
            clinicTitle.Format.Font.Size = 18;
            clinicTitle.Format.Font.Bold = true;
            clinicTitle.Format.Alignment = MigraDoc.DocumentObjectModel.ParagraphAlignment.Center;
            clinicTitle.Format.SpaceAfter = "0.2cm";

            var clinicAddress = section.AddParagraph("");// Add address and contact here
            clinicAddress.Format.Font.Size = 10;
            clinicAddress.Format.Alignment = MigraDoc.DocumentObjectModel.ParagraphAlignment.Center;
            clinicAddress.Format.SpaceAfter = "0.5cm";

            // Bill Title
            var title = section.AddParagraph("Bill Details");
            title.Format.Font.Size = 16;
            title.Format.Font.Bold = true;
            title.Format.Alignment = MigraDoc.DocumentObjectModel.ParagraphAlignment.Center;
            title.Format.SpaceAfter = "1cm";

            // Patient Info Table
            var patientTable = section.AddTable();
            patientTable.AddColumn(Unit.FromCentimeter(4));
            patientTable.AddColumn(Unit.FromCentimeter(8));

            var row1 = patientTable.AddRow();
            row1.Cells[0].AddParagraph("Patient ID:");
            row1.Cells[1].AddParagraph(tbPatientID.Text);

            var row2 = patientTable.AddRow();
            row2.Cells[0].AddParagraph("Patient Name:");
            row2.Cells[1].AddParagraph(tbPatientName.Text);

            var row3 = patientTable.AddRow();
            row3.Cells[0].AddParagraph("Bill Date:");
            row3.Cells[1].AddParagraph(tbBillDate.Text);

            var row4 = patientTable.AddRow();
            row4.Cells[0].AddParagraph("Payment Method:");
            row4.Cells[1].AddParagraph(cbPaymentMethod.Text);

            var row5 = patientTable.AddRow();
            row5.Cells[0].AddParagraph("Status:");
            row5.Cells[1].AddParagraph(cbStatus.Text);

            section.AddParagraph("\n");

            // Services Table
            var table = section.AddTable();
            table.Borders.Width = 0.75;
            table.AddColumn(Unit.FromCentimeter(3)); // ID
            table.AddColumn(Unit.FromCentimeter(6)); // Service
            table.AddColumn(Unit.FromCentimeter(3)); // Cost
            table.AddColumn(Unit.FromCentimeter(2)); // Qty
            table.AddColumn(Unit.FromCentimeter(3)); // Total

            // Header row
            var header = table.AddRow();
            header.Shading.Color = Colors.LightGray;
            header.Format.Font.Bold = true;
            header.Cells[0].AddParagraph("Service ID");
            header.Cells[1].AddParagraph("Service Name");
            header.Cells[2].AddParagraph("Cost");
            header.Cells[3].AddParagraph("Qty");
            header.Cells[4].AddParagraph("Total");

            // Add services
            decimal grandTotal = 0;
            for (int i = 0; i < lbID.Items.Count; i++)
            {
                var row = table.AddRow();
                row.Cells[0].AddParagraph(lbID.Items[i].ToString());
                row.Cells[1].AddParagraph(lbSelectedServices.Items[i].ToString());

                decimal cost = decimal.Parse(lbCost.Items[i].ToString());
                int qty = int.Parse(lbQty.Items[i].ToString());
                decimal total = cost * qty;
                grandTotal += total;

                row.Cells[2].AddParagraph(cost.ToString("0.00"));
                row.Cells[3].AddParagraph(qty.ToString());
                row.Cells[4].AddParagraph(total.ToString("0.00"));

                // Align numbers to right
                row.Cells[2].Format.Alignment = MigraDoc.DocumentObjectModel.ParagraphAlignment.Right;
                row.Cells[3].Format.Alignment = MigraDoc.DocumentObjectModel.ParagraphAlignment.Center;
                row.Cells[4].Format.Alignment = MigraDoc.DocumentObjectModel.ParagraphAlignment.Right;
            }

            section.AddParagraph("\n");

            // Totals
            var totalsTable = section.AddTable();
            totalsTable.AddColumn(Unit.FromCentimeter(9));
            totalsTable.AddColumn(Unit.FromCentimeter(5));

            var totalRow1 = totalsTable.AddRow();
            totalRow1.Cells[0].AddParagraph("Total Amount:");
            totalRow1.Cells[1].AddParagraph(tbTotal.Text);
            totalRow1.Cells[1].Format.Alignment = ParagraphAlignment.Right;

            var totalRow2 = totalsTable.AddRow();
            totalRow2.Cells[0].AddParagraph("Received Amount:");
            totalRow2.Cells[1].AddParagraph(tbReceivedAmount.Text);
            totalRow2.Cells[1].Format.Alignment = ParagraphAlignment.Right;

            var totalRow3 = totalsTable.AddRow();
            totalRow3.Cells[0].AddParagraph("Pending Amount:");
            totalRow3.Cells[1].AddParagraph(tbPending.Text);
            totalRow3.Cells[1].Format.Alignment = ParagraphAlignment.Right;

            section.AddParagraph("\n");

            // Footer
            var footer = section.Footers.Primary.AddParagraph("");// any additional footer
            footer.Format.Font.Size = 10;
            footer.Format.Alignment = ParagraphAlignment.Center;

            // Render PDF
            var renderer = new PdfDocumentRenderer
            {
                Document = doc
            };
            renderer.RenderDocument();

            string path = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                $"Bill_{tbPatientID.Text}_{tbPatientName.Text}_{DateTime.Now:yyyyMMddHHmmss}.pdf"
            );
            renderer.PdfDocument.Save(path);

            MessageBox.Show($"PDF saved at:\n{path}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            GenerateBillPdf();
        }
    }
}
