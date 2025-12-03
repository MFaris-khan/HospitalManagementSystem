using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS_Solution.Forms.UserForm
{
    public partial class VIEWUsers : Form
    {
        public VIEWUsers()
        {
            InitializeComponent();
        }

        private void btnSearchUserID_Click(object sender, EventArgs e)
        {
            pnlViewUser.Visible = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlViewUser.Visible = false;
        }

        private void tbUserID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;

                this.Width = 816; this.Height = 489; // This will close if already opened search list

                HMSDataContext db = new HMSDataContext();

                try
                {
                    if (int.TryParse(tbUserID.Text, out int ID))
                    {
                        var result = db.users.FirstOrDefault(x => x.userID == ID);

                        if (result != null)
                        {
                            tbUName.Text = result.name;
                            tbUsername.Text = result.username;
                            tbPassword.Text = result.password;
                            cbRole.Text = result.role;
                            tbEmail.Text = result.email;
                            tbPhone.Text = result.phone;
                            tbCreatedOn.Text = result.createdON.ToString();
                            if (result.status == "non active")
                            {
                                rbNonActive.Checked = true;
                            }
                            else
                            {
                                rbActive.Checked = true;
                            }
                        }
                        else
                        {
                            MessageBox.Show("No user found. Please check ID", "No user", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter valid integer ID", "Enter valid ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Width = 816; this.Height = 489;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string nameParam = string.IsNullOrWhiteSpace(tbSearchUName.Text) ? null : tbSearchUName.Text;
            string usernameParam = string.IsNullOrWhiteSpace(tbSearchUsername.Text) ? null : tbSearchUsername.Text;


            if (nameParam == null && usernameParam == null)
            {
                MessageBox.Show("Please enter something so search", "Empty fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            HMSDataContext db = new HMSDataContext();
            var data = db.searchUsersWithDetails(nameParam, usernameParam).ToList();
            var result = data.Select(x => new { UserID = x.userID, Name = x.name, Username = x.username, Role = x.role }).ToList();

            if (result.Any())
            {
                this.Width = 816; this.Height = 680;
                dgvSearchResult.DataSource = result;
            }
            else
            {
                MessageBox.Show("No user found", "No user", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
