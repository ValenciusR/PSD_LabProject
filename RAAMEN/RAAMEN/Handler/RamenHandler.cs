using RAAMEN.Factory;
using RAAMEN.Model;
using RAAMEN.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAAMEN.Handler
{
    public class RamenHandler
    {
        // insert
        public static void insertRamen(int meatId, string name, string broth, int price)
        {
            Raman ramen = RamenFactory.createRamen(meatId, name, broth, price);
            RamenRepository.insertRamen(ramen);
        }

        // update
        public static void updateRamen(int id,int meatId, string name, string broth, int price)
        {
            RamenRepository.updateRamen(id, meatId, name, broth, price);
        }

        // delete 
        public static void deleteRamen(int id)
        {
            RamenRepository.deleteRamen(id);
        }

        // get ramen by id
        public static Raman getRamenById(int id)
        {
            return RamenRepository.getRamenById(id);
        }

        // get all ramen
        public static List<Raman> getAllRamen()
        {
            return RamenRepository.getAllRamen();
        }
    }
}