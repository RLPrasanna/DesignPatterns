using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    internal class InvoiceGenerator : IOnOrderPlacedSubscriber
    {
        public InvoiceGenerator() { 
            Flipkart flipkart = Flipkart.GetInstance();
            flipkart.registerSubscriber(this);
        }

        public void announceOrderPlaced()
        {
            Console.WriteLine("Generating Invoice");
        }
    }
}
