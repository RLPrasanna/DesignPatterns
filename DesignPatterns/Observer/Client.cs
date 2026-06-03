using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    internal class Client
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("╔══════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                  OBSERVER DESIGN PATTERN DEMO                 ║");
            Console.WriteLine("║          Real-time Stock Price Updates with Observer Pattern  ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════════╝\n");
            
            Flipkart flipkart = Flipkart.GetInstance();
            EmailService emailService = new EmailService();
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator();
            InventoryService inventoryService = new InventoryService();

            flipkart.onOrderPlaced();


            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
