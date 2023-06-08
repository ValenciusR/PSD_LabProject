using RAAMEN.Factory;
using RAAMEN.Model;
using RAAMEN.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAAMEN.Handler
{
    public class TransactionHandler
    {
        public static void makeTransaction(int customerId, int[] ramenId, int[] ramenQty, int count)
        {
            Header header = TransactionFactory.makeTransaction(customerId);
            TransactionRepository.makeTransaction(header);
            int id = header.Id;

            for (int i = 0; i < count; i++)
            {
                int rId = ramenId[i];
                int qty = ramenQty[i];
                Detail detail = TransactionFactory.makeDetailTransaction(id, rId, qty);
                TransactionRepository.makeDetailTransaction(detail);
            }
        }

        public static void handleTransaction(int id)
        {
            TransactionRepository.handleTransaction(id);
        }

        public static void unhandleTransaction(int id)
        {
            TransactionRepository.unhandleTransaction(id);
        }
        public static Header getHeaderById(int id)
        {
            return TransactionRepository.getHeaderById(id);
        }

        public static List<Header> getAllTransaction()
        {
            return TransactionRepository.getAllTransaction();
        }

        public static List<Header> getTransactionByCustomerId(int customerId)
        {
            return TransactionRepository.getTransactionByCustomerId(customerId);
        }
    }
}