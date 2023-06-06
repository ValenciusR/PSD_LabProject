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
        public static string InsertUser(string name, string email, string gender, string password, string confirm)
        {
            string result = "";
            if (name == "" || email == "" || gender == "" || password == "" || confirm == "")
            {
                result = "You must fill in all in the form!";
            }
            else if (password != "" && confirm != "" && password != confirm)
            {
                result = "Password input must be the same input with Confirm Password!";
            }
            else
            {
                UserHandler.InsertUser(name, email, gender, password);
            }
            
            return result;
        }

        public static User getUserById(int id)
        {
            return UserHandler.getUserById(id);
        }
    }
}