using CS6232_Group_6_Store.DAL;
using CS6232_Group_6_Store.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS6232_Group_6_Store.Controller
{
    public class LoginController
    {
        private LoginDAL loginDAL;

        /// <summary>
        /// Initializes a new instance of the <see cref="LoginController"/> class.
        /// </summary>
        public LoginController()
        {
            this.loginDAL = new LoginDAL();
        }

        /// <summary>
        /// Returns employee Name.
        /// </summary>
        /// <param name="userName">user name.</param>
        /// /// <param name="password">Password</param>
        /// <returns></returns>
        public string CheckCredentials(Login login)
        {
            return this.loginDAL.CheckCredentials(login);
        }
    }
}
