using CS6232_Group_6_Store.DAL;
using CS6232_Group_6_Store.Model;

namespace CS6232_Group_6_Store.Controller
{
    /// <summary>
    /// Class representing Member controller
    /// </summary>
    public class MemberController
    {
        private MemberDAL memeberDAL;

        /// <summary>
        /// Initializes a new instance of the <see cref="MemberController"/> class.
        /// </summary>
        public MemberController()
        {
            this.memeberDAL = new MemberDAL();
        }

        /// <summary>
        /// Retruns the members.
        /// </summary>
        /// <returns></returns>
        public List<Member> ReturnMembers()
        {
            return this.memeberDAL.ReturnMembers();
        }

        /// <summary>
        /// Retruns the members.
        /// </summary>
        /// <param name="searchMethod">The search method.</param>
        /// <param name="searchField">The search field.</param>
        /// <returns></returns>
        public List<Member> ReturnMembersSearch(int searchItem)
        {
            return this.memeberDAL.ReturnMembersSearch(searchItem);
        }

        public void AddDBMember(string firstName, string lastName, string sex, DateTime dob, string street, string city, string state, string zipCode, string country, string contactPhone)
        {
            MemberDAL.AddDBMember(firstName, lastName, sex, dob, street, city, state, zipCode, country, contactPhone);
        }

        public Member RetrieveMember(int id)
        {
            return this.memeberDAL.RetrieveMember(id);
        }

        public void UpdateMember(Member member)
        {
            this.memeberDAL.UpdateMember(member);
        }
    }
}
