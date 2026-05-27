using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.thirdParty.YesBank
{
    internal class YesBank
    {
        public void transferMoney(int amount, string from,  string to)
        {
            Console.WriteLine("Transferring money via Yes Bank");
        }
    }
}
