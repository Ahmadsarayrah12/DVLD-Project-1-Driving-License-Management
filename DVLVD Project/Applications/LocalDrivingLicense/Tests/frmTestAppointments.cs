using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using LibraryProject.BussinessLogic;

namespace DVLVD_Project
{
    public partial class frmTestAppointments : Form
    {
        private int _LocalDrivingLicenseApplicationID;
        private clsTestType.enTestType _TestType;
        private clsLocalDrivingLicenseApplication _LocalApp;
        private DataTable _dtAppointments;

        public frmTestAppointments(int localDrivingLicenseApplicationID, clsTestType.enTestType testType)
        {
            InitializeComponent();
            clsModernUI.ApplyModernTitleBar(this);
            _LocalDrivingLicenseApplicationID = localDrivingLicenseApplicationID;
            _TestType = testType;
        }

        private void _LoadAppInfo()
        {
            _LocalApp = clsLocalDrivingLicenseApplication.FindByLocalDrivingLicenseAppID(_LocalDrivingLicenseApplicationID);
            if (_LocalApp == null) { this.Close(); return; }

            lblDLAppIDValue.Text = _LocalDrivingLicenseApplicationID.ToString();

            clsLicenseClass lc = clsLicenseClass.FindByID(_LocalApp.LicenseClassID);
            lblAppliedForValue.Text = lc != null
                ? string.Format("Class {0} - {1}", lc.ClassID, lc.ClassName)
                : "Unknown";

            byte passed = _LocalApp.GetPassedTestCount();
            lblPassedTestsValue.Text = string.Format("{0}/3", passed);

            lblAppIDValue.Text = _LocalApp.ApplicationID.ToString();
            lblStatusValue.Text = _LocalApp.StatusText;
            lblFeesValue.Text = _LocalApp.PaidFees.ToString("0.00");
            lblDateValue.Text = _LocalApp.ApplicationDate.ToShortDateString();
            lblStatusDateValue.Text = _LocalApp.LastStatusDate.ToShortDateString();

            clsApplicationType appType = clsApplicationType.Find(_LocalApp.ApplicationTypeID);
            lblTypeValue.Text = appType != null ? appType.Title : "Unknown";

            clsPerson person = clsPerson.Find(_LocalApp.ApplicantPersonID);
            lblApplicantValue.Text = person != null ? person.FullName : "Unknown";

            clsUser user = clsUser.FindByUserID(_LocalApp.CreatedByUserID);
            lblCreatedByValue.Text = user != null ? user.UserName : "Unknown";

            switch (_TestType)
            {
                case clsTestType.enTestType.VisionTest:
                    this.Text = "Vision Test Appointments";
                    lblFormTitle.Text = "Vision Test Appointments";
                    lblTestTypeTag.Text = "Vision Test";
                    break;
                case clsTestType.enTestType.WrittenTest:
                    this.Text = "Written Test Appointments";
                    lblFormTitle.Text = "Written Test Appointments";
                    lblTestTypeTag.Text = "Written (Theory) Test";
                    break;
                case clsTestType.enTestType.StreetTest:
                    this.Text = "Street Test Appointments";
                    lblFormTitle.Text = "Street Test Appointments";
                    lblTestTypeTag.Text = "Practical (Street) Test";
                    break;
            }
        }

        private void _LoadAppointments()
        {
            _dtAppointments = clsTestAppointment.GetTestAppointmentsByLocalDrivingLicenseApplicationID(
                _LocalDrivingLicenseApplicationID, (int)_TestType);

            dgvAppointments.DataSource = _dtAppointments;
            lblRecordsCount.Text = "# Records: " + dgvAppointments.Rows.Count;

            if (dgvAppointments.Rows.Count > 0)
            {
                dgvAppointments.Columns[0].HeaderText = "Appointment ID";
                dgvAppointments.Columns[0].Width = 120;
                dgvAppointments.Columns[1].HeaderText = "Date";
                dgvAppointments.Columns[1].Width = 120;
                dgvAppointments.Columns[2].HeaderText = "Fees";
                dgvAppointments.Columns[2].Width = 80;
                dgvAppointments.Columns[3].HeaderText = "Locked";
                dgvAppointments.Columns[3].Width = 70;
                if (dgvAppointments.Columns.Count > 4)
                {
                    dgvAppointments.Columns[4].HeaderText = "Result";
                    dgvAppointments.Columns[4].Width = 70;
                }
                if (dgvAppointments.Columns.Count > 5)
                {
                    dgvAppointments.Columns[5].HeaderText = "Notes";
                    dgvAppointments.Columns[5].Width = 150;
                }
            }
        }

        private void frmTestAppointments_Load(object sender, EventArgs e)
        {
            _LoadAppInfo();
            _LoadAppointments();
        }

        private void btnAddAppointment_Click(object sender, EventArgs e)
        {
            if (clsLocalDrivingLicenseApplication.IsThereAnActiveScheduledTest(
                _LocalDrivingLicenseApplicationID, (int)_TestType))
            {
                MessageBox.Show("There is already an active scheduled appointment for this test.",
                    "Active Appointment Exists", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!_LocalApp.DoesPassPreviousTest(_TestType))
            {
                MessageBox.Show("Cannot schedule this test. The previous test has not been passed yet.",
                    "Previous Test Not Passed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            frmScheduleTest frm = new frmScheduleTest(_LocalDrivingLicenseApplicationID, _TestType);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                _LoadAppointments();
            }
        }

        private void dgvAppointments_DoubleClick(object sender, EventArgs e)
        {
            _OpenTakeTestForSelected();
        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _OpenTakeTestForSelected();
        }

        private void _OpenTakeTestForSelected()
        {
            if (dgvAppointments.CurrentRow == null) return;

            int appointmentID = (int)dgvAppointments.CurrentRow.Cells[0].Value;
            clsTestAppointment appt = clsTestAppointment.Find(appointmentID);

            if (appt == null) return;

            if (appt.IsLocked)
            {
                MessageBox.Show("This appointment has already been taken.", "Already Taken",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            frmTakeTest frm = new frmTakeTest(appointmentID);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                _LoadAppointments();
                _LoadAppInfo();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
