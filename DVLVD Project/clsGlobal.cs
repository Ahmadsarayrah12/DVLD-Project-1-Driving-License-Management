using System;
using System.IO;
using LibraryProject.BussinessLogic;

namespace DVLVD_Project
{
    public static class clsGlobal
    {
      
        public static clsUser CurrentUser;

     
        private static string _GetFilePath()
        {
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            return Path.Combine(folder, "DVLD_LoginData.txt");
        }

      
        public static bool RememberUsernameAndPassword(string username, string password)
        {
            try
            {
                string filePath = _GetFilePath();

                if (string.IsNullOrEmpty(username))
                {
                    if (File.Exists(filePath))
                        File.Delete(filePath);

                    return true;
                }

                string dataToSave = username + "#//#" + password;

                File.WriteAllText(filePath, dataToSave);
                return true;
            }
            catch
            {
                return false;
            }
        }

       
        public static bool GetStoredCredential(ref string username, ref string password)
        {
            try
            {
                string filePath = _GetFilePath();

                if (File.Exists(filePath))
                {
                    string fileContent = File.ReadAllText(filePath);
                    string[] data = fileContent.Split(new string[] { "#//#" }, StringSplitOptions.None);

                    if (data.Length == 2)
                    {
                        username = data[0];
                        password = data[1];
                        return true;
                    }
                }

                return false;
            }
            catch
            {
                return false;
            }
        }
    }
}
