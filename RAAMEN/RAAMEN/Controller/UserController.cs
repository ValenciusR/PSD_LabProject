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
        static DatabaseEntities db = new DatabaseEntities();
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

        public static User checkUser(string email, string password)
        {
            User user = (from u in db.Users where u.Username.Equals(email) && u.Password.Equals(password) select u).FirstOrDefault();
            return user;
        }
    }
}