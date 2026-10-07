using System;
using System.Windows.Forms;
using LibraryProject.BussinessLogic;

namespace DVLVD_Project.UserControls
{
    public partial class ctrlPersonCard : UserControl
    {
        private int _PersonID = -1;
        private clsPerson _Person;

        public int PersonID
        {
            get { return _PersonID; }
        }

        public clsPerson SelectedPersonInfo
        {
            get { return _Person; }
        }

        public ctrlPersonCard()
        {
            InitializeComponent();
        }

        public void LoadPersonInfo(int PersonID)
        {
            _Person = clsPerson.Find(PersonID);
            if (_Person == null)
            {
                ResetPersonInfo();
                MessageBox.Show("No Person with PersonID = " + PersonID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _FillPersonInfo();
        }



        private void _LoadPersonImage()
        {
            if (_Person.Gender == 0)
                pbPersonImage.Image = Properties.Resources.Male_Avatar;
            else
                pbPersonImage.Image = Properties.Resources.Female_Avatar1;

            string imagePath = _Person.ImagePath;
            if (imagePath != "")
            {
                if (System.IO.File.Exists(imagePath))
                {
                    pbPersonImage.ImageLocation = imagePath;
                }
                else
                {
                    MessageBox.Show("Could not find this image: = " + imagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void _FillPersonInfo()
        {
            _PersonID = _Person.PersonID;
            lblPersonID.Text = _Person.PersonID.ToString();
            lblNationalNo.Text = _Person.NationalNo;
            lblFullName.Text = _Person.FullName;
            lblGender.Text = _Person.Gender == 0 ? "Male" : "Female";
            lblEmail.Text = _Person.Email;
            lblPhone.Text = _Person.Phone;
            lblAddress.Text = _Person.Address;
            lblDateOfBirth.Text = _Person.DateOfBirth.ToShortDateString();
            
            // Get Country Name
            System.Data.DataTable dtCountries = clsCountry.GetAllCountries();
            System.Data.DataRow[] rows = dtCountries.Select("CountryID = " + _Person.NationalityCountryID);
            if (rows.Length > 0)
                lblCountry.Text = rows[0]["CountryName"].ToString();
            else
                lblCountry.Text = "Unknown";

            _LoadPersonImage();
            llEditPersonInfo.Enabled = true;
        }

        public void ResetPersonInfo()
        {
            _PersonID = -1;
            lblPersonID.Text = "[????]";
            lblNationalNo.Text = "[????]";
            lblFullName.Text = "[????]";
            lblGender.Text = "[????]";
            lblEmail.Text = "[????]";
            lblPhone.Text = "[????]";
            lblAddress.Text = "[????]";
            lblDateOfBirth.Text = "[????]";
            lblCountry.Text = "[????]";
            pbPersonImage.Image = Properties.Resources.Male_Avatar;
            llEditPersonInfo.Enabled = false;
        }

        private void llEditPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddEditPerson frm = new frmAddEditPerson(_PersonID);
            frm.ShowDialog();

            // Refresh data after edit
            LoadPersonInfo(_PersonID);
        }
    }
}
