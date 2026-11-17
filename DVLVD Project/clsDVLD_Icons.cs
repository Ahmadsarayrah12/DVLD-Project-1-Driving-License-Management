using System;
using System.Drawing;
using System.Windows.Forms;

namespace DVLD.Classes
{
    // Helper class for DVLD UI icons
    public static class clsDVLD_Icons
    {
        // Default person images
        public static Image GetDefaultPersonImage(bool isMale)
        {
            return isMale ? Properties.Resources.Male_Photo_Placeholder 
                          : Properties.Resources.Female_Photo_Placeholder;
        }

        // Test types
        public enum enTestType { VisionTest = 1, WrittenTest = 2, StreetTest = 3 }

        public static Image GetTestTypeImage(enTestType testType)
        {
            switch (testType)
            {
                case enTestType.VisionTest:
                    return Properties.Resources.Vision_Test;
                case enTestType.WrittenTest:
                    return Properties.Resources.Written_Test;
                case enTestType.StreetTest:
                    return Properties.Resources.Street_Test;
                default:
                    return null;
            }
        }

        public static Image GetTestTypeImage(int testTypeID)
        {
            return GetTestTypeImage((enTestType)testTypeID);
        }

        // Test results
        public static Image GetTestResultImage(bool isPassed)
        {
            return isPassed ? Properties.Resources.Test_Passed_Badge 
                            : Properties.Resources.Test_Failed_Badge;
        }

        // License status
        public static Image GetLicenseImage(bool isDetained)
        {
            return isDetained ? Properties.Resources.License_Detained 
                              : Properties.Resources.License_Active;
        }

        // Application status
        public enum enApplicationStatus { New = 1, Cancelled = 2, Completed = 3 }

        public static Image GetApplicationStatusImage(enApplicationStatus status)
        {
            switch (status)
            {
                case enApplicationStatus.New:
                    return Properties.Resources.Application_New;
                case enApplicationStatus.Cancelled:
                    return Properties.Resources.Application_Cancelled;
                case enApplicationStatus.Completed:
                    return Properties.Resources.Application_Completed;
                default:
                    return null;
            }
        }

        public static Image GetApplicationStatusImage(int statusID)
        {
            return GetApplicationStatusImage((enApplicationStatus)statusID);
        }

        // Password visibility toggle
        public static void TogglePasswordVisibility(TextBox txtPassword, Button btnEye)
        {
            if (txtPassword == null) return;

            txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;

            if (btnEye != null)
            {
                btnEye.Image = txtPassword.UseSystemPasswordChar 
                    ? Properties.Resources.Password_Show 
                    : Properties.Resources.Password_Hide;
            }
        }

        // License classes
        public static Image GetLicenseClassImage(int licenseClassID)
        {
            switch (licenseClassID)
            {
                case 1: return Properties.Resources.Class1_Small_Motorcycle;
                case 2: return Properties.Resources.Class2_Heavy_Motorcycle;
                case 3: return Properties.Resources.Class3_Ordinary_Driving_License;
                case 4: return Properties.Resources.Class4_Commercial;
                case 5: return Properties.Resources.Class5_Agricultural;
                case 6: return Properties.Resources.Class6_Small_Medium_Bus;
                case 7: return Properties.Resources.Class7_Truck_Heavy_Vehicle;
                case 8: return Properties.Resources.Class8_Custom_Placeholder;
                case 9: return Properties.Resources.Class9_Custom_Placeholder;
                case 10: return Properties.Resources.Class10_Custom_Placeholder;
                default: return null;
            }
        }

        // Main navigation icons
        public static Image People => Properties.Resources.People;
        public static Image ManagePeople => Properties.Resources.Manage_People;
        public static Image Drivers => Properties.Resources.Drivers;
        public static Image Users => Properties.Resources.Users;
        public static Image Applications => Properties.Resources.Applications;

        // Context menu icons
        public static class ContextMenu
        {
            public static Image ShowDetails => Properties.Resources.CMS_Show_Details;
            public static Image Edit => Properties.Resources.CMS_Edit;
            public static Image Delete => Properties.Resources.CMS_Delete;
            public static Image SendEmail => Properties.Resources.CMS_Send_Email;
            public static Image PhoneCall => Properties.Resources.CMS_Phone_Call;
            public static Image IssueDrivingLicense => Properties.Resources.CMS_Issue_Driving_License_First_Time;
            public static Image ShowLicense => Properties.Resources.CMS_Show_License;
            public static Image LicenseHistory => Properties.Resources.CMS_Show_Person_License_History;
            public static Image ScheduleVisionTest => Properties.Resources.CMS_Schedule_Vision_Test;
            public static Image ScheduleWrittenTest => Properties.Resources.CMS_Schedule_Written_Test;
            public static Image ScheduleStreetTest => Properties.Resources.CMS_Schedule_Street_Test;
            public static Image TakeTest => Properties.Resources.CMS_Take_Test;
            public static Image DetainLicense => Properties.Resources.CMS_Detain_License;
            public static Image ReleaseLicense => Properties.Resources.CMS_Release_License;
            public static Image RenewLicense => Properties.Resources.CMS_Renew_License;
        }

        public static class Buttons
        {
            public static Image Save => Properties.Resources.Btn_Save;
            public static Image Close => Properties.Resources.Btn_Close;
            public static Image Back => Properties.Resources.Btn_Back;
            public static Image Next => Properties.Resources.Btn_Next_Step;
            public static Image Reset => Properties.Resources.Btn_Reset;
            public static Image BrowseImage => Properties.Resources.Btn_Browse_Image;
            public static Image RemoveImage => Properties.Resources.Btn_Remove_Image;
            public static Image TakeSnapshot => Properties.Resources.Btn_Take_Snapshot;
            public static Image Verify => Properties.Resources.Btn_Verify;
            public static Image CalcFees => Properties.Resources.Btn_Calc_Fees;
            public static Image PrintCard => Properties.Resources.Btn_Print_Card;
            public static Image IssueLicense => Properties.Resources.Btn_Issue_License;
        }

        public static class Stamps
        {
            public static Image Passed => Properties.Resources.Stamp_Passed;
            public static Image Failed => Properties.Resources.Stamp_Failed;
            public static Image Detained => Properties.Resources.Stamp_Detained;
            public static Image Renewed => Properties.Resources.Stamp_Renewed;
            public static Image Expired => Properties.Resources.Stamp_Expired;
            public static Image OfficialSeal => Properties.Resources.DVLD_Official_Seal;
        }
    }
}
