﻿using CS6232_Group_6_Store.DAL;
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
        /// Returns the name of the members.
        /// </summary>
        /// <returns></returns>
        public List<Member> ReturnMembersName()
        {

            return this.memeberDAL.ReturnMemberNames();
        }

        /// <summary>
        /// Retruns the members.
        /// </summary>
        /// <param name="searchMethod">The search method.</param>
        /// <param name="searchField">The search field.</param>
        /// <returns></returns>
        public List<Member> RetrunMembers(string searchMethod, string searchField)
        {
            return this.memeberDAL.RetrunMembers(searchMethod, searchField);
        }
    }
}
