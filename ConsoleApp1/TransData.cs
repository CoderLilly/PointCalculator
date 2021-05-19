using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class TransData
    {
        public static List<TransObject> LoadData()
        {
            List<TransObject> transactions = new List<TransObject>();

            transactions.Add(new TransObject { CustName = "Bill", Month = "April", TransactionAmount = 150.00 });
            transactions.Add(new TransObject { CustName = "Bill", Month = "April", TransactionAmount = 109.00 });
            transactions.Add(new TransObject { CustName = "Bill", Month = "April", TransactionAmount = 65.00 });
            transactions.Add(new TransObject { CustName = "Bill", Month = "May", TransactionAmount = 73.00 });
            transactions.Add(new TransObject { CustName = "Bill", Month = "June", TransactionAmount = 102.00 });
            transactions.Add(new TransObject { CustName = "Bob", Month = "April", TransactionAmount = 500.00 });
            transactions.Add(new TransObject { CustName = "Bob", Month = "April", TransactionAmount = 302.00 });
            transactions.Add(new TransObject { CustName = "Bob", Month = "May", TransactionAmount = 88.00 });
            transactions.Add(new TransObject { CustName = "Bob", Month = "May", TransactionAmount = 96.00 });
            transactions.Add(new TransObject { CustName = "Bob", Month = "June", TransactionAmount = 110.00 });
            transactions.Add(new TransObject { CustName = "Mary", Month = "April", TransactionAmount = 150.00 });
            transactions.Add(new TransObject { CustName = "Mary", Month = "April", TransactionAmount = 109.00 });
            transactions.Add(new TransObject { CustName = "Mary", Month = "May", TransactionAmount = 65.00 });
            transactions.Add(new TransObject { CustName = "Mary", Month = "May", TransactionAmount = 73.00 });
            transactions.Add(new TransObject { CustName = "Mary", Month = "June", TransactionAmount = 102.00 });
            transactions.Add(new TransObject { CustName = "Sue", Month = "April", TransactionAmount = 500.00 });
            transactions.Add(new TransObject { CustName = "Sue", Month = "April", TransactionAmount = 302.00 });
            transactions.Add(new TransObject { CustName = "Sue", Month = "May", TransactionAmount = 88.00 });
            transactions.Add(new TransObject { CustName = "Sue", Month = "June", TransactionAmount = 96.00 });
            transactions.Add(new TransObject { CustName = "Sue", Month = "June", TransactionAmount = 120.00 });

            return transactions;
        }
    }
}
