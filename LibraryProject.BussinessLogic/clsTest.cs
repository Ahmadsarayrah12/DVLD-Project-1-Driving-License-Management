using DataAccessLayer;

namespace LibraryProject.BussinessLogic
{
    public class clsTest
    {
        public enum enMode { AddNew = 0, Update = 1 }
        public enMode Mode = enMode.AddNew;

        public int TestID { get; set; }
        public int TestAppointmentID { get; set; }
        public bool TestResult { get; set; }
        public string Notes { get; set; }
        public int CreatedByUserID { get; set; }

        public clsTest()
        {
            TestID = -1;
            TestAppointmentID = -1;
            TestResult = false;
            Notes = string.Empty;
            CreatedByUserID = -1;
            Mode = enMode.AddNew;
        }

        private clsTest(int testID, int testAppointmentID, bool testResult, string notes, int createdByUserID)
        {
            TestID = testID;
            TestAppointmentID = testAppointmentID;
            TestResult = testResult;
            Notes = notes;
            CreatedByUserID = createdByUserID;
            Mode = enMode.Update;
        }

        public static clsTest FindByTestAppointmentID(int testAppointmentID)
        {
            int testID = -1;
            bool testResult = false;
            string notes = string.Empty;

            if (clsTestData.GetTestInfoByTestAppointmentID(testAppointmentID, ref testID, ref testResult, ref notes))
            {
                return new clsTest(testID, testAppointmentID, testResult, notes, -1);
            }

            return null;
        }

        public static int CountPassedTests(int localDrivingLicenseApplicationID)
        {
            return clsTestData.CountPassedTestsForLocalDrivingLicenseApplication(localDrivingLicenseApplicationID);
        }

        private bool _AddNew()
        {
            TestID = clsTestData.AddNewTest(TestAppointmentID, TestResult, Notes, CreatedByUserID);
            return (TestID != -1);
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
            }
            return false;
        }
    }
}
