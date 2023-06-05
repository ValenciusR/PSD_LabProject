using RAAMEN.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAAMEN.Controller
{
    public class UserController
    {
        public static string RegisterUser(string name, string email, string confirm, string gender, string pass)
        {
            if (name.Equals("") || email.Equals("") || confirm.Equals("") || gender.Equals("") || pass.Equals(""))
            {
                return "Please all of the fields!";
            }
            else if (!pass.Equals(confirm))
            {
                return "Password must be the same with Confirm Password!";
            }

            return UserRepository.RegisterUser(name, email, gender, pass);
        }
    }
}