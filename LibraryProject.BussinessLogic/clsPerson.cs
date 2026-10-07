using System;
using DataAccessLayer;

namespace LibraryProject.BussinessLogic
{
    public class clsPerson
    {
        public enum enMode { AddNew = 0, Update = 1 }
        public enum enGender { Male = 0, Female = 1 }

        public enMode Mode { get; private set; } = enMode.AddNew;

        public int PersonID { get; private set; }
        public string NationalNo { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                return string.Format("{0} {1} {2} {3}", FirstName, SecondName, ThirdName, LastName).Trim();
            }
        }
        public DateTime DateOfBirth { get; set; }
        public enGender Gender { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int NationalityCountryID { get; set; }
        public string ImagePath { get; set; }

   
        public clsPerson(int personID, string nationalNo, string firstName, string secondName,
                         string thirdName, string lastName, DateTime dateOfBirth, enGender gender,
                         string address, string phone, string email, int nationalityCountryID, string imagePath)
        {
            this.PersonID = personID;
            this.NationalNo = nationalNo;
            this.FirstName = firstName;
            this.SecondName = secondName;
            this.ThirdName = thirdName;
            this.LastName = lastName;
            this.DateOfBirth = dateOfBirth;
            this.Gender = gender;
            this.Address = address;
            this.Phone = phone;
            this.Email = email;
            this.NationalityCountryID = nationalityCountryID;
            this.ImagePath = imagePath;

            Mode = enMode.Update;
        }

        // Constructor للـ AddNew
        public clsPerson()
        {
            this.PersonID = -1;
            this.NationalNo = string.Empty;
            this.FirstName = string.Empty;
            this.SecondName = string.Empty;
            this.ThirdName = string.Empty;
            this.LastName = string.Empty;
            this.DateOfBirth = DateTime.MinValue;
            this.Gender = enGender.Male;
            this.Address = string.Empty;
            this.Phone = string.Empty;
            this.Email = string.Empty;
            this.NationalityCountryID = -1;
            this.ImagePath = string.Empty;

            Mode = enMode.AddNew;
        }

        private bool _AddPerson()
        {
            this.PersonID = clsPersonData.AddPerson(
                NationalNo, FirstName, SecondName, ThirdName, LastName,
                DateOfBirth, (byte)Gender, Address, Phone, Email,
                NationalityCountryID, ImagePath
            );

            return (this.PersonID != -1);
        }

        private bool _UpdatePerson()
        {
            return clsPersonData.UpdatePerson(
                PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName,
                DateOfBirth, (byte)Gender, Address, Phone, Email,
                NationalityCountryID, ImagePath
            );
        }

        public static clsPerson Find(int PersonID)
        {
            string nationalNo = "", firstName = "", secondName = "", thirdName = "", lastName = "";
            DateTime dateOfBirth = DateTime.Now;
            byte gender = 0;
            string address = "", phone = "", email = "", imagePath = "";
            int nationalityCountryID = -1;

            if (clsPersonData.GetPersonInfoByID(PersonID, ref nationalNo, ref firstName, ref secondName, ref thirdName, ref lastName, ref dateOfBirth, ref gender, ref address, ref phone, ref email, ref nationalityCountryID, ref imagePath))
            {
                return new clsPerson(PersonID, nationalNo, firstName, secondName, thirdName, lastName, dateOfBirth, (enGender)gender, address, phone, email, nationalityCountryID, imagePath);
            }
            else
            {
                return null;
            }
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddPerson())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return _UpdatePerson();
                default:
                    return false;
            }
        }
        public static System.Data.DataTable GetAllPeople()
        {
            return clsPersonData.GetAllPeople();
        }
        public static bool DeletePerson(int PersonID)
        {
            return clsPersonData.DeletePerson(PersonID);
        }

        public static clsPerson Find(string NationalNo)
        {
            int PersonID = -1;
            string FirstName = "", SecondName = "", ThirdName = "", LastName = "", Address = "", Phone = "", Email = "", ImagePath = "";
            DateTime DateOfBirth = DateTime.Now;
            int NationalityCountryID = -1;
            byte Gender = 0;

            if (clsPersonData.GetPersonInfoByNationalNo(NationalNo, ref PersonID, ref FirstName, ref SecondName, ref ThirdName, ref LastName, ref DateOfBirth, ref Gender, ref Address, ref Phone, ref Email, ref NationalityCountryID, ref ImagePath))
            {
                return new clsPerson(PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, (enGender)Gender, Address, Phone, Email, NationalityCountryID, ImagePath);
            }
            else
            {
                return null;
            }
        }

        public static bool isPersonExist(int PersonID)
        {
            return clsPersonData.IsPersonExist(PersonID);
        }

        public static bool isPersonExist(string NationalNo)
        {
            return clsPersonData.IsPersonExist(NationalNo);
        }
    }
}