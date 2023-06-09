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

        public static void UpdateUser(int id, string name, string email, string gender, string password)
        {
            UserRepository.UpdateUser(id, name, email, gender, password);
        }

        public static bool isPasswordInvalid(int id, string pass)
        {
            return UserRepository.isPasswordInvalid(id, pass);
        }
    }
}