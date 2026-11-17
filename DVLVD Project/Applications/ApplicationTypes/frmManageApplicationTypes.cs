using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using LibraryProject.BussinessLogic;

namespace DVLVD_Project
{
    public partial class frmManageApplicationTypes : Form
    {
        private DataTable _dtAllApplicationTypes;

        public frmManageApplicationTypes()
        {
            InitializeComponent();
            clsModernUI.ApplyModernTitleBar(this);
        }

        private void _RefreshApplicationTypesList()
        {
            _dtAllApplicationTypes = clsApplicationType.GetAllApplicationTypes();
            dgvApplicationTypes.DataSource = _dtAllApplicationTypes;

            lblRecordsCount.Text = "# Records: " + dgvApplicationTypes.Rows.Count.ToString();

            if (dgvApplicationTypes.Rows.Count > 0)
            {
                dgvApplicationTypes.Columns[0].HeaderText = "ID";
                dgvApplicationTypes.Columns[0].Width = 100;

                dgvApplicationTypes.Columns[1].HeaderText = "Title";
                dgvApplicationTypes.Columns[1].Width = 400;

                dgvApplicationTypes.Columns[2].HeaderText = "Fees";
                dgvApplicationTypes.Columns[2].Width = 120;
                dgvApplicationTypes.Columns[2].DefaultCellStyle.Format = "0.0000";
            }
        }

        private void frmManageApplicationTypes_Load(object sender, EventArgs e)
        {
            _RefreshApplicationTypesList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editApplicationTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvApplicationTypes.CurrentRow != null)
            {
                int applicationTypeID = (int)dgvApplicationTypes.CurrentRow.Cells[0].Value;
                frmEditApplicationType frm = new frmEditApplicationType(applicationTypeID);
                frm.ShowDialog();
                _RefreshApplicationTypesList();
            }
        }

        private void dgvApplicationTypes_DoubleClick(object sender, EventArgs e)
        {
            editApplicationTypeToolStripMenuItem_Click(null, null);
        }
    }
}
