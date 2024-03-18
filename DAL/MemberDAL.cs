using CS6232_Group_6_Store.Model;
using System.Data.SqlClient;
using System.Data;


namespace CS6232_Group_6_Store.DAL
{
    public class MemberDAL
    {
        /// <summary>
        /// Returns the Members.
        /// </summary>
        /// <returns></returns>
        public List<Member> ReturnMemberNames()
        {
            List<Member> memberList = new List<Member>();
            string selectStatement =
               "SELECT  firstName, LastName " +
               "FROM members ";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            var firstName = Convert.IsDBNull(reader["firstName"]) ? "" : reader["firstName"].ToString();
                            var lastName = Convert.IsDBNull(reader["lastName"]) ? "" : reader["lastName"].ToString();

                            Member member = new Member();
                            member.LastName = lastName;
                            member.FirstName = firstName;
                            memberList.Add(member);
                        }

                    }
                }
            }

            return memberList;
        }

        /// <summary>
        /// Retruns the members.
        /// </summary>
        /// <param name="searchMethod">The search method.</param>
        /// <param name="searchField">The search field.</param>
        /// <returns></returns>
        public List<Member> RetrunMembers(string searchMethod, string searchField)
        {
            List<Member> memberList = new List<Member>();
            string selectStatement =
              "SELECT * " +
              "FROM members ";
            string lastName = null;
            string firstName = null;
            if (searchMethod != null && searchField != null)
            {
                selectStatement = "select id,lastName,firstName,sex,dob," +
                    "Street,City,State,zipCode,country, contactPhone  FROM members where ";
                if (searchMethod == "Name")
                {

                    int lnameLength = searchField.IndexOf(" ");
                    int nameLength = searchField.Length;

                    if (lnameLength == -1 && nameLength > 0)
                    {
                        lastName = searchField.Substring(0, nameLength);
                    }
                    else
                    {
                        lastName = searchField.Substring(0, lnameLength);
                    }

                    if (lnameLength >= 0 && nameLength > lnameLength)
                    {
                        firstName = searchField.Substring(lnameLength + 1, nameLength - (lnameLength + 1));
                    }


                    if ((lastName != null && lastName != "") && (firstName != null && firstName != ""))
                    {
                       
                        selectStatement += " lastName = @lastName and firstName =  @firstname  ";
                    }
                 

                }
                else if (searchMethod == "Id")
                {
                    selectStatement += " Id = @searchField";
                }
                else if (searchMethod == "Phone")
                {
                    selectStatement += " contactPhone = @searchField";
                }

            }

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    if (searchMethod == "Name")
                    {

                        if (lastName != null && lastName != "" && firstName != null && firstName != "")
                        {
                            selectCommand.Parameters.Add("@lastName", System.Data.SqlDbType.VarChar);
                            selectCommand.Parameters["@lastName"].Value = lastName.Trim();
                            selectCommand.Parameters.Add("@firstname", System.Data.SqlDbType.VarChar);
                            selectCommand.Parameters["@firstname"].Value = firstName.Trim();
                        }
                     
                    }
                    else if (searchMethod == "Phone")
                    {
                        selectCommand.Parameters.Add("@searchField", System.Data.SqlDbType.VarChar);
                        selectCommand.Parameters["@searchField"].Value = searchField;
                    }
                    else if (searchMethod == "Id")
                    {
                        selectCommand.Parameters.Add("@searchField", System.Data.SqlDbType.VarChar);
                        selectCommand.Parameters["@searchField"].Value = searchField;
                    }


                    using (SqlDataReader reader = selectCommand.ExecuteReader())

                    {
                        while (reader.Read())
                        {



                            Member member = new Member();
                            member.Id = Convert.ToInt32(Convert.IsDBNull(reader["id"]) ? 0 : reader["id"]);

                            member.LastName = Convert.IsDBNull(reader["lastName"]) ? "" : reader["lastName"].ToString();
                            member.FirstName = Convert.IsDBNull(reader["firstName"]) ? "" : reader["firstName"].ToString();
                            member.DateOfBirth = Convert.ToDateTime(Convert.IsDBNull(reader["dob"]) ? null : reader["dob"]);
                            member.StreetAddress = Convert.IsDBNull(reader["street"]) ? "" : reader["street"].ToString();
                            member.City = Convert.IsDBNull(reader["City"]) ? "" : reader["City"].ToString();
                            member.State = Convert.IsDBNull(reader["State"]) ? "" : reader["State"].ToString();
                            member.ZipCode = Convert.ToInt32( Convert.IsDBNull(reader["zipCode"]) ? 0 : reader["zipCode"]);
                            member.Country = Convert.IsDBNull(reader["country"]) ? "" : reader["country"].ToString();
                            member.ContactPhone = Convert.IsDBNull(reader["ContactPhone"]) ? "" : reader["ContactPhone"].ToString();

                            memberList.Add(member);
                        }

                    }
                }
            }

            return memberList;
        }

        public static void AddDBMember(string firstName, string lastName, string sex, DateTime dob, string street, string city, string state, string zipCode, string country, string contactPhone)
        {
            string? insertStatement =
       "INSERT INTO members (firstName, lastName, sex, DOB, Street, City, State, zipCode, country, contactPhone) " +
       "VALUES (@FirstName, @LastName, @Sex, @DOB, @Street, @City, @State, @ZipCode, @Country, @ContactPhone)";

            SqlConnection? connection = null;

            try
            {
                using (connection = DBConnection.GetConnection()) 
                {
                    connection.Open();
                    using SqlCommand cmd = new(insertStatement, connection);
                    cmd.Parameters.AddWithValue("@FirstName", firstName);
                    cmd.Parameters.AddWithValue("@LastName", lastName);
                    cmd.Parameters.AddWithValue("@Sex", sex);
                    cmd.Parameters.AddWithValue("@DOB", dob);
                    cmd.Parameters.AddWithValue("@Street", street);
                    cmd.Parameters.AddWithValue("@City", city);
                    cmd.Parameters.AddWithValue("@State", state);
                    cmd.Parameters.AddWithValue("@ZipCode", zipCode);
                    cmd.Parameters.AddWithValue("@Country", country);
                    cmd.Parameters.AddWithValue("@ContactPhone", contactPhone);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException)
            {
                throw;
            }
            finally
            {
                connection?.Close();
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

    }
}
