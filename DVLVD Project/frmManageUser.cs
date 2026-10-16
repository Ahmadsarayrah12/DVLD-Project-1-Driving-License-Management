using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLVD_Project
{
    public partial class frmManageUser : Form
    {
        public frmManageUser()
        {
            InitializeComponent();
            clsModernUI.ApplyModernTitleBar(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveUser_Click(object sender, EventArgs e)
        {
            frmAddEditUser frm = new frmAddEditUser();
            frm.ShowDialog();
        }
    }
}
