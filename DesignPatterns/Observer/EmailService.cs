using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    internal class EmailService : IOnOrderPlacedSubscriber
    {
        public EmailService() { 
            Flipkart flipkart = Flipkart.GetInstance();
            flipkart.registerSubscriber(this);
        }

        public void announceOrderPlaced()
        {
            Console.WriteLine("Sending Email");
        }
    }
}
