using RAAMEN.Handler;
using RAAMEN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAAMEN.Controller
{
    public class RamenController
    {
        // insert
        public static string insertRamen(int meatId, string name, string broth, int price)
        {
            if (!name.Contains("Ramen"))
            {
                return "Name Must Contain Ramen";
            }
            else if (broth.Equals(""))
            {
                return "Broth Cannot Be Empty";
            }
            else if (price < 3000)
            {
                return "Price must be atleast 3000";
            }
            else
            {
                RamenHandler.insertRamen(meatId, name, broth, price);
                return "Success";
            }
        }

        // update
        public static string updateRamen(int id, int meatId, string name, string broth, int price)
        {
            if (!name.Contains("Ramen"))
            {
                return "Name Must Contain Ramen";
            }
            else if (broth.Equals(""))
            {
                return "Broth Cannot Be Empty";
            }
            else if (price < 3000)
            {
                return "Price must be atleast 3000";
            }
            else
            {
                RamenHandler.updateRamen(id, meatId, name, broth, price);
                return "Success";
            }
        }
        // delete
        public static void deleteRamen(int id)
        {
            RamenHandler.deleteRamen(id);
        }
        // get Ramen by Id
        public static Raman getRamenById(int id)
        {
            return RamenHandler.getRamenById(id);
        }

        // get all Ramen
        public static List<Raman> getAllRamen()
        {
            return RamenHandler.getAllRamen();
        }
    }
}