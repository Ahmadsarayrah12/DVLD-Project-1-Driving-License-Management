using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using LibraryProject.BussinessLogic;

namespace DVLVD_Project
{
    public partial class frmManagePeople : Form
    {
        private static DataTable _dtAllPeople;

        public frmManagePeople()
        {
            InitializeComponent();
            clsModernUI.ApplyModernTitleBar(this);
        }

        private void _RefreshPeopleList()
        {
            _dtAllPeople = clsPerson.GetAllPeople();
            
            if (!_dtAllPeople.Columns.Contains("FullName"))
                _dtAllPeople.Columns.Add("FullName", typeof(string), "FirstName + ' ' + SecondName + ' ' + ISNULL(ThirdName, '') + ' ' + LastName");
                
            if (!_dtAllPeople.Columns.Contains("GenderText"))
                _dtAllPeople.Columns.Add("GenderText", typeof(string), "IIF(Gender=0, 'Male', 'Female')");

            dataGridView1.DataSource = _dtAllPeople;
            LblPeopleCount.Text = dataGridView1.Rows.Count.ToString();
            
            if (dataGridView1.Columns.Count > 0)
            {
                foreach (DataGridViewColumn c in dataGridView1.Columns)
                    c.Visible = false;

                if (dataGridView1.Columns.Contains("PersonID"))
                {
                    dataGridView1.Columns["PersonID"].Visible = true;
                    dataGridView1.Columns["PersonID"].HeaderText = "Person ID";
                    dataGridView1.Columns["PersonID"].Width = 70;
                    dataGridView1.Columns["PersonID"].DisplayIndex = 0;
                }

                if (dataGridView1.Columns.Contains("NationalNo"))
                {
                    dataGridView1.Columns["NationalNo"].Visible = true;
                    dataGridView1.Columns["NationalNo"].HeaderText = "National No.";
                    dataGridView1.Columns["NationalNo"].Width = 120;
                    dataGridView1.Columns["NationalNo"].DisplayIndex = 1;
                }

                if (dataGridView1.Columns.Contains("FullName"))
                {
                    dataGridView1.Columns["FullName"].Visible = true;
                    dataGridView1.Columns["FullName"].HeaderText = "Full Name";
                    dataGridView1.Columns["FullName"].Width = 300;
                    dataGridView1.Columns["FullName"].DisplayIndex = 2;
                }

                if (dataGridView1.Columns.Contains("DateOfBirth"))
                {
                    dataGridView1.Columns["DateOfBirth"].Visible = true;
                    dataGridView1.Columns["DateOfBirth"].HeaderText = "Date Of Birth";
                    dataGridView1.Columns["DateOfBirth"].Width = 140;
                    dataGridView1.Columns["DateOfBirth"].DisplayIndex = 3;
                    dataGridView1.Columns["DateOfBirth"].DefaultCellStyle.Format = "dd/MM/yyyy";
                }

                if (dataGridView1.Columns.Contains("GenderText"))
                {
                    dataGridView1.Columns["GenderText"].Visible = true;
                    dataGridView1.Columns["GenderText"].HeaderText = "Gender";
                    dataGridView1.Columns["GenderText"].Width = 120;
                    dataGridView1.Columns["GenderText"].DisplayIndex = 4;
                }

                if (dataGridView1.Columns.Contains("Address"))
                {
                    dataGridView1.Columns["Address"].Visible = true;
                    dataGridView1.Columns["Address"].HeaderText = "Address";
                    dataGridView1.Columns["Address"].Width = 150;
                    dataGridView1.Columns["Address"].DisplayIndex = 5;
                }

                if (dataGridView1.Columns.Contains("Phone"))
                {
                    dataGridView1.Columns["Phone"].Visible = true;
                    dataGridView1.Columns["Phone"].HeaderText = "Phone";
                    dataGridView1.Columns["Phone"].Width = 120;
                    dataGridView1.Columns["Phone"].DisplayIndex = 6;
                }

                if (dataGridView1.Columns.Contains("Email"))
                {
                    dataGridView1.Columns["Email"].Visible = true;
                    dataGridView1.Columns["Email"].HeaderText = "Email";
                    dataGridView1.Columns["Email"].Width = 170;
                    dataGridView1.Columns["Email"].DisplayIndex = 7;
                }

                if (dataGridView1.Columns.Contains("CountryName"))
                {
                    dataGridView1.Columns["CountryName"].Visible = true;
                    dataGridView1.Columns["CountryName"].HeaderText = "Nationality";
                    dataGridView1.Columns["CountryName"].Width = 150;
                    dataGridView1.Columns["CountryName"].DisplayIndex = 8;
                }
            }
        }

        private void TsmiDetails_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int personID = (int)dataGridView1.CurrentRow.Cells["PersonID"].Value;
                frmShowPersonInfo frm = new frmShowPersonInfo(personID);
                frm.ShowDialog();
                _RefreshPeopleList();
            }
        }

        private void TsmiAdd_Click(object sender, EventArgs e)
        {
            frmAddEditPerson frm = new frmAddEditPerson();
            frm.ShowDialog();
            _RefreshPeopleList();
        }

        private void TsmiEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int personID = (int)dataGridView1.CurrentRow.Cells["PersonID"].Value;
                frmAddEditPerson frm = new frmAddEditPerson(personID);
                frm.ShowDialog();
                _RefreshPeopleList();
            }
        }

        private void TsmiDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int personID = (int)dataGridView1.CurrentRow.Cells["PersonID"].Value;
                
                if (MessageBox.Show("Are you sure you want to delete Person ID [" + personID + "]?", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    if (clsPerson.DeletePerson(personID))
                    {
                        MessageBox.Show("Person deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _RefreshPeopleList();
                    }
                    else
                    {
                        MessageBox.Show("Could not delete person. It might be linked to other data (e.g. users, drivers, etc).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

                private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("هذه الميزة ستتوفر قريباً (Coming Soon!)", "Coming Soon", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void phoneCallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("هذه الميزة ستتوفر قريباً (Coming Soon!)", "Coming Soon", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmManagePeople_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(new object[] { "None", "Person ID", "National No.", "Full Name", "Nationality", "Gender", "Phone", "Email" });
            if (comboBox1.Items.Count > 0)
                comboBox1.SelectedIndex = 0;
            _RefreshPeopleList();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAddEditPerson frmAddEditPerson = new frmAddEditPerson();
            frmAddEditPerson.ShowDialog();
            _RefreshPeopleList();
        }
private void button1_Click_1(object sender, EventArgs e)
        {
        }

        private void btnFindPerson_Click(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilter.Visible = (comboBox1.Text != "None");

            if (txtFilter.Visible)
            {
                txtFilter.Text = "";
                txtFilter.Focus();
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            switch (comboBox1.Text)
            {
                case "Person ID":
                    FilterColumn = "PersonID";
                    break;
                case "National No.":
                    FilterColumn = "NationalNo";
                    break;
                case "Full Name":
                    FilterColumn = "FullName";
                    break;
                case "Nationality":
                    FilterColumn = "CountryName";
                    break;
                case "Gender":
                    FilterColumn = "GenderText";
                    break;
                case "Phone":
                    FilterColumn = "Phone";
                    break;
                case "Email":
                    FilterColumn = "Email";
                    break;
                default:
                    FilterColumn = "None";
                    break;
            }

            if (txtFilter.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtAllPeople.DefaultView.RowFilter = "";
                LblPeopleCount.Text = dataGridView1.Rows.Count.ToString();
                return;
            }

            if (FilterColumn == "PersonID")
            {
                if (!int.TryParse(txtFilter.Text.Trim(), out int result))
                {
                    _dtAllPeople.DefaultView.RowFilter = "";
                    LblPeopleCount.Text = dataGridView1.Rows.Count.ToString();
                    return;
                }
                _dtAllPeople.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, result);
            }
            else
            {
                _dtAllPeople.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilter.Text.Trim());
            }

            LblPeopleCount.Text = dataGridView1.Rows.Count.ToString();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}







