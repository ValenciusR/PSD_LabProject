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
            if (name == "" || email == "" || password == "" || confirm == "")
            {
                result = "You must fill in all in the form!";
            }
            else if (name.Length < 5 || name.Length > 15)
            {
                result = "Username must be between 5 - 15 character length";
            }
            else if (!email.EndsWith(".com"))
            {
                result = "Email must ends with '.com'";
            }
            else if (gender == "")
            {
                result = "Gender must be choosen";
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


        public static string UpdateUser(int id, string name, string email, string gender, string password, string old_password)
        {
            string result = "";
            if (name == "" || email == "" || password == "")
            {
                result = "You must fill all of the field!";
            }
            else if (name.Length < 5 || name.Length > 15)
            {
                result = "Username must be between 5 - 15 character length";
            }
            else if (!email.EndsWith(".com"))
            {
                result = "Email must ends with '.com'";
            }
            else if (gender == "")
            {
                result = "Gender must be choosen";
            }
            else if (UserHandler.isPasswordInvalid(id, old_password))
            {
                result = "Password invalid";
            }
            else
            {
                UserHandler.UpdateUser(id, name, email, gender, password);
                result = "User update success!";
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