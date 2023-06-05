using RAAMEN.Factory;
using RAAMEN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAAMEN.Repository
{
    public class UserRepository
    {
        public static User RegisterUser(string name, string email, string gender, string pass)
        {
            DatabaseEntities db = new DatabaseEntities();
            User u = UserFactory.createUser(name, email, gender, pass);

            db.Users.Add(u);
            db.SaveChanges();

            return "User Successfully Registered!";
        }
    }
}