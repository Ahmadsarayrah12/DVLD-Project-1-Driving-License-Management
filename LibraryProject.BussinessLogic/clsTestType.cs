using System;
using System.Data;
using DataAccessLayer;

namespace LibraryProject.BussinessLogic
{
    public class clsTestType
    {
        public enum enMode { AddNew = 0, Update = 1 }
        public enum enTestType { VisionTest = 1, WrittenTest = 2, StreetTest = 3 }

        public enMode Mode = enMode.AddNew;
        public clsTestType.enTestType ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public float Fees { get; set; }

        public clsTestType()
        {
            this.ID = clsTestType.enTestType.VisionTest;
            this.Title = string.Empty;
            this.Description = string.Empty;
            this.Fees = 0;
            this.Mode = enMode.AddNew;
        }

        public clsTestType(clsTestType.enTestType ID, string Title, string Description, float Fees)
        {
            this.ID = ID;
            this.Title = Title;
            this.Description = Description;
            this.Fees = Fees;
            this.Mode = enMode.Update;
        }

        private bool _AddNewTestType()
        {
            int insertedID = clsTestTypeData.AddNewTestType(this.Title, this.Description, this.Fees);
            if (insertedID != -1)
            {
                this.ID = (clsTestType.enTestType)insertedID;
                return true;
            }
            return false;
        }

        private bool _UpdateTestType()
        {
            return clsTestTypeData.UpdateTestType((int)this.ID, this.Title, this.Description, this.Fees);
        }

        public static clsTestType Find(clsTestType.enTestType TestTypeID)
        {
            string Title = string.Empty;
            string Description = string.Empty;
            float Fees = 0;

            if (clsTestTypeData.GetTestTypeInfoByID((int)TestTypeID, ref Title, ref Description, ref Fees))
            {
                return new clsTestType(TestTypeID, Title, Description, Fees);
            }
            else
            {
                return null;
            }
        }

        public static clsTestType Find(int TestTypeID)
        {
            return Find((clsTestType.enTestType)TestTypeID);
        }

        public static DataTable GetAllTestTypes()
        {
            return clsTestTypeData.GetAllTestTypes();
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewTestType())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateTestType();
            }

            return false;
        }
    }
}
