using System;
using System.Windows.Forms;
using LibraryProject.BussinessLogic;

namespace DVLVD_Project.UserControls
{
    public partial class ctrlUserCard : UserControl
    {
        private clsUser _User;
        private int _UserID = -1;

        public int UserID
        {
            get { return _UserID; }
        }

        public clsUser SelectedUserInfo
        {
            get { return _User; }
        }

        public ctrlUserCard()
        {
            InitializeComponent();
        }

        public void LoadUserInfo(int UserID)
        {
            _User = clsUser.FindByUserID(UserID);

            if (_User == null)
            {
                ResetUserInfo();
                MessageBox.Show("No User with UserID = " + UserID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillUserInfo();
        }

        private void _FillUserInfo()
        {
            _UserID = _User.UserID;
            ctrlPersonCard1.LoadPersonInfo(_User.PersonID);
            lblUserID.Text = _User.UserID.ToString();
            lblUserName.Text = _User.UserName;
            lblIsActive.Text = _User.IsActive ? "Yes" : "No";
        }

        public void ResetUserInfo()
        {
            _UserID = -1;
            _User = null;
            ctrlPersonCard1.ResetPersonInfo();
            lblUserID.Text = "[????]";
            lblUserName.Text = "[????]";
            lblIsActive.Text = "[????]";
        }
    }
}
