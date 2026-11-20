using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using LibraryProject.BussinessLogic;

namespace DVLVD_Project
{
    public partial class frmManageTestTypes : Form
    {
        private DataTable _dtAllTestTypes;

        public frmManageTestTypes()
        {
            InitializeComponent();
            clsModernUI.ApplyModernTitleBar(this);
        }

        private void _RefreshTestTypesList()
        {
            _dtAllTestTypes = clsTestType.GetAllTestTypes();
            dgvTestTypes.DataSource = _dtAllTestTypes;

            lblRecordsCount.Text = "# Records: " + dgvTestTypes.Rows.Count.ToString();

            if (dgvTestTypes.Rows.Count > 0)
            {
                dgvTestTypes.Columns[0].HeaderText = "ID";
                dgvTestTypes.Columns[0].Width = 100;

                dgvTestTypes.Columns[1].HeaderText = "Title";
                dgvTestTypes.Columns[1].Width = 180;

                dgvTestTypes.Columns[2].HeaderText = "Description";
                dgvTestTypes.Columns[2].Width = 350;

                dgvTestTypes.Columns[3].HeaderText = "Fees";
                dgvTestTypes.Columns[3].Width = 100;
                dgvTestTypes.Columns[3].DefaultCellStyle.Format = "0.0000";
            }
        }

        private void frmManageTestTypes_Load(object sender, EventArgs e)
        {
            _RefreshTestTypesList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editTestTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvTestTypes.CurrentRow != null)
            {
                int testTypeID = (int)dgvTestTypes.CurrentRow.Cells[0].Value;
                frmEditTestType frm = new frmEditTestType((clsTestType.enTestType)testTypeID);
                frm.ShowDialog();
                _RefreshTestTypesList();
            }
        }

        private void dgvTestTypes_DoubleClick(object sender, EventArgs e)
        {
            editTestTypeToolStripMenuItem_Click(null, null);
        }
    }
}
