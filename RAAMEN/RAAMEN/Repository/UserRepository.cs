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

        public static User getUserById(int id)
        {
            return db.Users.Find(id);
        }
    }
}