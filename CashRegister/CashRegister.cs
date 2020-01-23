using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashRegister
{
    class CashRegister
    {
        private static double totalAmount;
        private static double transactionTotal;

        public CashRegister(double totalAmount = 0)
        {
            TotalAmount = totalAmount;
            TransactionTotal = 0;
        }

        public static double TotalAmount { get => totalAmount; set => totalAmount = value; }
        public static double TransactionTotal { get => transactionTotal; set => transactionTotal = value; }

        public void OpenRegister()
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine($"Total Amount: {TotalAmount}");
            Console.WriteLine("----------------------------");
        }

        public void CloseRegister()
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine($"Total Amount: {TotalAmount}");
            Console.WriteLine("----------------------------");
        }

        public void DoTransactionLine(IAction action)
        {
            
            do
            {
                int productNumber = 0;
                GUI.EnterTransactionLine(action, ref productNumber);
                GUI.ShowTransactionLine(productNumber, TransactionTotal);
                TotalAmount += TransactionTotal;
                TransactionTotal = 0;

                GUI.ShowMenu("Whether to end transaction, 'Y' or 'N' ? ");
            } while (Console.ReadKey().Key == ConsoleKey.N);
            Console.WriteLine();
        }

        


    }
}
