using System;
using System.Windows.Forms;
using LibraryProject.BussinessLogic;

namespace DVLVD_Project
{
    public partial class frmChangePassword : Form
    {
        // رقم المستخدم وكائن المستخدم
        private int _UserID = -1;
        private clsUser _User;

        // مُنشئ يستقبل رقم المستخدم
        public frmChangePassword(int UserID)
        {
            InitializeComponent();
            clsModernUI.ApplyModernTitleBar(this);

            _UserID = UserID;
        }

        // عند فتح الشاشة، نقوم بتحميل بيانات المستخدم
        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            _LoadUserInfo();
        }

        // دالة تحميل وعرض بيانات المستخدم في الكرت
        private void _LoadUserInfo()
        {
            _User = clsUser.FindByUserID(_UserID);

            if (_User == null)
            {
                MessageBox.Show("User not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            ctrlUserCard1.LoadUserInfo(_UserID);
        }

        // زر الإغلاق
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // زر الحفظ لتغيير كلمة المرور
        private void btnSave_Click(object sender, EventArgs e)
        {
            // 1. التأكد من إدخال كلمة المرور الحالية
            if (string.IsNullOrWhiteSpace(txtCurrentPassword.Text))
            {
                MessageBox.Show("Please enter the current password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCurrentPassword.Focus();
                return;
            }

            // 2. التحقق من مطابقة كلمة المرور الحالية لكلمة المرور الفعلية للمستخدم
            if (txtCurrentPassword.Text.Trim() != _User.Password)
            {
                MessageBox.Show("Current password is incorrect!", "Wrong Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCurrentPassword.Focus();
                return;
            }

            // 3. التأكد من إدخال كلمة المرور الجديدة
            if (string.IsNullOrWhiteSpace(txtNewPassword.Text))
            {
                MessageBox.Show("Please enter the new password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNewPassword.Focus();
                return;
            }

            // 4. التأكد من تطابق كلمة المرور الجديدة مع خانة التأكيد
            if (txtNewPassword.Text.Trim() != txtConfirmPassword.Text.Trim())
            {
                MessageBox.Show("New password and confirm password do not match!", "Password Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtConfirmPassword.Focus();
                return;
            }

            // 5. حفظ كلمة المرور الجديدة في قاعدة البيانات
            if (_User.ChangePassword(txtNewPassword.Text.Trim()))
            {
                MessageBox.Show("Password changed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to change password. An error occurred.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
