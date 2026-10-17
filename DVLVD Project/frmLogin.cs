using System;
using System.Windows.Forms;
using LibraryProject.BussinessLogic;

namespace DVLVD_Project
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            clsModernUI.ApplyModernTitleBar(this);
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            //(Remember Me)
            string username = "";
            string password = "";

            if (clsGlobal.GetStoredCredential(ref username, ref password))
            {
                txtUserName.Text = username;
                txtPassword.Text = password;
                chkRememberMe.Checked = true;
            }
            else
            {
                chkRememberMe.Checked = false;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
   
            if (string.IsNullOrWhiteSpace(txtUserName.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please enter both Username and Password.", "Wrong Credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

           
            clsUser user = clsUser.FindByUsernameAndPassword(txtUserName.Text.Trim(), txtPassword.Text.Trim());

            if (user == null)
            {
                MessageBox.Show("Invalid Username / Password.", "Wrong Credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserName.Focus();
                return;
            }

          
            if (!user.IsActive)
            {
                MessageBox.Show("Your account is not active, please contact your admin.", "In Active Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

          
            if (chkRememberMe.Checked)
            {
                clsGlobal.RememberUsernameAndPassword(txtUserName.Text.Trim(), txtPassword.Text.Trim());
            }
            else
            {
                clsGlobal.RememberUsernameAndPassword("", "");
            }

           
            clsGlobal.CurrentUser = user;

         
            this.Hide();
            frmMain mainForm = new frmMain();
            mainForm.ShowDialog();

           
            this.Show();
            txtPassword.Text = "";
            txtUserName.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
