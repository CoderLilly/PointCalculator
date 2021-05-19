using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            List<TransObject> transactions = TransData.LoadData();

            transactions = transactions.OrderBy(x => x.Month).ToList();

            var uniqueCustomer = transactions.GroupBy(c => c.CustName).Select(grp => grp.First()).ToArray();

            foreach (var cust in uniqueCustomer)
            {
                
                var customer = cust.CustName.ToString();
                Console.WriteLine("______________");

                int totalPoints = 0;

                foreach (var transaction in transactions.Where(c => c.CustName == customer))
                {

                    var points = CalculatePoints(transaction.TransactionAmount);
                    Console.WriteLine($"{transaction.CustName} {transaction.Month} ${transaction.TransactionAmount} {points} points");
                    totalPoints = totalPoints + points;
                }

                Console.WriteLine("Total Accumulated points: " + totalPoints);
            }

            //foreach (var transaction in transactions)
            //{
            //    Console.WriteLine($"{transaction.CustName} {transaction.Month.ToShortDateString()} {transaction.TransactionAmount}");

            //}
            Console.ReadLine();
        }

        static int CalculatePoints(double transAmount)
        {
            int points = 0;

            if (transAmount >=50 && transAmount <100)
            {
                points = points + (Convert.ToInt32(transAmount) - 50);
            }
            else if (transAmount >100)
            {
                points = 50 + 2*(Convert.ToInt32(transAmount) - 100);
            }

            return points;
        }

    }  

}
