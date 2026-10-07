using System;
using System.Windows.Forms;

namespace DVLVD_Project
{
    public partial class frmShowPersonInfo : Form
    {
        public frmShowPersonInfo(int PersonID)
        {
            InitializeComponent();
            clsModernUI.ApplyModernTitleBar(this);
            ctrlPersonCard1.LoadPersonInfo(PersonID);
        }
}
}




