using Adapter.thirdParty.ICICIBank;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    /// <summary>
    /// Concrete adapter that adapts ICICI Bank's API to the IBankAPI interface.
    /// This decouples PhonePe from ICICI's implementation details.
    /// </summary>
    internal class ICICIAdapter : IBankAPI
    {
        private ICICIBank iciciBank = new ICICIBank();

        public decimal getMoney(string accountNumber)
        {
            Console.WriteLine($"[ICICIAdapter] Fetching balance for account: {accountNumber}");
            return 0;
        }

        public void register(string accountNumber)
        {
            Console.WriteLine($"[ICICIAdapter] Registering account: {accountNumber}");
        }

        /// <summary>
        /// Adapts the sendMoney call to ICICI's makePayment method.
        /// Note: Parameter order differs from IBankAPI (ICICI expects: to, from, amount).
        /// </summary>
        public void sendMoney(string from, string to, decimal amount)
        {
            Console.WriteLine($"[ICICIAdapter] Adapting sendMoney call to ICICI's makePayment method...");
            Console.WriteLine($"  From: {from}, To: {to}, Amount: {amount}");
            iciciBank.makePayment(to, from, amount);
        }
    }
}
