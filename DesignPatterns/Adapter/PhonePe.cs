using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    /// <summary>
    /// PhonePe application demonstrating the Adapter pattern.
    /// Uses IBankAPI adapter to interact with different bank implementations.
    /// </summary>
    internal class PhonePe
    {
        // Adapter interface allows switching between different bank implementations
        // Ideally we would use dependency injection here
        private static IBankAPI bankAPI = new ICICIAdapter();

        public static void Main(string[] args)
        {
            Console.WriteLine("[PhonePe] Initiating money transfer using ICICI Bank adapter...");
            bankAPI.sendMoney("1234", "9876", 1000.50m);
            Console.WriteLine("[PhonePe] Money transfer completed successfully.");
        }
    }
}
