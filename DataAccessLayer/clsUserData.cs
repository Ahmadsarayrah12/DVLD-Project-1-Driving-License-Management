using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsUserData
    { 


        
       static public  int AddUser(string Username,int PersonID , string Password,bool IsActive)
        {

            int UserID = -1;


            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
         
                string Query = @"INSERT INTO [dbo].[Users]
                                    ([PersonID],
                                        [UserName],
                                        [Password],
                                        [IsActive])
                                VALUES
                                    (@PersonID,
                                        @UserName,
                                        @Password,
                                        @IsActive);
                                        SELECT SCOPE_IDENTITY();";

              
                using (SqlCommand command = new SqlCommand(Query, connection ))
                {
                    command.Parameters.AddWithValue("@PersonID", PersonID);    
                    command.Parameters.AddWithValue("@UserName", Username);
                    command.Parameters.AddWithValue("@Password", Password);
                    command.Parameters.AddWithValue("@IsActive", IsActive);


                    try
                    {


                        connection.Open();

                        object result = command.ExecuteScalar();

                        if(result !=null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            UserID = insertedID;
                        }

                    }
                    catch
                    {
                        UserID = -1;
                    }

                
                }


            }
            return UserID;

        }



       public static bool IsUserExist(int PersonID)
        {
            bool IsFound=false;


            
          try
           
          {

            
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string Query = @"SELECT TOP 1 1
                                 FROM Users
                                 WHERE PersonID =   @PersonID;";

               
                using(SqlCommand command = new SqlCommand(Query,connection))
                {

                    command.Parameters.AddWithValue("@PersonID", PersonID);
                    connection.Open();
                    object result = command.ExecuteScalar();
                    IsFound = result != null;
                }


            }

          }
          catch
          {
               
                IsFound = false;
          }
            return IsFound;
        }

        

    }
}
