using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    internal class CarPathCalculator : IPathCalculatorStrategy
    {
        public void findPath(string fromPath, string toPath)
        {
            Console.WriteLine("Car Path");
        }
    }
}
