using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace DVLVD_Project
{
    public partial class frmManagePeople : Form
    {
        public frmManagePeople()
        {
            InitializeComponent();
        }

        private void frmManagePeople_Load(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
          frmAddEditPerson frmAddEditPerson = new frmAddEditPerson();
            frmAddEditPerson.ShowDialog();

        
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
    
        }

        private void btnFindPerson_Click(object sender, EventArgs e)
        {
         
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}