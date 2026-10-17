using System;
using System.Data;
using DataAccessLayer;

namespace LibraryProject.BussinessLogic
{
    public class clsUser
    {
        public enum enMode { AddNew = 0, Update = 1 }

        public enMode Mode { get; private set; } = enMode.AddNew;

        public int UserID { get; set; }
        public int PersonID { get; set; }
        public clsPerson PersonInfo { get; private set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }

        public clsUser()
        {
            this.UserID = -1;
            this.PersonID = -1;
            this.UserName = string.Empty;
            this.Password = string.Empty;
            this.IsActive = true;
            this.PersonInfo = null;

            this.Mode = enMode.AddNew;
        }

        private clsUser(int UserID, int PersonID, string UserName, string Password, bool IsActive)
        {
            this.UserID = UserID;
            this.PersonID = PersonID;
            this.UserName = UserName;
            this.Password = Password;
            this.IsActive = IsActive;
            this.PersonInfo = clsPerson.Find(PersonID);

            this.Mode = enMode.Update;
        }

        private bool _AddNewUser()
        {
            this.UserID = clsUserData.AddUser(this.UserName, this.PersonID, this.Password, this.IsActive);
            return (this.UserID != -1);
        }

        private bool _UpdateUser()
        {
            return clsUserData.UpdateUser(this.UserID, this.PersonID, this.UserName, this.Password, this.IsActive);
        }

        public bool Save()
        {
            switch (this.Mode)
            {
                case enMode.AddNew:
                    if (_AddNewUser())
                    {
                        this.Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateUser();
            }

            return false;
        }

        public static clsUser FindByUserID(int UserID)
        {
            int personID = -1;
            string userName = string.Empty;
            string password = string.Empty;
            bool isActive = false;

            if (clsUserData.GetUserInfoByUserID(UserID, ref personID, ref userName, ref password, ref isActive))
            {
                return new clsUser(UserID, personID, userName, password, isActive);
            }
            else
            {
                return null;
            }
        }

        public static clsUser FindByPersonID(int PersonID)
        {
            int userID = -1;
            string userName = string.Empty;
            string password = string.Empty;
            bool isActive = false;

            if (clsUserData.GetUserInfoByPersonID(PersonID, ref userID, ref userName, ref password, ref isActive))
            {
                return new clsUser(userID, PersonID, userName, password, isActive);
            }
            else
            {
                return null;
            }
        }

        public static clsUser FindByUsernameAndPassword(string UserName, string Password)
        {
            int userID = -1;
            int personID = -1;
            bool isActive = false;

            if (clsUserData.GetUserInfoByUsernameAndPassword(UserName, Password, ref userID, ref personID, ref isActive))
            {
                return new clsUser(userID, personID, UserName, Password, isActive);
            }
            else
            {
                return null;
            }
        }

        public static bool DeleteUser(int UserID)
        {
            return clsUserData.DeleteUser(UserID);
        }

        public static bool IsUserExist(int UserID)
        {
            return clsUserData.IsUserExist(UserID);
        }

        public static bool IsUserExist(string UserName)
        {
            return clsUserData.IsUserExist(UserName);
        }

        public static bool IsUserExistForPersonID(int PersonID)
        {
            return clsUserData.IsUserExistForPersonID(PersonID);
        }

        public static DataTable GetAllUsers()
        {
            return clsUserData.GetAllUsers();
        }

        public bool ChangePassword(string NewPassword)
        {
            if (clsUserData.ChangePassword(this.UserID, NewPassword))
            {
                this.Password = NewPassword;
                return true;
            }
            return false;
        }
    }
}
