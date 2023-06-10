using RAAMEN.Factory;
using RAAMEN.Model;
using RAAMEN.Repository;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAAMEN.Handler
{
    public class TransactionHandler
    {
        public static void makeTransaction(int customerId, ArrayList ramenId, ArrayList ramenQty)
        {
            Header header = TransactionFactory.makeTransaction(customerId);
            TransactionRepository.makeTransaction(header);
            int headerId = header.Id;

            int count = ramenId.Count;
            for (int i = 0; i < count; i++)
            {
                int rId = (int)ramenId[i];
                int qty = (int)ramenQty[i];
                Detail detail = TransactionFactory.makeDetailTransaction(headerId, rId, qty);
                TransactionRepository.makeDetailTransaction(detail);
            }
        }

        public static void handleTransaction(int id, int staffid)
        {
            TransactionRepository.handleTransaction(id,staffid);
        }

        public static void unhandleTransaction(int id, int staffid)
        {
            TransactionRepository.unhandleTransaction(id, staffid);
        }
        public static Header getHeaderById(int id)
        {
            return TransactionRepository.getHeaderById(id);
        }

        public static List<Header> getAllTransaction()
        {
            return TransactionRepository.getAllTransaction();
        }

        public static List<Header> getAllTransactionByCustomerId(int customerId)
        {
            return TransactionRepository.getAllTransactionByCustomerId(customerId);
        }

        public static List<Detail> getAllDetailTransactionByHeaderId(int headerId)
        {
            return TransactionRepository.getAllDetailTransactionByHeaderId(headerId);
        }
    }
}