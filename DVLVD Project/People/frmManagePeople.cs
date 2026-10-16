using System;
using System.Data;
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

            //الاعمدة المحسوبة
            _PrepareDataTableColumns();
            // تعبئة الجدول بالبيانات بواسطة DataSource
            dgvPeopleData.DataSource = _dtAllPeople;


          
            _FormatPeopleGrid();

         
            LblPeopleCount.Text = dgvPeopleData.Rows.Count.ToString();
        }

        private void _PrepareDataTableColumns()
        {


            if (_dtAllPeople == null) return;

            if (!_dtAllPeople.Columns.Contains("FullName"))
                _dtAllPeople.Columns.Add("FullName", typeof(string), "FirstName + ' ' + SecondName + ' ' + ISNULL(ThirdName, '') + ' ' + LastName");

            if (!_dtAllPeople.Columns.Contains("GenderText"))
                _dtAllPeople.Columns.Add("GenderText", typeof(string), "IIF(Gender=0, 'Male', 'Female')");
        }

 
          
        void SetupColumn(string name, string headerText, int width, int displayIndex, string format = null)
        {
               
            if (dgvPeopleData.Columns.Contains(name))  
            {

                var col = dgvPeopleData.Columns[name];
                col.Visible = true;
                col.HeaderText = headerText;
                col.Width = width;
                col.DisplayIndex = displayIndex;
                if (!string.IsNullOrEmpty(format)) 
                    col.DefaultCellStyle.Format = format; 

            }
        }

        private void _FormatPeopleGrid()
        {
            if (dgvPeopleData.Columns.Count == 0) return;

             foreach (DataGridViewColumn c in dgvPeopleData.Columns)
                c.Visible = false;


            SetupColumn("PersonID", "Person ID", 70, 0);
            SetupColumn("NationalNo", "National No.", 120, 1);
            SetupColumn("FullName", "Full Name", 300, 2);
            SetupColumn("DateOfBirth", "Date Of Birth", 140, 3, "dd/MM/yyyy");
            SetupColumn("GenderText", "Gender", 120, 4);
            SetupColumn("Address", "Address", 150, 5);
            SetupColumn("Phone", "Phone", 120, 6);
            SetupColumn("Email", "Email", 170, 7);
            SetupColumn("CountryName", "Nationality", 150, 8);
        }

        private void TsmiDetails_Click(object sender, EventArgs e)
        {
            if (dgvPeopleData.CurrentRow != null)
            {
                int personID = (int)dgvPeopleData.CurrentRow.Cells["PersonID"].Value;
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
            if (dgvPeopleData.CurrentRow != null)
            {
                int personID = (int)dgvPeopleData.CurrentRow.Cells["PersonID"].Value;
                frmAddEditPerson frm = new frmAddEditPerson(personID);
                frm.ShowDialog();
                _RefreshPeopleList();
            }
        }

        private void TsmiDelete_Click(object sender, EventArgs e)
        {
            if (dgvPeopleData.CurrentRow != null)
            {
                int personID = (int)dgvPeopleData.CurrentRow.Cells["PersonID"].Value;
                
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

                
    

        

        private void frmManagePeople_Load(object sender, EventArgs e)
        {
            cbFilter.Items.Clear();
            cbFilter.Items.AddRange(new string [] { "None", "Person ID", "National No.", "Full Name", "Nationality", "Gender", "Phone", "Email" });
            if (cbFilter.Items.Count > 0)
                cbFilter.SelectedIndex = 0;
            _RefreshPeopleList();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void AddPerson_Click(object sender, EventArgs e)
        {
            frmAddEditPerson frmAddEditPerson = new frmAddEditPerson();     
            frmAddEditPerson.ShowDialog();
            _RefreshPeopleList();
        }

 
        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

            txtFilter.Visible = (cbFilter.Text != "None");

            if (txtFilter.Visible)
            {
                txtFilter.Text = "";
                txtFilter.Focus();
            }

        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            switch (cbFilter.Text)
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
                LblPeopleCount.Text = dgvPeopleData.Rows.Count.ToString();
                return;
            }

            if (FilterColumn == "PersonID")
            {
                if (!int.TryParse(txtFilter.Text.Trim(), out int result))
                {
                    _dtAllPeople.DefaultView.RowFilter = "";
                    LblPeopleCount.Text = dgvPeopleData.Rows.Count.ToString();
                    return;
                }
                _dtAllPeople.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, result);
            }
            else
            {
                _dtAllPeople.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilter.Text.Trim());
            }

            LblPeopleCount.Text = dgvPeopleData.Rows.Count.ToString();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sendEmailToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("(Coming Soon!)", "Coming Soon", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void phoneCallToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("(Coming Soon!)", "Coming Soon", MessageBoxButtons.OK, MessageBoxIcon.Information);
        
    
        }
    }
}







