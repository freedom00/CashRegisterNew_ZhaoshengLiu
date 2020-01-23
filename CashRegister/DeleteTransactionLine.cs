using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashRegister
{
    class DeleteTransactionLine : IAction
    {
        public void ApplyAction(double price, int number, ref int totalNumber)
        {
            CashRegister.TransactionTotal -= price * number;
            totalNumber --;
        }
    }
}
