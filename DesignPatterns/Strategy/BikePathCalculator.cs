using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    internal class BikePathCalculator : IPathCalculatorStrategy
    {
        public void findPath(string fromPath, string toPath)
        {
            Console.WriteLine("Bike Path");
        }
    }
}
