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

        public static List<Header> getAllTransaction()
        {
            return db.Headers.ToList();
        }

        public static List<Header> getAllTransactionByCustomerId(int customerId)
        {
            List<Header> allHeadersData = db.Headers.ToList();

            List<Header> allCustomerData = new List<Header>();
            foreach(Header head in allHeadersData)
            {
                if(head.CustomerId == customerId)
                {
                    allCustomerData.Add(head);
                }
            }
            return allCustomerData; 
        }

        public static List<Detail> getAllDetailTransactionByHeaderId(int headerId)
        {
            List<Detail> allDetailsData = db.Details.ToList();

            List<Detail> allHeaderDetailsData = new List<Detail>();
            foreach (Detail detail in allDetailsData)
            {
                if (detail.HeaderId == headerId)
                {
                    allHeaderDetailsData.Add(detail);
                }
            }
            return allHeaderDetailsData;
        }
    }
}