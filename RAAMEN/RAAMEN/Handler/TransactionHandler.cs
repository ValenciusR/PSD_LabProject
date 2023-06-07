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
        public static void makeTransaction(int customerId)
        {
            Header header = TransactionFactory.makeTransaction(customerId);
            TransactionRepository.makeTransaction(header);
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