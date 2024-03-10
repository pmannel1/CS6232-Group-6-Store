﻿using CS6232_Group_6_Store.DAL;
using CS6232_Group_6_Store.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS6232_Group_6_Store.Controller
{
    public class MemberController
    {
        private MemberDAL memeberDAL;

        public MemberController()
        {
            this.memeberDAL = new MemberDAL();
        }

        public List<Member> ReturnMembersName()
        {

            return this.memeberDAL.ReturnMemberNames();
        }

        public List<Member> RetrunMembers(string searchMethod, string searchField)
        {
            return this.memeberDAL.RetrunMembers(searchMethod, searchField);
        }
    }
}