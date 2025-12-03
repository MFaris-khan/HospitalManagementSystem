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
    public partial class ADDUserForm : Form
    {
        public ADDUserForm()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            FormHelpers.ClearFormControls(this);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                int result = UserService.validateAddUser(tbUName.Text, tbUsername.Text, tbPassword.Text, tbConfirmPassword.Text, cbRole.Text.ToLower(), tbEmail.Text, tbPhone.Text, rbNonActive.Checked); // if return value is -1 it means username is already in DB else userID will be returned

                if(result > 0)
                {
                    MessageBox.Show($"User created with ID: {result}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormHelpers.ClearFormControls(this);
                }
                else if(result == -1)
                {
                    MessageBox.Show($"A user with username \"{tbUsername.Text}\" already exists", "Duplicate username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Unknown error. User not created", "Unknown Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
