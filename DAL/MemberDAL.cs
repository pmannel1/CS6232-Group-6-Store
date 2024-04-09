using CS6232_Group_6_Store.Model;
using System.Data.SqlClient;
using System.Data;


namespace CS6232_Group_6_Store.DAL
{
    /// <summary>
    /// Member table data access class
    /// </summary>
    public class MemberDAL
    {

        /// <summary>
        /// Returns the Members.
        /// </summary>
        /// <returns></returns>
        public List<Member> ReturnMembers()
        {
            List<Member> memberList = new List<Member>();
            string selectStatement =
                "SELECT members.* " +
                "FROM members " ;


            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var id = int.Parse(reader["id"].ToString());
                            var firstName = reader["firstName"].ToString();
                            var lastName = reader["lastName"].ToString();
                            var sex = reader["sex"].ToString();
                            var dateOfBirth = (DateTime)reader["dob"];
                            var street = reader["street"].ToString();
                            var city = reader["city"].ToString();
                            var state = reader["state"].ToString();
                            var zipCode = Convert.ToInt32(reader["zipCode"]);
                            var country = reader["country"].ToString();
                            var contactPhone = reader["contactPhone"].ToString();
                            var password = reader["password"].ToString();
                            Member member = new Member(id, lastName, firstName, dateOfBirth, street, city, state, zipCode, country, contactPhone, password, sex);
                            memberList.Add(member);
                        }
                    }
                }
            }

            return memberList;
        }
        

        /// <summary>
        /// Adds the member.
        /// </summary>
        /// <param name="member">The member.</param>
        public void AddMember(Member member)
        {
            string insertStatement =
                "INSERT INTO members(lastName, firstName, sex, dob, street, city, state, zipCode, country, contactPhone, password) " +
                "VALUES(@lName, @fName, @sex, @dob, @street, @city, @state, @zipCode, @country, @contactPhone, @password);";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand insertCommand = new SqlCommand(insertStatement, connection))
                {
                    insertCommand.Parameters.AddWithValue("@lName", member.LastName);
                    insertCommand.Parameters.AddWithValue("@fName", member.FirstName);
                    insertCommand.Parameters.AddWithValue("@sex", member.Sex);
                    insertCommand.Parameters.AddWithValue("@dob", member.DateOfBirth);
                    insertCommand.Parameters.AddWithValue("@street", member.StreetAddress);
                    insertCommand.Parameters.AddWithValue("@city", member.City);
                    insertCommand.Parameters.AddWithValue("@state", member.State);
                    insertCommand.Parameters.AddWithValue("@zipCode", member.ZipCode.ToString());
                    insertCommand.Parameters.AddWithValue("@country", member.Country);
                    insertCommand.Parameters.AddWithValue("@contactPhone", member.ContactPhone);
                    insertCommand.Parameters.AddWithValue("@password", member.Password);

                    insertCommand.ExecuteNonQuery();
                }
            }
        }


        /// <summary>
        /// Gets the open incidents.
        /// </summary>
        /// <returns></returns>
        public Member RetrieveMember(int id)
        {
            Member member = null;
            string selectStatement =
               "SELECT members.* " +
               "FROM members " +
               "WHERE members.id = @id ";


            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.Add("@id", SqlDbType.Int);
                    selectCommand.Parameters["@id"].Value = id;

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var firstName = reader["firstName"].ToString();
                            var lastName = reader["lastName"].ToString();
                            var sex = reader["sex"].ToString();
                            var dateOfBirth = (DateTime)reader["dob"];
                            var street = reader["street"].ToString();
                            var city = reader["city"].ToString();
                            var state = reader["state"].ToString();
                            var zipCode = Convert.ToInt32(reader["zipCode"]);
                            var country = reader["country"].ToString();
                            var contactPhone = reader["contactPhone"].ToString();
                            var password = reader["password"].ToString();
                            member = new Member(id, lastName, firstName, dateOfBirth, street, city, state, zipCode, country, contactPhone, password, sex);
                        }
                    }
                }
            }
            return member;
        }

        /// <summary>
        /// Updates the member.
        /// </summary>
        /// <param name="member">The member.</param>
        public void UpdateMember(Member member)
        {
            string updateStatement =
                "UPDATE  members " +
                "SET lastName = @lastName, firstName = @firstName, sex = @sex, dob = @dob, street = @streetAddress, " +
                "city = @city, state = @state, zipCode = @zipCode, country = @country, contactPhone = @contactPhone, " +
                "password = @password " +
                "WHERE id = @id;";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand insertCommand = new SqlCommand(updateStatement, connection))
                {
                    insertCommand.Parameters.AddWithValue("@id", member.Id);
                    insertCommand.Parameters.AddWithValue("@lastName", member.LastName);
                    insertCommand.Parameters.AddWithValue("@firstName", member.FirstName);
                    insertCommand.Parameters.AddWithValue("@sex", member.Sex);
                    insertCommand.Parameters.AddWithValue("@dob", member.DateOfBirth);
                    insertCommand.Parameters.AddWithValue("@streetAddress", member.StreetAddress);
                    insertCommand.Parameters.AddWithValue("@city", member.City);
                    insertCommand.Parameters.AddWithValue("@state", member.State);
                    insertCommand.Parameters.AddWithValue("@zipCode", member.ZipCode.ToString());
                    insertCommand.Parameters.AddWithValue("@country", member.Country);
                    insertCommand.Parameters.AddWithValue("@contactPhone", member.ContactPhone);
                    insertCommand.Parameters.AddWithValue("@password", member.Password);

                    insertCommand.ExecuteNonQuery();
                }
            }
        }


        /// <summary>
        /// Searches the member.
        /// </summary>
        /// <param name="method">The method.</param>
        /// <param name="search">The search.</param>
        /// <returns></returns>
        public List<Member> SearchMember(string method, string search)
        {
            List<Member> memberList = new List<Member>();
            string selectStatement;
            SqlCommand selectCommand;

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                if (method == "Name")
                {
                    string[] names = search.Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    string firstName = names.Length > 0 ? names[0] : "";
                    string lastName = names.Length > 1 ? names[1] : "";

                    // Check if only one name part is provided and it's more than one character
                    if ((firstName.Length > 1 && lastName == "") || (lastName.Length > 1 && firstName == ""))
                    {
                        selectStatement =
                            "SELECT members.* " +
                            "FROM members " +
                            "WHERE firstName = @FirstName OR lastName = @LastName";
                        firstName = firstName.Length > 1 ? firstName : lastName;
                        
                    }
                    
                    // If both full first name and last name are provided.
                    else
                    {
                        selectStatement =
                            "SELECT members.* " +
                            "FROM members " +
                            "WHERE firstName = @FirstName AND lastName = @LastName";
                    }

                    selectCommand = new SqlCommand(selectStatement, connection);
                    selectCommand.Parameters.Add("@FirstName", SqlDbType.NVarChar);
                    selectCommand.Parameters["@FirstName"].Value = firstName;
                    selectCommand.Parameters.Add("@LastName", SqlDbType.NVarChar);
                    selectCommand.Parameters["@LastName"].Value = lastName != "" ? lastName : firstName;
                }
                else if ( method == "ID")
                {
                   selectStatement =
                        "SELECT members.* " +
                        "FROM members " +
                        "WHERE members.id = @SearchTerm ";

                    selectCommand = new SqlCommand(selectStatement, connection);
                    selectCommand.Parameters.Add("@SearchTerm", SqlDbType.Int);
                    selectCommand.Parameters["@SearchTerm"].Value = search;
                } else
                {
                   selectStatement =
                        "SELECT members.* " +
                        "FROM members " +
                        "WHERE contactPhone = @SearchTerm ";

                    selectCommand = new SqlCommand(selectStatement, connection);
                    selectCommand.Parameters.Add("@SearchTerm", SqlDbType.NVarChar);
                    selectCommand.Parameters["@SearchTerm"].Value = search;
                }
                using (SqlDataReader reader = selectCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var id = int.Parse(reader["id"].ToString());
                        var firstName = reader["firstName"].ToString();
                        var lastName = reader["lastName"].ToString();
                        var sex = reader["sex"].ToString();
                        var dateOfBirth = (DateTime)reader["dob"];
                        var street = reader["street"].ToString();
                        var city = reader["city"].ToString();
                        var state = reader["state"].ToString();
                        var zipCode = Convert.ToInt32(reader["zipCode"]);
                        var country = reader["country"].ToString();
                        var contactPhone = reader["contactPhone"].ToString();
                        var password = reader["password"].ToString();
                        Member member = new Member(id, lastName, firstName, dateOfBirth, street, city, state, zipCode, country, contactPhone, password, sex);
                        memberList.Add(member);
                    }
                }
            }
            return memberList;
        }
    }
}









