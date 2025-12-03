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
    public partial class ALLUsers : Form
    {
        public ALLUsers()
        {
            InitializeComponent();
        }

        private void btnSearchMain_Click(object sender, EventArgs e)
        {
            pnlViewUser.Visible = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlViewUser.Visible = false;
        }

        private void ALLUsers_Load(object sender, EventArgs e)
        {
            HMSDataContext db = new HMSDataContext();
            var raw = db.viewAllUsers().ToList();
            var result = raw.Select(x => new { UserUD = x.userID, Name = x.name, Username = x.username, Role = x.role, Status = x.status} ).ToList();

            if(result.Any())
            {
                dataGridView1.DataSource = result;
            }
            else
            {
                MessageBox.Show("No users found", "No users", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                dataGridView1.DataSource = result;
            }
            else
            {
                MessageBox.Show("No user found", "No user", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
