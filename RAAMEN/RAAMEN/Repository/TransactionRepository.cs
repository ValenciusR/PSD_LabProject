using RAAMEN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAAMEN.Repository
{
    public class TransactionRepository
    {
        static DatabaseEntities db = new DatabaseEntities();

        //insert ramen order
        public static void makeTransaction(Header header)
        {
            db.Headers.Add(header);
            db.SaveChanges();
        }

        //get all ramen order history (admin)
        public static List<Header> getAllTransaction()
        {
            return db.Headers.ToList();
        }

        //get transaction by user id
        public static List<Header> getTransactionByCustomerId(int customerId)
        {
            //INI PERLU DISELEKSI BASED ON ID USER
            return db.Headers.ToList();
        }
    }
}