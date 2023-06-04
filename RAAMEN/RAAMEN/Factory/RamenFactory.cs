using RAAMEN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAAMEN.Factory
{
    public class RamenFactory
    {
        // craete Ramen
        public static Raman createRamen(int meatId, string name, string broth, int price)
        {
            Raman ramen = new Raman();
            ramen.MeatId = meatId;
            ramen.Name = name;
            ramen.Broth = broth;
            ramen.Price = price;
            return ramen;
        }
    }
}