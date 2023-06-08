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

        public static void makeDetailTransaction(Detail detail)
        {
            db.Details.Add(detail);
            db.SaveChanges();
        }

        //Handle Transaction
        public static void handleTransaction(int id)
        {
            Header header = getHeaderById(id);
            header.Status = "Handled";
            db.SaveChanges();
        }

        public static void unhandleTransaction(int id)
        {
            Header header = getHeaderById(id);
            header.Status = "Unhandled";
            db.SaveChanges();
        }

        public static Header getHeaderById(int id)
        {
            return db.Headers.Find(id);
        }


        public static void makeDetailTransaction()
        {

        }
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