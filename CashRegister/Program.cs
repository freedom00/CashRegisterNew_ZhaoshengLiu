using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashRegister
{
    class Program
    {
        static void Main(string[] args)
        {
            //for the initial amount.
            const double TOTAL_AMOUNT = 100;
            IAction action = null;

            //register the cash register.
            CashRegister cashRegister = new CashRegister(TOTAL_AMOUNT);

            // open the cash register.
            cashRegister.OpenRegister();

            // operate transaction.
            cashRegister.DoTransactionLine(action);

            //cloes the cash register.
            cashRegister.CloseRegister();

            Console.ReadKey();
        }
    }
}
