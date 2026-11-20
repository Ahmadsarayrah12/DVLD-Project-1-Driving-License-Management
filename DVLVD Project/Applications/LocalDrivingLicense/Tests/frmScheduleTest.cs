using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using LibraryProject.BussinessLogic;

namespace DVLVD_Project
{
    public partial class frmScheduleTest : Form
    {
        private int _LocalDrivingLicenseApplicationID;
        private clsTestType.enTestType _TestType;
        private clsLocalDrivingLicenseApplication _LocalApp;
        private clsTestType _TestTypeObj;

        public frmScheduleTest(int localDrivingLicenseApplicationID, clsTestType.enTestType testType)
        {
            InitializeComponent();
            clsModernUI.ApplyModernTitleBar(this);
            _LocalDrivingLicenseApplicationID = localDrivingLicenseApplicationID;
            _TestType = testType;
        }

        private void _LoadData()
        {
            _LocalApp = clsLocalDrivingLicenseApplication.FindByLocalDrivingLicenseAppID(_LocalDrivingLicenseApplicationID);
            if (_LocalApp == null)
            {
                MessageBox.Show("Application not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            _TestTypeObj = clsTestType.Find((int)_TestType);
            if (_TestTypeObj == null)
            {
                MessageBox.Show("Test type not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            lblDLAppIDValue.Text = _LocalDrivingLicenseApplicationID.ToString();

            clsLicenseClass licenseClass = clsLicenseClass.FindByID(_LocalApp.LicenseClassID);
            lblDClassValue.Text = licenseClass != null
                ? string.Format("Class {0} - {1}", licenseClass.ClassID, licenseClass.ClassName)
                : "Unknown";

            clsPerson person = clsPerson.Find(_LocalApp.ApplicantPersonID);
            lblNameValue.Text = person != null ? person.FullName : "Unknown";

            byte trial = _LocalApp.TotalTrialsPerTest(_TestType);
            lblTrialValue.Text = trial.ToString();

            dtpDate.Value = DateTime.Now;

            lblFeesValue.Text = _TestTypeObj.Fees.ToString("0.00");

            lblRetakeFees.Text = "0";
            lblTotalFees.Text = _TestTypeObj.Fees.ToString("0.00");
            lblRetakeAppID.Text = "N/A";
        }

        private void frmScheduleTest_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (clsLocalDrivingLicenseApplication.IsThereAnActiveScheduledTest(
                _LocalDrivingLicenseApplicationID, (int)_TestType))
            {
                MessageBox.Show("There is already an active scheduled test for this type. Take the existing test first.",
                    "Active Test Exists", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            clsTestAppointment appointment = new clsTestAppointment
            {
                LocalDrivingLicenseApplicationID = _LocalDrivingLicenseApplicationID,
                TestTypeID = (int)_TestType,
                AppointmentDate = dtpDate.Value,
                PaidFees = _TestTypeObj.Fees,
                CreatedByUserID = clsGlobal.CurrentUser != null ? clsGlobal.CurrentUser.UserID : -1
            };

            if (appointment.Save())
            {
                MessageBox.Show("Test scheduled successfully.", "Scheduled",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to schedule test.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
