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
        /// Returns the Members.
        /// </summary>
        /// <returns></returns>
        public List<Member> ReturnMembersSearch(int searchItem)
        {
            List<Member> memberList = new List<Member>();
            string selectStatement =
                "SELECT members.* " +
                "FROM members " +
                "WHERE members.id = @searchItem ";


            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.Add("@searchItem", SqlDbType.Int);
                    selectCommand.Parameters["@searchItem"].Value = searchItem;
                    
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
            string updateStatement =
              "INSERT INTO members(lastName, firstName, sex, dob, street, city, state, zipCode, country, contactPhone, password) " +
              "VALUES(@lName, @fName, @sex, @dob, @street, @city, @state, @zipCode, @country, @contactPhone, @password);";
            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        using (SqlCommand updateCommand = new SqlCommand(updateStatement, connection, transaction))
                        {
                            updateCommand.Parameters.Add("@lName", SqlDbType.VarChar);
                            updateCommand.Parameters["@lName"].Value = member.LastName;

                            updateCommand.Parameters.Add("@fName", SqlDbType.VarChar);
                            updateCommand.Parameters["@fName"].Value = member.FirstName;

                            updateCommand.Parameters.Add("@sex", SqlDbType.VarChar);
                            updateCommand.Parameters["@sex"].Value = member.Sex;

                            updateCommand.Parameters.Add("@dob", SqlDbType.DateTime2);
                            updateCommand.Parameters["@dob"].Value = member.DateOfBirth;

                            updateCommand.Parameters.Add("@street", SqlDbType.VarChar);
                            updateCommand.Parameters["@street"].Value = member.StreetAddress;

                            updateCommand.Parameters.Add("@city", SqlDbType.VarChar);
                            updateCommand.Parameters["@city"].Value = member.City;

                            updateCommand.Parameters.Add("@state", SqlDbType.VarChar);
                            updateCommand.Parameters["@state"].Value = member.State;

                            updateCommand.Parameters.Add("@zipCode", SqlDbType.VarChar);
                            updateCommand.Parameters["@zipCode"].Value = member.ZipCode.ToString();

                            updateCommand.Parameters.Add("@country", SqlDbType.VarChar);
                            updateCommand.Parameters["@country"].Value = member.Country;

                            updateCommand.Parameters.Add("@contactPhone", SqlDbType.VarChar);
                            updateCommand.Parameters["@contactPhone"].Value = member.ContactPhone;

                            updateCommand.Parameters.Add("@password", SqlDbType.VarChar);
                            updateCommand.Parameters["@password"].Value = member.Password;

                            updateCommand.ExecuteScalar();
                        }

                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
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
                "SET lastName = @lName, firstName = @fName, sex = @sex, dob = @dob, street = @sAddress, " +
                "city = @city, state = @state, zipCode = @zip, country = @country, contactPhone = @pNum, " +
                "password = @pWord " +
                "WHERE id = @id;";
            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        using (SqlCommand updateCommand = new SqlCommand(updateStatement, connection, transaction))
                        {
                            updateCommand.Parameters.Add("@id", SqlDbType.Int);
                            updateCommand.Parameters["@id"].Value = member.Id;

                            updateCommand.Parameters.Add("@lName", SqlDbType.NVarChar);
                            updateCommand.Parameters["@lName"].Value = member.LastName;

                            updateCommand.Parameters.Add("@fName", SqlDbType.VarChar);
                            updateCommand.Parameters["@fName"].Value = member.FirstName;

                            updateCommand.Parameters.Add("@sex", SqlDbType.VarChar);
                            updateCommand.Parameters["@sex"].Value = member.Sex;

                            updateCommand.Parameters.Add("@dob", SqlDbType.DateTime2);
                            updateCommand.Parameters["@dob"].Value = member.DateOfBirth;

                            updateCommand.Parameters.Add("@sAddress", SqlDbType.VarChar);
                            updateCommand.Parameters["@sAddress"].Value = member.StreetAddress;

                            updateCommand.Parameters.Add("@city", SqlDbType.VarChar);
                            updateCommand.Parameters["@city"].Value = member.City;

                            updateCommand.Parameters.Add("@state", SqlDbType.VarChar);
                            updateCommand.Parameters["@state"].Value = member.State;

                            updateCommand.Parameters.Add("@zip", SqlDbType.VarChar);
                            updateCommand.Parameters["@zip"].Value = member.ZipCode.ToString();

                            updateCommand.Parameters.Add("@country", SqlDbType.VarChar);
                            updateCommand.Parameters["@country"].Value = member.Country;

                            updateCommand.Parameters.Add("@pNum", SqlDbType.VarChar);
                            updateCommand.Parameters["@pNum"].Value = member.ContactPhone;

                            updateCommand.Parameters.Add("@pWord", SqlDbType.VarChar);
                            updateCommand.Parameters["@pWord"].Value = member.Password;


                            updateCommand.ExecuteNonQuery();
                        }

                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }


            }
        }

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
                            "WHERE firstName = @FirstName AND lastName LIKE @LastName + '%'";
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
                        "WHERE contactPhone LIKE @SearchTerm ";

                    selectCommand = new SqlCommand(selectStatement, connection);
                    selectCommand.Parameters.Add("@SearchTerm", SqlDbType.NVarChar);
                    selectCommand.Parameters["@SearchTerm"].Value = "%" + search.Trim() + "%";
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









