using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAAMEN.View.Member
{
    public class Ramen
    {
        public int RamenId { get; set; }
        public int RamenQty { get; set; }

        public Ramen(int ramenId, int ramenQty)
        {
            RamenId = ramenId;
            RamenQty = ramenQty;
        }
    }
}