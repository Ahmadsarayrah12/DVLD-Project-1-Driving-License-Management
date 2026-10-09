using System;
using System.Drawing;
using System.Windows.Forms;
using LibraryProject.BussinessLogic;
using System.Data.SqlClient;

namespace DVLVD_Project
{
    public partial class frmAddEditPerson : Form
    {
        private ErrorProvider errorProvider1 = new ErrorProvider();
        
        public enum enMode { AddNew=1, Update=2 }
        private enMode _Mode;

        private int _PersonID;
        private clsPerson _Person;
        private bool _IsSaved = false;

               
        
        private void Input_Changed(object sender, EventArgs e)
        {
            btnSavePerson.Enabled = true;
        }

        public frmAddEditPerson()
        {
            InitializeComponent();
            clsModernUI.ApplyModernTitleBar(this);
            _Mode = enMode.AddNew;
        }
        
        private void _LoadData()
        {
            _Person = clsPerson.Find(_PersonID);

            if (_Person == null)
            {
                MessageBox.Show("No Person with ID = " + _PersonID, "Person Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }

            lblPersonID.Text = _Person.PersonID.ToString();
            tbNationalNumber.Text = _Person.NationalNo;
            tbFirstName.Text = _Person.FirstName;
            tbSecondName.Text = _Person.SecondName;
            tbThirdName.Text = _Person.ThirdName;
            tbLastName.Text = _Person.LastName;
            tbPhone.Text = _Person.Phone;
            tbEmail.Text = _Person.Email;
            tbAddress.Text = _Person.Address;
            dtpDateOfBirth.Value = _Person.DateOfBirth;
            cbCountry.SelectedValue = _Person.NationalityCountryID;

            if (_Person.Gender == clsPerson.enGender.Male)
                rbMale.Checked = true;
            else
                rbFemale.Checked = true;

            if (!string.IsNullOrEmpty(_Person.ImagePath))
            {
                pbPersonImage.ImageLocation = _Person.ImagePath;
                RemoveImage.Visible = true;
            }
            else
            {
                _ResetDefaultAvatar();
            }
        }

        private void FormSetting()
        {
            if (_Mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New Person";
                _Person = new clsPerson();
                return;
            }

            lblTitle.Text = "Update Person";
            _LoadData();
        }

        public frmAddEditPerson(int Person)
        {
            InitializeComponent();
            clsModernUI.ApplyModernTitleBar(this);
            _Mode = enMode.Update;
            _PersonID = Person;
        }


       
        private void _ResetDefaultAvatar()
        {
            if (rbFemale.Checked)
                pbPersonImage.Image = Properties.Resources.Female_Avatar1;
            else
                pbPersonImage.Image = Properties.Resources.Male_Avatar;

             RemoveImage.Visible = false;
        }

        
        private void _ChooseAndSetImage()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif|All files (*.*)|*.*";
                openFileDialog.Title = "Choose a profile picture or a system image.";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pbPersonImage.SizeMode = PictureBoxSizeMode.Zoom;
                    pbPersonImage.ImageLocation = openFileDialog.FileName;
                    RemoveImage.Visible = true;
                btnSavePerson.Enabled = true;
            }
            }
        }

        private void frmAddEditPerson_Load(object sender, EventArgs e)
        {
            pbPersonImage.SizeMode = PictureBoxSizeMode.Zoom;

            if (string.IsNullOrEmpty(pbPersonImage.ImageLocation))
            {
                _ResetDefaultAvatar();
            }
            else
            {
                RemoveImage.Visible = true;
            }
            _FillCountriesInComboBox();
            FormSetting();
            tbNationalNumber.TextChanged += Input_Changed;
            tbFirstName.TextChanged += Input_Changed;
            tbSecondName.TextChanged += Input_Changed;
            tbThirdName.TextChanged += Input_Changed;
            tbLastName.TextChanged += Input_Changed;
            tbPhone.TextChanged += Input_Changed;
            tbEmail.TextChanged += Input_Changed;
            tbAddress.TextChanged += Input_Changed;
            dtpDateOfBirth.ValueChanged += Input_Changed;
            cbCountry.SelectedIndexChanged += Input_Changed;
            rbMale.CheckedChanged += Input_Changed;
            rbFemale.CheckedChanged += Input_Changed;

            tbNationalNumber.Focus();
        }


        private void rbMale_CheckedChanged_1(object sender, EventArgs e)
        {
           
            if (rbMale.Checked && string.IsNullOrEmpty(pbPersonImage.ImageLocation))
            {
                pbPersonImage.Image = Properties.Resources.Male_Avatar;
            }
        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            
            if (rbFemale.Checked && string.IsNullOrEmpty(pbPersonImage.ImageLocation))
            {
                pbPersonImage.Image = Properties.Resources.Female_Avatar1;
            }
        }

        private void btnSetImage_Click(object sender, EventArgs e)
        {
            _ChooseAndSetImage();
        }

        private void pbAddUpdateImage_Click(object sender, EventArgs e)
        {
            _ChooseAndSetImage();
        }

        private void RemoveImage_Click(object sender, EventArgs e)
        {
            pbPersonImage.ImageLocation = null;
            _ResetDefaultAvatar();
            btnSavePerson.Enabled = true;
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            this.Close();
        }

 

     
        private void tbPhone_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                System.Media.SystemSounds.Beep.Play();
                errorProvider1.SetError(tbPhone, "Just Number please!");
            }
            else
            {
                errorProvider1.SetError(tbPhone, null);
            }
        }

        private void tbEmail_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

            string email = tbEmail.Text.Trim();


            if (string.IsNullOrEmpty(email))
            {
                errorProvider1.SetError(tbEmail, null);
                return;
            }


            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            if (!System.Text.RegularExpressions.Regex.IsMatch(email, pattern))
            {
                e.Cancel = true;
                System.Media.SystemSounds.Beep.Play();
                errorProvider1.SetError(tbEmail, "Invalid Email format! Example: name@example.com");
            }
            else
            {
                errorProvider1.SetError(tbEmail, null);
            }



        }
        private void _FillCountriesInComboBox()
        {
            System.Data.DataTable dtCountries = clsCountry.GetAllCountries();
            cbCountry.DataSource = dtCountries;
            cbCountry.DisplayMember = "CountryName";
            cbCountry.ValueMember = "CountryID";
            
            int jordanIndex = cbCountry.FindString("Jordan");
            if (jordanIndex >= 0)
                cbCountry.SelectedIndex = jordanIndex;
            else if (cbCountry.Items.Count > 0)
                cbCountry.SelectedIndex = 0;
        }

        private void tbNationalNumber_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (tbNationalNumber.Text.Trim() != _Person.NationalNo && clsPerson.isPersonExist(tbNationalNumber.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbNationalNumber, "National Number is used by another person!");
            }
            else
            {
                errorProvider1.SetError(tbNationalNumber, null);
            }
        }

        private void tbLastName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(tb.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(tb, "This field is required!");
            }
            else
            {
                errorProvider1.SetError(tb, null);
            }
        }


        private void btnSavePerson_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fields are not valid! Please check the red error icons.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _Person.NationalNo = tbNationalNumber.Text.Trim();
            _Person.FirstName = tbFirstName.Text.Trim();
            _Person.SecondName = tbSecondName.Text.Trim();
            _Person.ThirdName = tbThirdName.Text.Trim();
            _Person.LastName = tbLastName.Text.Trim();
            _Person.DateOfBirth = dtpDateOfBirth.Value.Date;
            _Person.Address = tbAddress.Text.Trim();
            _Person.Phone = tbPhone.Text.Trim();
            _Person.Email = tbEmail.Text.Trim();


            _Person.Gender = rbMale.Checked ? clsPerson.enGender.Male : clsPerson.enGender.Female;

            if (cbCountry.SelectedValue != null)
                _Person.NationalityCountryID = (int)cbCountry.SelectedValue;

            _Person.ImagePath = pbPersonImage.ImageLocation ?? string.Empty;

            if (_Person.Save())
            {
                MessageBox.Show("Person saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblPersonID.Text = _Person.PersonID.ToString();
                _IsSaved = true;
                btnSavePerson.Enabled = false;
            }
            else
            {
                MessageBox.Show("Save failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

                private void btnResetAndAddNew_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to reset the form?", "Confirm Reset", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            if (_Mode == enMode.Update)
            {
                _LoadData();
                errorProvider1.Clear();
                tbNationalNumber.Focus();
            }
            else
            {
                lblPersonID.Text = "N/A";
                tbNationalNumber.Text = string.Empty;
                tbFirstName.Text = string.Empty;
                tbSecondName.Text = string.Empty;
                tbThirdName.Text = string.Empty;
                tbLastName.Text = string.Empty;
                tbPhone.Text = string.Empty;
                tbEmail.Text = string.Empty;
                tbAddress.Text = string.Empty;
                
                dtpDateOfBirth.Value = DateTime.Now.AddYears(-18).Date;
                
                rbMale.Checked = true;
                
                pbPersonImage.ImageLocation = null;
                _ResetDefaultAvatar();
                
                _IsSaved = false;
                btnSavePerson.Enabled = true;

                errorProvider1.Clear();
                tbNationalNumber.Focus();
            }
        }
    }
}















