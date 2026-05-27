using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.thirdParty.ICICIBank
{
    internal class ICICIBank
    {
        public void makePayment(string to, string from, decimal amount)
        {
            Console.WriteLine("Transferring money via ICICI bank");
        }
    }
}
