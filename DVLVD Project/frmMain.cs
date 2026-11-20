using System;
using System.Windows.Forms;

namespace DVLVD_Project
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            clsModernUI.ApplyModernTitleBar(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (clsGlobal.CurrentUser != null)
            {
                lblUserName.Text = clsGlobal.CurrentUser.UserName;
            }
        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManagePeople frm = new frmManagePeople();
            frm.ShowDialog();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageUser frm = new frmManageUser();
            frm.ShowDialog();
        }

        private void currentUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsGlobal.CurrentUser != null)
            {
                frmUserInfo frm = new frmUserInfo(clsGlobal.CurrentUser.UserID);
                frm.ShowDialog();
            }
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsGlobal.CurrentUser != null)
            {
                frmChangePassword frm = new frmChangePassword(clsGlobal.CurrentUser.UserID);
                frm.ShowDialog();
            }
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsGlobal.CurrentUser = null;
            this.Close();
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void manageApplicationTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageApplicationTypes frm = new frmManageApplicationTypes();
            frm.ShowDialog();
        }

        private void manageTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageTestTypes frm = new frmManageTestTypes();
            frm.ShowDialog();
        }

        private void applicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
