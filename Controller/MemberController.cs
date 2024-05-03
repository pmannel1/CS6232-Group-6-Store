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
        /// Adds the member.
        /// </summary>
        /// <param name="member">The member.</param>
        public int AddMember(Member member)
        {
          return this.memeberDAL.AddMember(member);
        }

        /// <summary>
        /// Retrieves the member.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public Member RetrieveMember(int id)
        {
            return this.memeberDAL.RetrieveMember(id);
        }

        /// <summary>
        /// Updates the member.
        /// </summary>
        /// <param name="member">The member.</param>
        public void UpdateMember(Member member)
        {
            this.memeberDAL.UpdateMember(member);
        }

        /// <summary>
        /// Searches the member.
        /// </summary>
        /// <param name="method">The method.</param>
        /// <param name="search">The search.</param>
        /// <returns></returns>
        public List<Member> SearchMember(string method, string search)
        {
            return this.memeberDAL.SearchMember(method, search);
        }
    }
}
