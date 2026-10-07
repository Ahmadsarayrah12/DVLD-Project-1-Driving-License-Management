using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsPersonData
    {

        public static int   AddPerson(string NationalNo, string FirstName, string SecondName, string ThirdName, string LastName, DateTime DateOfBirth, byte Gender
                             , string Address, string Phone, string Email, int NationalityCountryID, string ImagePath)
        {
            int PersonID = -1;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"INSERT INTO [dbo].[People]
                                ([NationalNo]
                                ,[FirstName]
                                ,[SecondName]
                                ,[ThirdName]
                                ,[LastName]
                                ,[DateOfBirth]
                                ,[Gender]
                                ,[Address]
                                ,[Phone]
                                ,[Email]
                                ,[NationalityCountryID]
                                ,[ImagePath])
                            VALUES
                                (@NationalNo 
                                ,@FirstName 
                                ,@SecondName 
                                ,@ThirdName
                                ,@LastName
                                ,@DateOfBirth
                                ,@Gender
                                ,@Address
                                ,@Phone
                                ,@Email
                                ,@NationalityCountryID
                                ,@ImagePath);
                                SELECT SCOPE_IDENTITY();";


                using (SqlCommand command =new  SqlCommand(query,connection)) 
                {

                    command.Parameters.AddWithValue ("@NationalNo", NationalNo);
                    command.Parameters.AddWithValue("@FirstName", FirstName);
                    command.Parameters.AddWithValue("@SecondName", SecondName);
                    if (string.IsNullOrWhiteSpace(ThirdName))
                        command.Parameters.AddWithValue("@ThirdName", DBNull.Value);
                    else
                        command.Parameters.AddWithValue("@ThirdName", ThirdName.Trim());

                    command.Parameters.AddWithValue("@LastName", LastName);
                    command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                    command.Parameters.AddWithValue("@Gender", Gender);
                    command.Parameters.AddWithValue("@Address", Address);
                    command.Parameters.AddWithValue("@Phone", Phone);
                    command.Parameters.AddWithValue("@Email", Email);
                    command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);
                    if (string.IsNullOrEmpty(ImagePath))
                        command.Parameters.AddWithValue("@ImagePath", DBNull.Value);
                    else
                        command.Parameters.AddWithValue("@ImagePath", ImagePath);

                    try
                    {
                        connection.Open();

                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(),out int insertedID))
                        {

                            PersonID = insertedID;
                        }

                    }
                    catch 
                    {

                        PersonID = -1;
                    }

                }

            }
            return PersonID;



        }

        public static bool GetPersonInfoByID(int PersonID, ref string NationalNo, ref string FirstName, ref string SecondName, ref string ThirdName, ref string LastName, ref DateTime DateOfBirth, ref byte Gender, ref string Address, ref string Phone, ref string Email, ref int NationalityCountryID, ref string ImagePath)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "SELECT * FROM People WHERE PersonID = @PersonID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PersonID", PersonID);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
                                NationalNo = (string)reader["NationalNo"];
                                FirstName = (string)reader["FirstName"];
                                SecondName = (string)reader["SecondName"];
                                ThirdName = reader["ThirdName"] != DBNull.Value ? (string)reader["ThirdName"] : "";
                                LastName = (string)reader["LastName"];
                                DateOfBirth = (DateTime)reader["DateOfBirth"];
                                Gender = (byte)reader["Gender"];
                                Address = (string)reader["Address"];
                                Phone = (string)reader["Phone"];
                                Email = reader["Email"] != DBNull.Value ? (string)reader["Email"] : "";
                                NationalityCountryID = (int)reader["NationalityCountryID"];
                                ImagePath = reader["ImagePath"] != DBNull.Value ? (string)reader["ImagePath"] : "";
                            }
                        }
                    }
                    catch { isFound = false; }
                }
            }
            return isFound;
        }

        public static bool UpdatePerson(int PersonID, string NationalNo, string FirstName, string SecondName, string ThirdName, string LastName, DateTime DateOfBirth, byte Gender, string Address, string Phone, string Email, int NationalityCountryID, string ImagePath)
        {
            int rowsAffected = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"UPDATE [dbo].[People]
                                 SET [NationalNo] = @NationalNo
                                    ,[FirstName] = @FirstName
                                    ,[SecondName] = @SecondName
                                    ,[ThirdName] = @ThirdName
                                    ,[LastName] = @LastName
                                    ,[DateOfBirth] = @DateOfBirth
                                    ,[Gender] = @Gender
                                    ,[Address] = @Address
                                    ,[Phone] = @Phone
                                    ,[Email] = @Email
                                    ,[NationalityCountryID] = @NationalityCountryID
                                    ,[ImagePath] = @ImagePath
                                 WHERE PersonID = @PersonID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PersonID", PersonID);
                    command.Parameters.AddWithValue("@NationalNo", NationalNo);
                    command.Parameters.AddWithValue("@FirstName", FirstName);
                    command.Parameters.AddWithValue("@SecondName", SecondName);
                    if (string.IsNullOrWhiteSpace(ThirdName))
                        command.Parameters.AddWithValue("@ThirdName", DBNull.Value);
                    else
                        command.Parameters.AddWithValue("@ThirdName", ThirdName.Trim());

                    command.Parameters.AddWithValue("@LastName", LastName);
                    command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                    command.Parameters.AddWithValue("@Gender", Gender);
                    command.Parameters.AddWithValue("@Address", Address);
                    command.Parameters.AddWithValue("@Phone", Phone);
                    command.Parameters.AddWithValue("@Email", Email);
                    command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);
                    if (string.IsNullOrEmpty(ImagePath))
                        command.Parameters.AddWithValue("@ImagePath", DBNull.Value);
                    else
                        command.Parameters.AddWithValue("@ImagePath", ImagePath);

                    try
                    {
                        connection.Open();
                        rowsAffected = command.ExecuteNonQuery();
                    }
                    catch { return false; }
                }
            }
            return (rowsAffected > 0);
        }
        public static System.Data.DataTable GetAllPeople()
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"SELECT Countries.*, People.*
                                     FROM People 
                                     INNER JOIN Countries ON People.NationalityCountryID = Countries.CountryID
                                     ORDER BY People.PersonID DESC";
                    
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dt.Load(reader);
                            }
                        }
                    }
                }
            }
            catch { }
            return dt;
        }
        public static bool DeletePerson(int PersonID)
        {
            int rowsAffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "DELETE FROM People WHERE PersonID = @PersonID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PersonID", PersonID);
                        connection.Open();
                        rowsAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch { }
            return (rowsAffected > 0);
        }
        public static bool GetPersonInfoByNationalNo(string NationalNo, ref int PersonID, ref string FirstName, ref string SecondName, ref string ThirdName, ref string LastName, ref DateTime DateOfBirth, ref byte Gender, ref string Address, ref string Phone, ref string Email, ref int NationalityCountryID, ref string ImagePath)
        {
            bool isFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT * FROM People WHERE NationalNo = @NationalNo";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@NationalNo", NationalNo);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
                                PersonID = (int)reader["PersonID"];
                                FirstName = (string)reader["FirstName"];
                                SecondName = (string)reader["SecondName"];
                                ThirdName = reader["ThirdName"] != DBNull.Value ? (string)reader["ThirdName"] : "";
                                LastName = (string)reader["LastName"];
                                DateOfBirth = (DateTime)reader["DateOfBirth"];
                                Gender = (byte)reader["Gender"];
                                Address = (string)reader["Address"];
                                Phone = (string)reader["Phone"];
                                Email = reader["Email"] != DBNull.Value ? (string)reader["Email"] : "";
                                NationalityCountryID = (int)reader["NationalityCountryID"];
                                ImagePath = reader["ImagePath"] != DBNull.Value ? (string)reader["ImagePath"] : "";
                            }
                        }
                    }
                }
            }
            catch { isFound = false; }
            return isFound;
        }

        public static bool IsPersonExist(int PersonID)
        {
            bool isFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT 1 FROM People WHERE PersonID = @PersonID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PersonID", PersonID);
                        connection.Open();
                        object result = command.ExecuteScalar();
                        isFound = (result != null);
                    }
                }
            }
            catch { }
            return isFound;
        }

        public static bool IsPersonExist(string NationalNo)
        {
            bool isFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT 1 FROM People WHERE NationalNo = @NationalNo";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@NationalNo", NationalNo);
                        connection.Open();
                        object result = command.ExecuteScalar();
                        isFound = (result != null);
                    }
                }
            }
            catch { }
            return isFound;
        }
    }
}
