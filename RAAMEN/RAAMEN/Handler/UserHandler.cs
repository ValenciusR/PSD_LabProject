using RAAMEN.Factory;
using RAAMEN.Model;
using RAAMEN.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAAMEN.Handler
{
    public class UserHandler
    {
        public static void InsertUser(string name, string email, string gender, string password)
        {
            User user = UserFactory.createUser(name, email, gender, password);
            UserRepository.InsertUser(user);
        }
    }
}