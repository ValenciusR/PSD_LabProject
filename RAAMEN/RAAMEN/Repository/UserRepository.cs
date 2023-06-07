using RAAMEN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAAMEN.Repository
{
    public class UserRepository
    {
        static DatabaseEntities db = new DatabaseEntities();

        public static void InsertUser(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
        }

        public static void UpdateUser(int id, string name, string email, string gender)
        {
            User user = db.Users.Find(id);
            user.Username = name;
            user.Email = email;
            user.Gender = gender;
            db.SaveChanges();
        }

        public static bool isPasswordInvalid(int id, string pass)
        {
            User user = db.Users.Find(id);
            if(user.Password != pass)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}