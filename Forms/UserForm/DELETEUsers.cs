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

namespace HMS_Solution.Forms.UserForm
{
    public partial class DELETEUsers : Form
    {
        public DELETEUsers()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Width = 371; this.Height = 218;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlDeleteUser.Visible = false;
        }

        private void btnSearchUserID_Click(object sender, EventArgs e)
        {
            pnlDeleteUser.Visible = true;
        }

        private void btnCancelMain_Click(object sender, EventArgs e)
        {
            FormHelpers.ClearFormControls(this);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int result = UserService.validateDeleteUser(tbUserID.Text);
                if (result > 0)
                {
                    MessageBox.Show("User deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormHelpers.ClearFormControls(this);
                }
                else if (result == -1)
                {
                    MessageBox.Show("User cannot be deleted. Foriegn key violation.", "Another relation exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Unknown error occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                this.Width = 815; this.Height = 420;
                dgvSearchResult.DataSource = result;
            }
            else
            {
                MessageBox.Show("No user found", "No user", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
