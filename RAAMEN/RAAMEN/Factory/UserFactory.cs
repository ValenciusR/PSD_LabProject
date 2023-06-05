using RAAMEN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAAMEN.Factory
{
    public class UserFactory
    {
        public static User createUser(string name, string email, string gender, string pass)
        {
            User u = new User();
            u.Username = name;
            u.Email = email;
            u.Gender = gender;
            u.Password = pass;

            return u;
        }
    }
}