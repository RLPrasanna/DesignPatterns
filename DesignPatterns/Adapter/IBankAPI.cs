using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    /// <summary>
    /// Adapter interface that defines a unified contract for different bank implementations.
    /// This allows the client (PhonePe) to work with any bank through a common interface.
    /// </summary>
    internal interface IBankAPI
    {
        /// <summary>
        /// Transfer money from one account to another.
        /// </summary>
        void sendMoney(string from, string to, decimal amount);

        /// <summary>
        /// Register a new account with the bank.
        /// </summary>
        void register(string accountNumber);

        /// <summary>
        /// Retrieve balance for a given account.
        /// </summary>
        decimal getMoney(string accountNumber);
    }
}
