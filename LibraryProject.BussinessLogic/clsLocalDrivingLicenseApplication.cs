using System;
using System.Data;
using DataAccessLayer;

namespace LibraryProject.BussinessLogic
{
    public class clsLocalDrivingLicenseApplication : clsApplication
    {
        public new enum enMode { AddNew = 0, Update = 1 }
        public new enMode Mode = enMode.AddNew;

        public int LocalDrivingLicenseApplicationID { get; set; }
        public int LicenseClassID { get; set; }
        public clsLicenseClass LicenseClassInfo => clsLicenseClass.Find(LicenseClassID);
        public string PersonFullName => clsPerson.Find(ApplicantPersonID)?.FullName ?? string.Empty;

        public clsLocalDrivingLicenseApplication()
        {
            this.LocalDrivingLicenseApplicationID = -1;
            this.LicenseClassID = -1;
            this.Mode = enMode.AddNew;
        }

        private clsLocalDrivingLicenseApplication(
            int LocalDrivingLicenseApplicationID, int ApplicationID, int ApplicantPersonID,
            DateTime ApplicationDate, int ApplicationTypeID, enApplicationStatus ApplicationStatus,
            DateTime LastStatusDate, float PaidFees, int CreatedByUserID, int LicenseClassID)
        {
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            this.ApplicationID = ApplicationID;
            this.ApplicantPersonID = ApplicantPersonID;
            this.ApplicationDate = ApplicationDate;
            this.ApplicationTypeID = ApplicationTypeID;
            this.ApplicationStatus = ApplicationStatus;
            this.LastStatusDate = LastStatusDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
            this.LicenseClassID = LicenseClassID;
            this.Mode = enMode.Update;
        }

        private bool _AddNewLocalDrivingLicenseApplication()
        {
            this.LocalDrivingLicenseApplicationID =
                clsLocalDrivingLicenseApplicationData.AddNewLocalDrivingLicenseApplication(
                    this.ApplicationID, this.LicenseClassID);

            return (this.LocalDrivingLicenseApplicationID != -1);
        }

        private bool _UpdateLocalDrivingLicenseApplication()
        {
            return clsLocalDrivingLicenseApplicationData.UpdateLocalDrivingLicenseApplication(
                this.LocalDrivingLicenseApplicationID, this.ApplicationID, this.LicenseClassID);
        }

        public static clsLocalDrivingLicenseApplication FindByLocalDrivingLicenseAppID(int LocalDrivingLicenseApplicationID)
        {
            int ApplicationID = -1;
            int LicenseClassID = -1;

            bool isFound = clsLocalDrivingLicenseApplicationData.GetLocalDrivingLicenseApplicationInfoByID(
                LocalDrivingLicenseApplicationID, ref ApplicationID, ref LicenseClassID);

            if (isFound)
            {
                clsApplication app = clsApplication.FindBaseApplication(ApplicationID);
                if (app != null)
                {
                    return new clsLocalDrivingLicenseApplication(
                        LocalDrivingLicenseApplicationID, app.ApplicationID, app.ApplicantPersonID,
                        app.ApplicationDate, app.ApplicationTypeID, app.ApplicationStatus,
                        app.LastStatusDate, app.PaidFees, app.CreatedByUserID, LicenseClassID);
                }
            }

            return null;
        }

        public static clsLocalDrivingLicenseApplication FindByApplicationID(int ApplicationID)
        {
            int LocalDrivingLicenseApplicationID = -1;
            int LicenseClassID = -1;

            bool isFound = clsLocalDrivingLicenseApplicationData.GetLocalDrivingLicenseApplicationInfoByApplicationID(
                ApplicationID, ref LocalDrivingLicenseApplicationID, ref LicenseClassID);

            if (isFound)
            {
                clsApplication app = clsApplication.FindBaseApplication(ApplicationID);
                if (app != null)
                {
                    return new clsLocalDrivingLicenseApplication(
                        LocalDrivingLicenseApplicationID, app.ApplicationID, app.ApplicantPersonID,
                        app.ApplicationDate, app.ApplicationTypeID, app.ApplicationStatus,
                        app.LastStatusDate, app.PaidFees, app.CreatedByUserID, LicenseClassID);
                }
            }

            return null;
        }

        public static DataTable GetAllLocalDrivingLicenseApplications()
        {
            return clsLocalDrivingLicenseApplicationData.GetAllLocalDrivingLicenseApplications();
        }

        public override bool Save()
        {
            base.Mode = (clsApplication.enMode)this.Mode;

            if (!base.Save())
            {
                return false;
            }

            switch (this.Mode)
            {
                case enMode.AddNew:
                    if (_AddNewLocalDrivingLicenseApplication())
                    {
                        this.Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateLocalDrivingLicenseApplication();
            }

            return false;
        }

        public new bool Delete()
        {
            bool isLocalAppDeleted = clsLocalDrivingLicenseApplicationData.DeleteLocalDrivingLicenseApplication(
                this.LocalDrivingLicenseApplicationID);

            if (!isLocalAppDeleted)
            {
                return false;
            }

            return base.Delete();
        }

        public bool DoesPassTestType(clsTestType.enTestType TestTypeID)
        {
            return clsLocalDrivingLicenseApplicationData.DoesPassTestType(
                this.LocalDrivingLicenseApplicationID, (int)TestTypeID);
        }

        public bool DoesPassPreviousTest(clsTestType.enTestType CurrentTestType)
        {
            switch (CurrentTestType)
            {
                case clsTestType.enTestType.VisionTest:
                    return true;

                case clsTestType.enTestType.WrittenTest:
                    return DoesPassTestType(clsTestType.enTestType.VisionTest);

                case clsTestType.enTestType.StreetTest:
                    return DoesPassTestType(clsTestType.enTestType.WrittenTest);

                default:
                    return false;
            }
        }

        public byte GetPassedTestCount()
        {
            byte count = 0;
            if (DoesPassTestType(clsTestType.enTestType.VisionTest)) count++;
            if (DoesPassTestType(clsTestType.enTestType.WrittenTest)) count++;
            if (DoesPassTestType(clsTestType.enTestType.StreetTest)) count++;
            return count;
        }

        public bool PassedAllTests()
        {
            return (GetPassedTestCount() == 3);
        }

        public byte TotalTrialsPerTest(clsTestType.enTestType TestTypeID)
        {
            return clsLocalDrivingLicenseApplicationData.TotalTrialsPerTest(
                this.LocalDrivingLicenseApplicationID, (int)TestTypeID);
        }

        public bool AttendedTest(clsTestType.enTestType TestTypeID)
        {
            return clsLocalDrivingLicenseApplicationData.DoesAttendTestType(
                this.LocalDrivingLicenseApplicationID, (int)TestTypeID);
        }

        public bool IsThereAnActiveScheduledTest(clsTestType.enTestType TestTypeID)
        {
            return clsLocalDrivingLicenseApplicationData.IsThereAnActiveScheduledTest(
                this.LocalDrivingLicenseApplicationID, (int)TestTypeID);
        }
    }
}
