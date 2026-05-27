using Adapter.thirdParty.YesBank;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    internal class YesAdapter : IBankAPI
    {
        private YesBank yesBank=new YesBank();
        public decimal getMoney(string accountNumber)
        {
            return 0;
        }

        public void register(string accountNumber)
        {
            
        }

        public void sendMoney(string from, string to, decimal amount)
        {
            yesBank.transferMoney(Convert.ToInt32(amount), from, to);
        }
    }
}
