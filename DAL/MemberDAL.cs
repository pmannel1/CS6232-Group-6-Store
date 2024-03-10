using CS6232_Group_6_Store.Model;

using System.Data.SqlClient;


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
                        selectStatement += " lastName like '%' + @lastName + '%' and firstName like '%' + @firstname + '%' ";
                    }
                    else if ((lastName != null && lastName != "") && (firstName == null || firstName == ""))
                    {
                        selectStatement += " lastName like '%' + @lastName + '%'  ";
                    }
                    else if ((lastName == null || lastName == "") && (firstName != null && firstName != ""))
                    {
                        selectStatement += "   firstName like '%' + @firstname + '%'  ";
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

                        if (lastName != null && lastName != "")
                        {
                            selectCommand.Parameters.Add("@lastName", System.Data.SqlDbType.VarChar);
                            selectCommand.Parameters["@lastName"].Value = lastName.Trim();
                        }
                        if (firstName != null && firstName != "")
                        {
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


    }
}
