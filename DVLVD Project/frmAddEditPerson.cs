using System;
using System.Drawing;
using System.Windows.Forms;

namespace DVLVD_Project
{
    public partial class frmAddEditPerson : Form
    {
        private ErrorProvider errorProvider1 = new ErrorProvider();
        public frmAddEditPerson()
        {
            InitializeComponent();
        }


         private void _ResetDefaultAvatar()
        {
            if (rbFemale.Checked)
                pbAvatar.Image = Properties.Resources.Female_Avatar1;
            else
                pbAvatar.Image = Properties.Resources.Male_Avatar;

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
                    pbAvatar.SizeMode = PictureBoxSizeMode.Zoom;
                    pbAvatar.ImageLocation = openFileDialog.FileName;
                    RemoveImage.Visible = true;
                }
            }
        }

        private void frmAddEditPerson_Load(object sender, EventArgs e)
        {
            pbAvatar.SizeMode = PictureBoxSizeMode.Zoom;

             if (string.IsNullOrEmpty(pbAvatar.ImageLocation))
            {
                _ResetDefaultAvatar();
            }
            else
            {
                RemoveImage.Visible = true;
            }
            _FillCountriesInComboBox();
        }

        private void rbMale_CheckedChanged_1(object sender, EventArgs e)
        {
             if (rbMale.Checked && string.IsNullOrEmpty(pbAvatar.ImageLocation))
            {
                pbAvatar.Image = Properties.Resources.Male_Avatar;
            }
        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
             if (rbFemale.Checked && string.IsNullOrEmpty(pbAvatar.ImageLocation))
            {
                pbAvatar.Image = Properties.Resources.Female_Avatar1;
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
            pbAvatar.ImageLocation = null;
            _ResetDefaultAvatar();
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            this.Close();
        }

 

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblAddUpdatePerson_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpDateOfBirth_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tbNationalNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void pbAvatar_Click(object sender, EventArgs e)
        {

        }

        private void tbLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPersonID_Click(object sender, EventArgs e)
        {

        }

        private void tbPhone_TextChanged(object sender, EventArgs e)
        {
           
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
            // cbCountry.DataSource = clsCountry.GetAllCountries();
            // cbCountry.DisplayMember = "CountryName";

            cbCountry.Items.AddRange(new string[] { "Jordan", "Syria", "Palestine", "Lebanon", "Egypt", "Saudi Arabia" });
            cbCountry.SelectedIndex = 0;
        }

        private void dtpDateOfBirth_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if(  (DateTime.Now.Year -dtpDateOfBirth.Value.Year  )<18)
            {
                e.Cancel= true;
                errorProvider1.SetError(dtpDateOfBirth, "Person must be 18 years or older!");
                MessageBox.Show("Person must be 18 years or older!", "Eror", MessageBoxButtons.OK);
            }
            else
            {
                errorProvider1.SetError(dtpDateOfBirth, null);
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbFirstName.Text) || !string.IsNullOrWhiteSpace(tbNationalNumber.Text))
            {
                if (MessageBox.Show("Are you sure you want to cancel? Any unsaved changes will be lost.",
                                    "Confirm",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;  
                }
            }

            this.Close();
        }
    }
}