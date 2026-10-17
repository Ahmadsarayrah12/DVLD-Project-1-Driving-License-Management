using System;
using System.Windows.Forms;

namespace DVLVD_Project
{
    public partial class frmUserInfo : Form
    {
        private int _UserID = -1;

        public frmUserInfo(int UserID)
        {
            InitializeComponent();
            clsModernUI.ApplyModernTitleBar(this);
            _UserID = UserID;
        }

        private void frmUserInfo_Load(object sender, EventArgs e)
        {
            ctrlUserCard1.LoadUserInfo(_UserID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
