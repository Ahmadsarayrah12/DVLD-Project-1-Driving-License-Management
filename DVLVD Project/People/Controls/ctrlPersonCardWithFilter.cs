using System;
using System.Windows.Forms;
using LibraryProject.BussinessLogic;

namespace DVLVD_Project.UserControls
{
    public partial class ctrlPersonCardWithFilter : UserControl
    {
 
        public event Action<int> OnPersonSelected;

        public ctrlPersonCardWithFilter()
        {
            InitializeComponent();
        }

    
        public int PersonID
        {
            get { return ctrlPersonCard1.PersonID; }
        }
         



        public clsPerson SelectedPersonInfo
        {
            get { return ctrlPersonCard1.SelectedPersonInfo; }
        }

        private void ctrlPersonCardWithFilter_Load(object sender, EventArgs e)
        {
            cbFilterBy.SelectedIndex = 0; 
            txtFilterValue.Focus();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
    
            if (string.IsNullOrEmpty(txtFilterValue.Text.Trim()))
            {
                MessageBox.Show("Please enter a value to search for!", "Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            if (cbFilterBy.Text == "Person ID")
            {
                int personID;
                if (int.TryParse(txtFilterValue.Text, out personID))
                {
                    ctrlPersonCard1.LoadPersonInfo(personID);
                }
                else
                {
                    MessageBox.Show("Please enter a valid number for Person ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
         
            else if (cbFilterBy.Text == "National No.")
            {
             
                clsPerson person = clsPerson.Find(txtFilterValue.Text.Trim());
                if (person != null)
                {
                   
                    ctrlPersonCard1.LoadPersonInfo(person.PersonID);
                }
                else
                {
                    MessageBox.Show("No person found with this National No.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ctrlPersonCard1.ResetPersonInfo();
                }
            }

         
            if (OnPersonSelected != null && ctrlPersonCard1.PersonID != -1)
            {
                OnPersonSelected(ctrlPersonCard1.PersonID);
            }
        }

       

        

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            frmAddEditPerson frm = new frmAddEditPerson();

            DialogResult result = frm.ShowDialog();

            
            if (result == DialogResult.OK && frm._PersonID != -1)
            {
                cbFilterBy.SelectedIndex = 0;
                txtFilterValue.Text = frm._PersonID.ToString();

                ctrlPersonCard1.LoadPersonInfo(frm._PersonID);
            }
        }

    }


}
