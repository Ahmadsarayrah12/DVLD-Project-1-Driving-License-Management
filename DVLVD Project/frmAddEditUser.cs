using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLVD_Project.UserControls;
using LibraryProject.BussinessLogic;

namespace DVLVD_Project
{
    public partial class frmAddEditUser : Form
    {

        public int PersnID { get; private set; }
        public string Name { get; private set; }
        
        

        public frmAddEditUser()
        {
            InitializeComponent();
            clsModernUI.ApplyModernTitleBar(this);
        }

        private void frmAddEditUser_Load(object sender, EventArgs e)
        {
             
        }



        private void ctrlPersonCardWithFilter1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            PersnID= ctrlPersonCardWithFilter1.PersonID;

            string FullName= ctrlPersonCardWithFilter1.SelectedPersonInfo.FullName;
 
            if (PersnID == -1)
            {
                MessageBox.Show("Please select a person first.", "Select a Person", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
                 
            }

            if (!clsUser.IsUserExistForPersonID(PersnID))
            {

              tcAddUpdateUser.SelectedIndex = 1;

                lblDataUser.Text = "Name: " + FullName + "\nID: " + PersnID;

            }
            else
            {
                 MessageBox.Show(
                "Selected Person already has a user, choose another one.",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error );
       
                return; 
            }



        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(ctrlPersonCardWithFilter1.SelectedPersonInfo ==null)
            {

              MessageBox.Show(
              "The Person Details is empty.",
              "Error",
              MessageBoxButtons.OK,
              MessageBoxIcon.Error);
               return;

            }


        }

    }
}
