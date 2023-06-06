using RAAMEN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAAMEN.Factory
{
    public class UserFactory
    {
        public static User createUser(string name, string email, string gender, string password)
        {
            User user = new User();
            user.Username = name;
            user.Email = email;
            user.Gender = gender;
            user.RoleId = 3;
            user.Password = password;
            return user;
        }
    }
}