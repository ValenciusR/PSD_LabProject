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
        public static void insertRamen(int meatId, string name, string broth, int price)
        {
            // validasi...

            RamenHandler.insertRamen(meatId, name, broth, price);
        }

        // update
        public static void updateRamen(int id, int meatId, string name, string broth, int price)
        {
            // validasi...

            RamenHandler.updateRamen(id, meatId, name, broth, price);
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