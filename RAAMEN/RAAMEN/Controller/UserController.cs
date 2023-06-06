using RAAMEN.Handler;
using RAAMEN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAAMEN.Controller
{
    public class UserController
    {
        public static void InsertUser(string name, string email, string gender, string password)
        {
            UserHandler.InsertUser(name, email, gender, password);
        }

        public static User getUserById(int id)
        {
            return UserHandler.getUserById(id);
        }
    }
}