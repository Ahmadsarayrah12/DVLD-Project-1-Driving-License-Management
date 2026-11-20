using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using LibraryProject.BussinessLogic;

namespace DVLVD_Project
{
    public partial class frmListLocalDrivingLicesnseApplications : Form
    {
        private DataTable _dtAllLocalDrivingLicenseApplications;

        public frmListLocalDrivingLicesnseApplications()
        {
            InitializeComponent();
            clsModernUI.ApplyModernTitleBar(this);
        }

        private void _RefreshLocalDrivingLicenseApplicationsList()
        {
            _dtAllLocalDrivingLicenseApplications = clsLocalDrivingLicenseApplication.GetAllLocalDrivingLicenseApplications();
            dgvLocalDrivingLicenseApplications.DataSource = _dtAllLocalDrivingLicenseApplications;

            lblRecordsCount.Text = "# Records: " + dgvLocalDrivingLicenseApplications.Rows.Count.ToString();

            if (dgvLocalDrivingLicenseApplications.Rows.Count > 0)
            {
                dgvLocalDrivingLicenseApplications.Columns[0].HeaderText = "L.D.L.AppID";
                dgvLocalDrivingLicenseApplications.Columns[0].Width = 120;

                dgvLocalDrivingLicenseApplications.Columns[1].HeaderText = "Driving Class";
                dgvLocalDrivingLicenseApplications.Columns[1].Width = 260;

                dgvLocalDrivingLicenseApplications.Columns[2].HeaderText = "National No.";
                dgvLocalDrivingLicenseApplications.Columns[2].Width = 110;

                dgvLocalDrivingLicenseApplications.Columns[3].HeaderText = "Full Name";
                dgvLocalDrivingLicenseApplications.Columns[3].Width = 300;

                dgvLocalDrivingLicenseApplications.Columns[4].HeaderText = "Application Date";
                dgvLocalDrivingLicenseApplications.Columns[4].Width = 170;

                dgvLocalDrivingLicenseApplications.Columns[5].HeaderText = "Passed Tests";
                dgvLocalDrivingLicenseApplications.Columns[5].Width = 110;

                dgvLocalDrivingLicenseApplications.Columns[6].HeaderText = "Status";
                dgvLocalDrivingLicenseApplications.Columns[6].Width = 110;
            }
        }

        private void frmListLocalDrivingLicesnseApplications_Load(object sender, EventArgs e)
        {
            _RefreshLocalDrivingLicenseApplicationsList();

            cbFilterBy.SelectedIndex = 0;
            cbStatus.SelectedIndex = 0;
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_dtAllLocalDrivingLicenseApplications != null)
            {
                _dtAllLocalDrivingLicenseApplications.DefaultView.RowFilter = "";
                lblRecordsCount.Text = "# Records: " + dgvLocalDrivingLicenseApplications.Rows.Count.ToString();
            }

            if (cbFilterBy.Text == "None")
            {
                txtFilterValue.Visible = false;
                cbStatus.Visible = false;
            }
            else if (cbFilterBy.Text == "Status")
            {
                txtFilterValue.Visible = false;
                cbStatus.Visible = true;
                cbStatus.SelectedIndex = 0;
                cbStatus.Focus();
            }
            else
            {
                txtFilterValue.Visible = true;
                cbStatus.Visible = false;
                txtFilterValue.Text = "";
                txtFilterValue.Focus();
            }
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            if (_dtAllLocalDrivingLicenseApplications == null) return;

            string filterColumn = "";

            switch (cbFilterBy.Text)
            {
                case "L.D.L.AppID":
                    filterColumn = "LocalDrivingLicenseApplicationID";
                    break;
                case "National No.":
                    filterColumn = "NationalNo";
                    break;
                case "Full Name":
                    filterColumn = "FullName";
                    break;
                default:
                    filterColumn = "None";
                    break;
            }

            if (string.IsNullOrWhiteSpace(txtFilterValue.Text) || filterColumn == "None")
            {
                _dtAllLocalDrivingLicenseApplications.DefaultView.RowFilter = "";
                lblRecordsCount.Text = "# Records: " + dgvLocalDrivingLicenseApplications.Rows.Count.ToString();
                return;
            }

            if (filterColumn == "LocalDrivingLicenseApplicationID")
            {
                if (int.TryParse(txtFilterValue.Text.Trim(), out int id))
                {
                    _dtAllLocalDrivingLicenseApplications.DefaultView.RowFilter = string.Format("[{0}] = {1}", filterColumn, id);
                }
                else
                {
                    _dtAllLocalDrivingLicenseApplications.DefaultView.RowFilter = "";
                }
            }
            else
            {
                _dtAllLocalDrivingLicenseApplications.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", filterColumn, txtFilterValue.Text.Trim().Replace("'", "''"));
            }

            lblRecordsCount.Text = "# Records: " + dgvLocalDrivingLicenseApplications.Rows.Count.ToString();
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_dtAllLocalDrivingLicenseApplications == null) return;

            if (cbStatus.Text == "All")
            {
                _dtAllLocalDrivingLicenseApplications.DefaultView.RowFilter = "";
            }
            else
            {
                _dtAllLocalDrivingLicenseApplications.DefaultView.RowFilter = string.Format("[Status] = '{0}'", cbStatus.Text);
            }

            lblRecordsCount.Text = "# Records: " + dgvLocalDrivingLicenseApplications.Rows.Count.ToString();
        }

        private void btnAddNewApplication_Click(object sender, EventArgs e)
        {
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm is frmAddUpdateLocalDrivingLicesnseApplication)
                {
                    openForm.BringToFront();
                    openForm.Activate();
                    return;
                }
            }

            frmAddUpdateLocalDrivingLicesnseApplication frm = new frmAddUpdateLocalDrivingLicesnseApplication();
            frm.ShowDialog();
            _RefreshLocalDrivingLicenseApplicationsList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvLocalDrivingLicenseApplications_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex >= 0)
                {
                    dgvLocalDrivingLicenseApplications.ClearSelection();
                    dgvLocalDrivingLicenseApplications.Rows[e.RowIndex].Selected = true;
                    dgvLocalDrivingLicenseApplications.CurrentCell = dgvLocalDrivingLicenseApplications.Rows[e.RowIndex].Cells[e.ColumnIndex >= 0 ? e.ColumnIndex : 0];
                }
            }
        }

        private void cmsApplications_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (dgvLocalDrivingLicenseApplications.CurrentRow == null)
            {
                e.Cancel = true;
                return;
            }

            int localDrivingLicenseApplicationID = (int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value;
            clsLocalDrivingLicenseApplication localApp = clsLocalDrivingLicenseApplication.FindByLocalDrivingLicenseAppID(localDrivingLicenseApplicationID);

            if (localApp == null)
            {
                e.Cancel = true;
                return;
            }

            int totalPassedTests = Convert.ToInt32(dgvLocalDrivingLicenseApplications.CurrentRow.Cells[5].Value);
            bool isLicenseExists = clsLocalDrivingLicenseApplication.IsLicenseExistByPersonID(localApp.ApplicantPersonID, localApp.LicenseClassID);

            // Enabled only if passed all 3 tests and not issued yet
            issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = (totalPassedTests == 3) && !isLicenseExists;
            showLicenseToolStripMenuItem.Enabled = isLicenseExists;

            editApplicationToolStripMenuItem.Enabled = (localApp.ApplicationStatus == clsApplication.enApplicationStatus.New) && (totalPassedTests == 0);
            cancelApplicationToolStripMenuItem.Enabled = (localApp.ApplicationStatus == clsApplication.enApplicationStatus.New);
            deleteApplicationToolStripMenuItem.Enabled = (localApp.ApplicationStatus == clsApplication.enApplicationStatus.New) && (totalPassedTests == 0);

            bool canSchedule = (localApp.ApplicationStatus == clsApplication.enApplicationStatus.New) && (totalPassedTests < 3);
            scheduleTestsToolStripMenuItem.Enabled = canSchedule;

            if (canSchedule)
            {
                bool passedVision = localApp.DoesPassTestType(clsTestType.enTestType.VisionTest);
                bool passedWritten = localApp.DoesPassTestType(clsTestType.enTestType.WrittenTest);
                bool passedStreet = localApp.DoesPassTestType(clsTestType.enTestType.StreetTest);

                // 1. Vision Test: enabled if NOT passed yet
                scheduleVisionTestToolStripMenuItem.Enabled = !passedVision;

                // 2. Written Test: enabled ONLY if passed Vision AND NOT passed Written yet
                scheduleWrittenTestToolStripMenuItem.Enabled = passedVision && !passedWritten;

                // 3. Street Test: enabled ONLY if passed Written AND NOT passed Street yet
                scheduleStreetTestToolStripMenuItem.Enabled = passedWritten && !passedStreet;
            }
            else
            {
                scheduleVisionTestToolStripMenuItem.Enabled = false;
                scheduleWrittenTestToolStripMenuItem.Enabled = false;
                scheduleStreetTestToolStripMenuItem.Enabled = false;
            }
        }

        private void _ScheduleTest(clsTestType.enTestType testType)
        {
            if (dgvLocalDrivingLicenseApplications.CurrentRow == null) return;

            int localDrivingLicenseApplicationID = (int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value;

            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm is frmTestAppointments frmTest && frmTest.Tag != null && (int)frmTest.Tag == localDrivingLicenseApplicationID)
                {
                    openForm.BringToFront();
                    openForm.Activate();
                    return;
                }
            }

            frmTestAppointments frm = new frmTestAppointments(localDrivingLicenseApplicationID, testType);
            frm.Tag = localDrivingLicenseApplicationID;
            frm.ShowDialog();
            _RefreshLocalDrivingLicenseApplicationsList();
        }

        private void scheduleVisionTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _ScheduleTest(clsTestType.enTestType.VisionTest);
        }

        private void scheduleWrittenTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _ScheduleTest(clsTestType.enTestType.WrittenTest);
        }

        private void scheduleStreetTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _ScheduleTest(clsTestType.enTestType.StreetTest);
        }

        private void cancelApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvLocalDrivingLicenseApplications.CurrentRow == null) return;

            if (MessageBox.Show("Are you sure you want to cancel this application?", "Confirm Cancel",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            int localDrivingLicenseApplicationID = (int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value;
            clsLocalDrivingLicenseApplication localApp = clsLocalDrivingLicenseApplication.FindByLocalDrivingLicenseAppID(localDrivingLicenseApplicationID);

            if (localApp != null && localApp.Cancel())
            {
                MessageBox.Show("Application Cancelled Successfully.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _RefreshLocalDrivingLicenseApplicationsList();
            }
            else
            {
                MessageBox.Show("Could not cancel application.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvLocalDrivingLicenseApplications.CurrentRow == null) return;

            if (MessageBox.Show("Are you sure you want to delete this application?", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            int localDrivingLicenseApplicationID = (int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value;
            clsLocalDrivingLicenseApplication localApp = clsLocalDrivingLicenseApplication.FindByLocalDrivingLicenseAppID(localDrivingLicenseApplicationID);

            if (localApp != null && localApp.Delete())
            {
                MessageBox.Show("Application Deleted Successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _RefreshLocalDrivingLicenseApplicationsList();
            }
            else
            {
                MessageBox.Show("Could not delete application, other data depends on it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void editApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvLocalDrivingLicenseApplications.CurrentRow == null) return;

            int localDrivingLicenseApplicationID = (int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value;

            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm is frmAddUpdateLocalDrivingLicesnseApplication)
                {
                    openForm.BringToFront();
                    openForm.Activate();
                    return;
                }
            }

            frmAddUpdateLocalDrivingLicesnseApplication frm = new frmAddUpdateLocalDrivingLicesnseApplication(localDrivingLicenseApplicationID);
            frm.ShowDialog();
            _RefreshLocalDrivingLicenseApplicationsList();
        }

        private void showApplicationDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Application details view will be available soon.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void issueDrivingLicenseFirstTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Issue License feature will be opened from here.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Show License feature will be opened from here.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Person License History will be opened from here.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
