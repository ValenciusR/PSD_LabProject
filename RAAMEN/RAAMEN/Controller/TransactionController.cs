using RAAMEN.Handler;
using RAAMEN.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAAMEN.Controller
{
    public class TransactionController
    {
        public static void makeTransaction(int customerId, ArrayList ramenId, ArrayList ramenQty)
        {
            TransactionHandler.makeTransaction(customerId, ramenId, ramenQty);
        }

        public static void handleTransaction(int id,int staffid)
        {
            Header header = TransactionHandler.getHeaderById(id);
            if (header.Status.Equals("Handled"))
            {
                TransactionHandler.unhandleTransaction(id,staffid);
                // update pake staff id yang lagi aktif
            }
            else
            {
                TransactionHandler.handleTransaction(id,staffid);
            }
            
        }

        public static List<Header> getAllTransaction()
        {
            return TransactionHandler.getAllTransaction();
        }

        public static List<Header> getAllTransactionByCustomerId(int customerId)
        {
            return TransactionHandler.getAllTransactionByCustomerId(customerId);
        }

        public static List<Detail> getAllDetailTransactionByHeaderId(int headerId)
        {
            return TransactionHandler.getAllDetailTransactionByHeaderId(headerId);
        }
    }
}