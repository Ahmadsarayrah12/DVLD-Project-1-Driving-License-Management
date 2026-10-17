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
            // عرض اسم المستخدم الحالي المسجل دخوله في النظام
            if (clsGlobal.CurrentUser != null)
            {
                lblUserName.Text = clsGlobal.CurrentUser.UserName;
            }
        }

        // فتح شاشة إدارة الأشخاص
        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManagePeople managePeople = new frmManagePeople();
            managePeople.ShowDialog();
        }

        // فتح شاشة إدارة المستخدمين
        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageUser users = new frmManageUser();
            users.ShowDialog();
        }

        // عرض تفاصيل المستخدم الحالي
        private void currentUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsGlobal.CurrentUser != null)
            {
                frmUserInfo frm = new frmUserInfo(clsGlobal.CurrentUser.UserID);
                frm.ShowDialog();
            }
        }

        // تغيير كلمة المرور للمستخدم الحالي
        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsGlobal.CurrentUser != null)
            {
                frmChangePassword frm = new frmChangePassword(clsGlobal.CurrentUser.UserID);
                frm.ShowDialog();
            }
        }

        // تسجيل الخروج والعودة لشاشة الدخول
        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsGlobal.CurrentUser = null;
            this.Close();
        }

        // زر إغلاق التطبيق
        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
