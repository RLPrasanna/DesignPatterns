using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    internal class Flipkart
    {
        //Publisher
        private static Flipkart _instance = null;
        private List<IOnOrderPlacedSubscriber> onOrderPlacedSubscribers = new List<IOnOrderPlacedSubscriber>();

        private Flipkart() { }

        public static Flipkart GetInstance()
        {
            if(_instance == null)
            {
                _instance = new Flipkart();
            }
            return _instance;
        }

        public void registerSubscriber(IOnOrderPlacedSubscriber subscriber)
        {
            onOrderPlacedSubscribers.Add(subscriber);
        }

        public void unregisterSubscriber(IOnOrderPlacedSubscriber subscriber)
        {
            onOrderPlacedSubscribers.Remove(subscriber);
        }

        public void onOrderPlaced()
        {
            //ns.notify();
            //es.SendEmail();

            Console.WriteLine($"Flipkart: Order placed");
            foreach(var subscriber in onOrderPlacedSubscribers)
            {
                subscriber.announceOrderPlaced();
            }
        }
    }
}
