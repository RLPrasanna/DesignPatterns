using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    internal class Client
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("╔══════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                  STRATEGY DESIGN PATTERN DEMO                 ║");
            Console.WriteLine("║          Dynamic Behavior Change at Runtime with Ease         ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════════╝\n");
            
            // Create a context and set different strategies
            GoogleMaps googleMaps = new GoogleMaps();
            googleMaps.findPath("Delhi", "Agra", "Walk");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
