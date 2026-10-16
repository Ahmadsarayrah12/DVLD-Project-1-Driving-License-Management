using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using LibraryProject.BussinessLogic;



namespace LibraryProject.BussinessLogic
{
    public class clsUser
    {

        public enum enMode {addUser =0, updateUser = 1};

        enMode _Mode = enMode.addUser;

        public string UserName { get; set; }

        public int UserID { get; set; }
        public int PersonID { get; set; }
        public bool IsActive { get; set; }



        public clsUser ()
        {
            UserName = string.Empty;
            UserID = -1;
            PersonID = -1;
            IsActive = false;
            _Mode = enMode.addUser;


        }


        public bool addUser(int UserID,int PersonID,string Username,bool IsActive,string password )
        {
            this.UserName = Username;
            
            this.PersonID = PersonID;
            this.IsActive = IsActive;

            this.UserID = clsUserData.AddUser(Username, PersonID, password, IsActive);

            return this.UserID >0 ;

        }
        
       static public bool IsUserExistForPersonID(int personID)
        {
          return  clsUserData.IsUserExist(personID);
        }


    }
}
