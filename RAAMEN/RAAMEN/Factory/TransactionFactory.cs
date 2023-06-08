using RAAMEN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAAMEN.Factory
{
    public class TransactionFactory
    {
        public static Header makeTransaction(int customerId)
        {
            Header header = new Header();
            header.CustomerId = customerId;
            header.Date = DateTime.Today;
            header.Status = "unhandled";
            return header;
        }

        public static Detail makeDetailTransaction(int id, int rId, int qty)
        {
            Detail detail = new Detail();
            detail.HeaderId = id;
            detail.RamenId = rId;
            detail.Quantity = qty;
            return detail;
        }

    }
}