using RAAMEN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAAMEN.Repository
{
    public class RamenRepository
    {
        static DatabaseEntities db = new DatabaseEntities();

        // insert Ramen
        public static void insertRamen(Raman ramen)
        {
            db.Ramen.Add(ramen);
            db.SaveChanges();
        }

        // Update Ramen
        public static void updateRamen(int id, int meatId, string name, string broth, int price)
        {
            Raman ramen = getRamenById(id);
            ramen.MeatId = meatId;
            ramen.Name = name;
            ramen.Broth = broth;
            ramen.Price = price;
            db.SaveChanges();
        }

        // Delete Ramen
        public static void deleteRamen(int id)
        {
            Raman ramen = getRamenById(id);
            db.Ramen.Remove(ramen);
            db.SaveChanges();
            
        }

        // Get Ramen by ID
        public static Raman getRamenById(int id)
        {
            return db.Ramen.Find(id);
        }

        // Get all Ramen
        public static List<Raman> getAllRamen()
        {
            return db.Ramen.ToList();
        }

       
    }
}