using HMS_Solution.Forms;
using HMS_Solution.Forms.BillForm;
using HMS_Solution.Forms.LoginForm;
using PdfSharp.Quality;
using System;
using System.Windows.Forms;

namespace HMS_Solution
{
    internal static class Program
    {
        static bool CheckLicense()
        {
            try
            {
                HMSDataContext db = new HMSDataContext();
                int? days = db.checkLicense();

                if (days > 30)
                {
                    DialogResult result = MessageBox.Show(
                        "Your license is expired. Please renew your license to continue. Want to renew?",
                        "License expired",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Exclamation
                    );

                    if (result == DialogResult.Yes)
                    {
                        UpdateLicense ul = new UpdateLicense();
                        ul.ShowDialog(); // handle license update
                    }

                    return false;
                }
                else if (days == -1 || days == null)
                {
                    license l = new license
                    {
                        updated = DateTime.Today
                    };
                    db.licenses.InsertOnSubmit(l);
                    db.SubmitChanges();
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "License check failed:\n" + ex.Message,
                    "HMS Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return false;
            }
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Initialize database
            try
            {
                DatabaseHelper.InitializeDatabase();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Database initialization failed:\n" + ex.Message +
                    "\n\nPlease ensure SQL Server LocalDB is installed and accessible.",
                    "HMS Setup Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return; 
            }

            //  License check
            if (!CheckLicense())
                return; // exit app if license fails

            // Show login form
            LoginForm loginForm = new LoginForm();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                PdfSharp.Fonts.GlobalFontSettings.FontResolver = new SimpleFontResolver();
                Application.Run(new MainForm());
            }
        }
    }
}
