using System;
using System.Data;
using DataAccessLayer;

namespace LibraryProject.BussinessLogic
{
    public class clsTestAppointment
    {
        public enum enMode { AddNew = 0, Update = 1 }
        public enMode Mode = enMode.AddNew;

        public int TestAppointmentID { get; set; }
        public int LocalDrivingLicenseApplicationID { get; set; }
        public int TestTypeID { get; set; }
        public DateTime AppointmentDate { get; set; }
        public float PaidFees { get; set; }
        public bool IsLocked { get; set; }
        public int CreatedByUserID { get; set; }

        public clsTestAppointment()
        {
            TestAppointmentID = -1;
            LocalDrivingLicenseApplicationID = -1;
            TestTypeID = -1;
            AppointmentDate = DateTime.Now;
            PaidFees = 0;
            IsLocked = false;
            CreatedByUserID = -1;
            Mode = enMode.AddNew;
        }

        private clsTestAppointment(int testAppointmentID, int localDrivingLicenseApplicationID,
            int testTypeID, DateTime appointmentDate, float paidFees, bool isLocked, int createdByUserID)
        {
            TestAppointmentID = testAppointmentID;
            LocalDrivingLicenseApplicationID = localDrivingLicenseApplicationID;
            TestTypeID = testTypeID;
            AppointmentDate = appointmentDate;
            PaidFees = paidFees;
            IsLocked = isLocked;
            CreatedByUserID = createdByUserID;
            Mode = enMode.Update;
        }

        public static clsTestAppointment Find(int testAppointmentID)
        {
            int localDrivingLicenseApplicationID = -1;
            int testTypeID = -1;
            DateTime appointmentDate = DateTime.Now;
            float paidFees = 0;
            bool isLocked = false;
            int createdByUserID = -1;

            if (clsTestAppointmentData.GetTestAppointmentInfoByID(testAppointmentID,
                ref localDrivingLicenseApplicationID, ref testTypeID,
                ref appointmentDate, ref paidFees, ref isLocked, ref createdByUserID))
            {
                return new clsTestAppointment(testAppointmentID, localDrivingLicenseApplicationID,
                    testTypeID, appointmentDate, paidFees, isLocked, createdByUserID);
            }

            return null;
        }

        public static DataTable GetTestAppointmentsByLocalDrivingLicenseApplicationID(
            int localDrivingLicenseApplicationID, int testTypeID)
        {
            return clsTestAppointmentData.GetTestAppointmentsByLocalDrivingLicenseApplicationID(
                localDrivingLicenseApplicationID, testTypeID);
        }

        private bool _AddNew()
        {
            TestAppointmentID = clsTestAppointmentData.AddNewTestAppointment(
                LocalDrivingLicenseApplicationID, TestTypeID,
                AppointmentDate, PaidFees, CreatedByUserID);
            return (TestAppointmentID != -1);
        }

        private bool _Update()
        {
            return clsTestAppointmentData.UpdateTestAppointment(TestAppointmentID, AppointmentDate);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNew())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return _Update();
            }
            return false;
        }

        public bool Lock()
        {
            return clsTestAppointmentData.LockTestAppointment(TestAppointmentID);
        }
    }
}
