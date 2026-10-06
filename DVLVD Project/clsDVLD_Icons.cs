using System;
using System.Drawing;
using System.Windows.Forms;

namespace DVLD.Classes
{
    /// <summary>
    /// كلاس مساعد C# لإدارة وعرض أيقونات وصور مشروع DVLD في بيئة Windows Forms.
    /// تم تصميمه ليتوافق تماماً مع متطلبات دورة ProgrammingAdvices لنظام رخص القيادة.
    /// </summary>
    public static class clsDVLD_Icons
    {
        // =============================================================
        // 1. صور الأشخاص الافتراضية (Default Person Photo)
        // =============================================================
        /// <summary>
        /// يرجع صورة الشخص الافتراضية (ذكر / أنثى) في حال عدم توفر صورة شخصية في قاعدة البيانات.
        /// يتم استدعاؤها في شاشة Add/Edit Person و ctrlPersonCard.
        /// </summary>
        /// <param name="isMale">true إذا كان المتقدم ذكراً، false إذا كانت أنثى</param>
        public static Image GetDefaultPersonImage(bool isMale)
        {
            return isMale ? Properties.Resources.Male_Photo_Placeholder 
                          : Properties.Resources.Female_Photo_Placeholder;
        }

        // =============================================================
        // 2. صور أنواع الاختبارات الثلاثة (Test Types: Vision, Written, Street)
        // =============================================================
        public enum enTestType { VisionTest = 1, WrittenTest = 2, StreetTest = 3 }

        /// <summary>
        /// يرجع الأيقونة المناسبة لنوع الاختبار (1: فحص النظر، 2: الفحص النظري، 3: فحص القيادة العملي).
        /// </summary>
        public static Image GetTestTypeImage(enTestType testType)
        {
            switch (testType)
            {
                case enTestType.VisionTest:
                    return Properties.Resources.Vision_Test;
                case enTestType.WrittenTest:
                    return Properties.Resources.Written_Test;
                case enTestType.StreetTest:
                    return Properties.Resources.Practical_Test;
                default:
                    return Properties.Resources.Vision_Test;
            }
        }

        public static Image GetTestTypeImage(int testTypeID)
        {
            return GetTestTypeImage((enTestType)testTypeID);
        }

        // =============================================================
        // 3. صور نتائج الاختبارات (Test Results: Passed / Failed)
        // =============================================================
        /// <summary>
        /// يرجع أيقونة نتيجة الاختبار (ناجح / راسب).
        /// </summary>
        public static Image GetTestResultImage(bool isPassed)
        {
            return isPassed ? Properties.Resources.Test_Passed 
                            : Properties.Resources.Test_Failed;
        }

        // =============================================================
        // 4. صور حالات الرخص (Active, Detained, Released)
        // =============================================================
        /// <summary>
        /// يرجع أيقونة الرخصة حسب حالتها (محجوزة / عادية).
        /// </summary>
        public static Image GetLicenseImage(bool isDetained)
        {
            return isDetained ? Properties.Resources.Detained_License 
                              : Properties.Resources.License_Card;
        }

        // =============================================================
        // 5. صور حالات الطلبات (Application Status: New, Cancelled, Completed)
        // =============================================================
        public enum enApplicationStatus { New = 1, Cancelled = 2, Completed = 3 }

        /// <summary>
        /// يرجع أيقونة حالة الطلب (1: جديد، 2: ملغى، 3: مكتمل ومعتمد).
        /// </summary>
        public static Image GetApplicationStatusImage(enApplicationStatus status)
        {
            switch (status)
            {
                case enApplicationStatus.New:
                    return Properties.Resources.New_Application;
                case enApplicationStatus.Cancelled:
                    return Properties.Resources.Cancel_Application;
                case enApplicationStatus.Completed:
                    return Properties.Resources.Approve_Application;
                default:
                    return Properties.Resources.New_Application;
            }
        }

        public static Image GetApplicationStatusImage(int statusID)
        {
            return GetApplicationStatusImage((enApplicationStatus)statusID);
        }

        // =============================================================
        // 6. ميزة إظهار / إخفاء كلمة المرور لشاشة تسجيل الدخول (frmLogin)
        // =============================================================
        /// <summary>
        /// تبديل إظهار وإخفاء كلمة المرور في الـ TextBox مع تغيير أيقونة الزر تلقائياً.
        /// </summary>
        public static void TogglePasswordVisibility(TextBox txtPassword, Button btnEye)
        {
            if (txtPassword.PasswordChar == '\0')
            {
                txtPassword.PasswordChar = '*';
                btnEye.Image = Properties.Resources.Show_Password;
            }
            else
            {
                txtPassword.PasswordChar = '\0';
                btnEye.Image = Properties.Resources.Hide_Password;
            }
        // =============================================================
        // 7. صور فئات رخص القيادة العشرة (License Classes 1 to 10)
        // =============================================================
        /// <summary>
        /// يرجع أيقونة فئة الرخصة المناسبة حسب المعرف LicenseClassID (من الفئة 1 إلى 10).
        /// </summary>
        public static Image GetLicenseClassImage(int licenseClassID)
        {
            switch (licenseClassID)
            {
                case 1:
                    return Properties.Resources.License_Class_1_Small_Motorcycle;
                case 2:
                    return Properties.Resources.License_Class_2_Heavy_Motorcycle;
                case 3:
                    return Properties.Resources.License_Class_3_Ordinary_Car;
                case 4:
                    return Properties.Resources.License_Class_4_Commercial_Taxi;
                case 5:
                    return Properties.Resources.License_Class_5_Agricultural_Tractor;
                case 6:
                    return Properties.Resources.License_Class_6_Small_Medium_Bus;
                case 7:
                    return Properties.Resources.License_Class_7_Heavy_Truck;
                case 8:
                    return Properties.Resources.License_Class_8_International;
                case 9:
                    return Properties.Resources.License_Class_9_Special_Needs;
                case 10:
                    return Properties.Resources.License_Class_10_Temporary_Learner;
                default:
                    return Properties.Resources.License_Class_3_Ordinary_Car;
            }
        }

        // =============================================================
        // 8. صور شريط القوائم الرئيسي (Main Navigation Icons)
        // =============================================================
        /// <summary>
        /// أيقونة إدارة الأشخاص (People / Manage People) لشريط القوائم الرئيسي.
        /// </summary>
        public static Image People => Properties.Resources.People;
        public static Image ManagePeople => Properties.Resources.Manage_People;
        public static Image Drivers => Properties.Resources.Drivers;
        public static Image Users => Properties.Resources.Users;
        public static Image Applications => Properties.Resources.Applications;

        // =============================================================
        // 9. الأيقونات الذكية الإضافية (Extended 100 Smart-Sized Icons)
        // تم تخمين أنسب حجم واجهة مستخدم لكل أيقونة (16px, 24px, 32px, 48px, 64px, 128px, 256px)
        // =============================================================
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
