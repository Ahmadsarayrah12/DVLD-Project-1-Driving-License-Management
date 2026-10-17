using System;
using System.Windows.Forms;
using LibraryProject.BussinessLogic;

namespace DVLVD_Project
{
    public partial class frmAddEditUser : Form
    {
        public enum enMode { AddNew = 0, Update = 1 }
        private enMode _Mode = enMode.AddNew;

        private int _UserID = -1;
        private clsUser _User;

        public frmAddEditUser()
        {
            InitializeComponent();
            clsModernUI.ApplyModernTitleBar(this);

            _Mode = enMode.AddNew;
        }

        public frmAddEditUser(int UserID)
        {
            InitializeComponent();
            clsModernUI.ApplyModernTitleBar(this);

            _Mode = enMode.Update;
            _UserID = UserID;
        }

        private void _LoadData()
        {
            if (_Mode == enMode.AddNew)
            {
                label1.Text = "Add New User";
                _User = new clsUser();
                tcUserInfo.Enabled = false;
                return;
            }

            label1.Text = "Update User";
            _User = clsUser.FindByUserID(_UserID);

            if (_User == null)
            {
                MessageBox.Show("No User with ID = " + _UserID, "User Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }

            ctrlPersonCardWithFilter1.LoadPersonInfo(_User.PersonID);
            ctrlPersonCardWithFilter1.FilterEnabled = false;

            lblDataUser.Text = "User ID: " + _User.UserID.ToString();
            textBox1.Text = _User.UserName;
            textBox2.Text = _User.Password;
            textBox3.Text = _User.Password;
            IsActive.Checked = _User.IsActive;
        }

        private void frmAddEditUser_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (_Mode == enMode.Update)
            {
                tcUserInfo.Enabled = true;
                tcAddUpdateUser.SelectedIndex = 1;
                return;
            }

            int personID = ctrlPersonCardWithFilter1.PersonID;

            if (personID == -1)
            {
                MessageBox.Show("Please select a person first.", "Select a Person", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (clsUser.IsUserExistForPersonID(personID))
            {
                MessageBox.Show("Selected Person already has a user, choose another one.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            tcUserInfo.Enabled = true;
            tcAddUpdateUser.SelectedIndex = 1;

            string fullName = ctrlPersonCardWithFilter1.SelectedPersonInfo != null
                ? ctrlPersonCardWithFilter1.SelectedPersonInfo.FullName
                : "";

            lblDataUser.Text = "Name: " + fullName + "\nID: " + personID;
            textBox1.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ctrlPersonCardWithFilter1.PersonID == -1)
            {
                MessageBox.Show("The Person Details is empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Username cannot be blank.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string enteredUsername = textBox1.Text.Trim();
            if ((_Mode == enMode.AddNew || _User.UserName.ToLower() != enteredUsername.ToLower())
                && clsUser.IsUserExist(enteredUsername))
            {
                MessageBox.Show("Username is already used by another user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Password cannot be blank.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (textBox2.Text != textBox3.Text)
            {
                MessageBox.Show("Password confirmation does not match Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _User.PersonID = ctrlPersonCardWithFilter1.PersonID;
            _User.UserName = enteredUsername;
            _User.Password = textBox2.Text.Trim();
            _User.IsActive = IsActive.Checked;

            if (_User.Save())
            {
                lblDataUser.Text = "User ID: " + _User.UserID.ToString();
                _Mode = enMode.Update;
                label1.Text = "Update User";
                ctrlPersonCardWithFilter1.FilterEnabled = false;

                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error: Data was not saved successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ctrlPersonCardWithFilter1_Load(object sender, EventArgs e)
        {
        }
    }
}
