using System;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class clsApplicationTypeData
    {
        public static bool GetApplicationTypeInfoByID(int ApplicationTypeID, ref string Title, ref float Fees)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "SELECT * FROM ApplicationTypes WHERE ApplicationTypeID = @ApplicationTypeID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
                                Title = (string)reader["ApplicationTypeTitle"];
                                Fees = Convert.ToSingle(reader["ApplicationFees"]);
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

        public static DataTable GetAllApplicationTypes()
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT * FROM ApplicationTypes ORDER BY ApplicationTypeID";

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

        public static int AddNewApplicationType(string Title, float Fees)
        {
            int ApplicationTypeID = -1;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"INSERT INTO ApplicationTypes (ApplicationTypeTitle, ApplicationFees)
                                 VALUES (@ApplicationTypeTitle, @ApplicationFees);
                                 SELECT SCOPE_IDENTITY();";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ApplicationTypeTitle", Title);
                    command.Parameters.AddWithValue("@ApplicationFees", Fees);

                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            ApplicationTypeID = insertedID;
                        }
                    }
                    catch
                    {
                        ApplicationTypeID = -1;
                    }
                }
            }

            return ApplicationTypeID;
        }

        public static bool UpdateApplicationType(int ApplicationTypeID, string Title, float Fees)
        {
            int rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"UPDATE ApplicationTypes
                                 SET ApplicationTypeTitle = @ApplicationTypeTitle,
                                     ApplicationFees = @ApplicationFees
                                 WHERE ApplicationTypeID = @ApplicationTypeID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
                    command.Parameters.AddWithValue("@ApplicationTypeTitle", Title);
                    command.Parameters.AddWithValue("@ApplicationFees", Fees);

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
