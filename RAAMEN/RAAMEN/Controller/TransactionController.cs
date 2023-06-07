﻿using RAAMEN.Handler;
using RAAMEN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAAMEN.Controller
{
    public class TransactionController
    {
        public static void makeTransaction(int customerId)
        {
            TransactionHandler.makeTransaction(customerId);
        }

        public static List<Header> getAllTransaction()
        {
            return TransactionHandler.getAllTransaction();
        }

        public static List<Header> getTransactionByCustomerId(int customerId)
        {
            return TransactionHandler.getTransactionByCustomerId(customerId);
        }
    }
}