using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashRegister
{
    interface IAction
    {
        void ApplyAction(double price, int number, ref int totalNumber);
    }
}
