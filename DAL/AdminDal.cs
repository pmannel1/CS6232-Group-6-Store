using System.Data.SqlClient;
using System.Data;


namespace CS6232_Group_6_Store.DAL
{
    internal class AdminDal
    {
        public DataTable ExecuteGetMostPopularFurnitureDuringDates(DateTime parameter1, DateTime parameter2)
        {
            DataTable dataTable = new DataTable();
            string storedProcedureName = "getMostPopularFurnitureDuringDates";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(storedProcedureName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("@startDate", SqlDbType.Date).Value = parameter1;
                    command.Parameters.Add("@endDate", SqlDbType.Date).Value = parameter2;

                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTable);
                }
            }
            return dataTable;
        }
    }
}