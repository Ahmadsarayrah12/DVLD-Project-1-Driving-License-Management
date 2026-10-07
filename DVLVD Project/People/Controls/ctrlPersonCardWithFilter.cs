using System;
using System.Windows.Forms;
using LibraryProject.BussinessLogic;

namespace DVLVD_Project.UserControls
{
    public partial class ctrlPersonCardWithFilter : UserControl
    {
        // حدث بسيط (Event) نخبر فيه الشاشات الأخرى أنه تم العثور على شخص
        public event Action<int> OnPersonSelected;

        public ctrlPersonCardWithFilter()
        {
            InitializeComponent();
        }

        // خاصية بسيطة لجلب رقم الشخص الحالي المعروض في الكارد
        public int PersonID
        {
            get { return ctrlPersonCard1.PersonID; }
        }

        // خاصية بسيطة لجلب بيانات الشخص الحالي بالكامل
        public clsPerson SelectedPersonInfo
        {
            get { return ctrlPersonCard1.SelectedPersonInfo; }
        }

        private void ctrlPersonCardWithFilter_Load(object sender, EventArgs e)
        {
            // عند تحميل الشاشة، نختار "National No." كطريقة بحث افتراضية
            cbFilterBy.SelectedIndex = 0; 
            txtFilterValue.Focus();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            // التحقق من أن المستخدم أدخل قيمة للبحث
            if (string.IsNullOrEmpty(txtFilterValue.Text.Trim()))
            {
                MessageBox.Show("Please enter a value to search for!", "Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // إذا كان البحث باستخدام رقم الشخص (Person ID)
            if (cbFilterBy.Text == "Person ID")
            {
                int personID;
                if (int.TryParse(txtFilterValue.Text, out personID))
                {
                    ctrlPersonCard1.LoadPersonInfo(personID);
                }
                else
                {
                    MessageBox.Show("Please enter a valid number for Person ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            // إذا كان البحث باستخدام الرقم الوطني (National No.)
            else if (cbFilterBy.Text == "National No.")
            {
                // نبحث عن الشخص أولاً لنجلب رقمه (PersonID)
                clsPerson person = clsPerson.Find(txtFilterValue.Text.Trim());
                if (person != null)
                {
                    // إذا وجدناه، نرسل رقمه للكارد ليقوم بعرضه
                    ctrlPersonCard1.LoadPersonInfo(person.PersonID);
                }
                else
                {
                    MessageBox.Show("No person found with this National No.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ctrlPersonCard1.ResetPersonInfo();
                }
            }

            // إذا تم العثور على شخص بنجاح، نقوم بإطلاق الحدث (Event) لتستفيد منه الشاشات الأخرى
            if (OnPersonSelected != null && ctrlPersonCard1.PersonID != -1)
            {
                OnPersonSelected(ctrlPersonCard1.PersonID);
            }
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            // فتح شاشة إضافة شخص جديد
            frmAddEditPerson frm = new frmAddEditPerson(-1);
            frm.ShowDialog();

            // ملاحظة للمبتدئ: في الدروس القادمة سنقوم بربط الـ Delegate 
            // بحيث عندما يتم إضافة الشخص، يظهر تلقائياً في الكارد هنا.
            MessageBox.Show("If you added a new person, you can now search for them using their National No.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
