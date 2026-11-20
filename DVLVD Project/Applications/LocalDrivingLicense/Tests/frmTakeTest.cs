using System;
using System.ComponentModel;
using System.Windows.Forms;
using LibraryProject.BussinessLogic;

namespace DVLVD_Project
{
    public partial class frmTakeTest : Form
    {
        private int _TestAppointmentID;
        private clsTestAppointment _TestAppointment;
        private clsLocalDrivingLicenseApplication _LocalApp;
        private clsTestType _TestTypeObj;

        public frmTakeTest(int testAppointmentID)
        {
            InitializeComponent();
            clsModernUI.ApplyModernTitleBar(this);
            _TestAppointmentID = testAppointmentID;
        }

        private void _LoadData()
        {
            _TestAppointment = clsTestAppointment.Find(_TestAppointmentID);
            if (_TestAppointment == null)
            {
                MessageBox.Show("Test appointment not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            _LocalApp = clsLocalDrivingLicenseApplication.FindByLocalDrivingLicenseAppID(
                _TestAppointment.LocalDrivingLicenseApplicationID);
            if (_LocalApp == null)
            {
                MessageBox.Show("Application not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            _TestTypeObj = clsTestType.Find(_TestAppointment.TestTypeID);

            lblDLAppIDValue.Text = _TestAppointment.LocalDrivingLicenseApplicationID.ToString();

            clsLicenseClass licenseClass = clsLicenseClass.FindByID(_LocalApp.LicenseClassID);
            lblDClassValue.Text = licenseClass != null
                ? string.Format("Class {0} - {1}", licenseClass.ClassID, licenseClass.ClassName)
                : "Unknown";

            clsPerson person = clsPerson.Find(_LocalApp.ApplicantPersonID);
            lblNameValue.Text = person != null ? person.FullName : "Unknown";

            byte trial = _LocalApp.TotalTrialsPerTest((clsTestType.enTestType)_TestAppointment.TestTypeID);
            lblTrialValue.Text = trial.ToString();

            lblDateValue.Text = _TestAppointment.AppointmentDate.ToShortDateString();
            lblFeesValue.Text = _TestAppointment.PaidFees.ToString("0.00");
            lblTestIDValue.Text = "Not Taken Yet";

            rbFail.Checked = true;
        }

        private void frmTakeTest_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void txtNotes_Validating(object sender, CancelEventArgs e)
        {
            errorProvider1.SetError(txtNotes, null);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_TestAppointment.IsLocked)
            {
                MessageBox.Show("This test appointment is already taken.", "Already Taken",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool testResult = rbPass.Checked;

            clsTest test = new clsTest
            {
                TestAppointmentID = _TestAppointmentID,
                TestResult = testResult,
                Notes = txtNotes.Text.Trim(),
                CreatedByUserID = clsGlobal.CurrentUser != null ? clsGlobal.CurrentUser.UserID : -1
            };

            if (test.Save())
            {
                _TestAppointment.Lock();
                lblTestIDValue.Text = test.TestID.ToString();

                string msg = testResult
                    ? "Test result saved — PASSED!"
                    : "Test result saved — FAILED.";

                MessageBox.Show(msg, "Result Saved", MessageBoxButtons.OK,
                    testResult ? MessageBoxIcon.Information : MessageBoxIcon.Warning);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to save test result.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
