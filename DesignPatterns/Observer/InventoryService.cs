using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    internal class InventoryService : IOnOrderPlacedSubscriber
    {
        public InventoryService() { 
            Flipkart flipkart = Flipkart.GetInstance();
            flipkart.registerSubscriber(this);
        }
        public void announceOrderPlaced()
        {
            Console.WriteLine("Notifying Inventory");
        }
    }
}
