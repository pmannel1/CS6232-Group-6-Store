﻿using CS6232_Group_6_Store.Model;
using System.Data.SqlClient;

namespace CS6232_Group_6_Store.DAL
{
    /// <summary>
    /// data access for state table
    /// </summary>
    public class StateDAL
    {

        /// <summary>
        /// Gets the states.
        /// </summary>
        /// <returns></returns>
        public List<State> GetStates()
        {
            List<State> states = new List<State>();

            string selectStatement =
              "SELECT * " +
              "FROM states";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var stateName = reader["stateAbbreviation"].ToString();
                            State state = new State(stateName);
                            states.Add(state);
                        }
                    }
                }
            }
            return states;
        }
    }
}
