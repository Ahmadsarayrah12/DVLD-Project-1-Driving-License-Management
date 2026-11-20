using System;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class clsTestTypeData
    {
        public static bool GetTestTypeInfoByID(int TestTypeID, ref string Title, ref string Description, ref float Fees)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "SELECT * FROM TestTypes WHERE TestTypeID = @TestTypeID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
                                Title = (string)reader["TestTypeTitle"];
                                Description = (string)reader["TestTypeDescription"];
                                Fees = Convert.ToSingle(reader["TestTypeFees"]);
                            }
                        }
                    }
                    catch
                    {
                        isFound = false;
                    }
                }
            }

            return isFound;
        }

        public static DataTable GetAllTestTypes()
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT * FROM TestTypes ORDER BY TestTypeID";

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
            catch
            {
            }

            return dt;
        }

        public static int AddNewTestType(string Title, string Description, float Fees)
        {
            int testTypeID = -1;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"INSERT INTO TestTypes (TestTypeTitle, TestTypeDescription, TestTypeFees)
                                 VALUES (@TestTypeTitle, @TestTypeDescription, @TestTypeFees);
                                 SELECT SCOPE_IDENTITY();";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TestTypeTitle", Title);
                    command.Parameters.AddWithValue("@TestTypeDescription", Description);
                    command.Parameters.AddWithValue("@TestTypeFees", Fees);

                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            testTypeID = insertedID;
                        }
                    }
                    catch
                    {
                        testTypeID = -1;
                    }
                }
            }

            return testTypeID;
        }

        public static bool UpdateTestType(int TestTypeID, string Title, string Description, float Fees)
        {
            int rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"UPDATE TestTypes
                                 SET TestTypeTitle = @TestTypeTitle,
                                     TestTypeDescription = @TestTypeDescription,
                                     TestTypeFees = @TestTypeFees
                                 WHERE TestTypeID = @TestTypeID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
                    command.Parameters.AddWithValue("@TestTypeTitle", Title);
                    command.Parameters.AddWithValue("@TestTypeDescription", Description);
                    command.Parameters.AddWithValue("@TestTypeFees", Fees);

                    try
                    {
                        connection.Open();
                        rowsAffected = command.ExecuteNonQuery();
                    }
                    catch
                    {
                        return false;
                    }
                }
            }

            return (rowsAffected > 0);
        }
    }
}
