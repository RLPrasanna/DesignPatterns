using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    internal class GoogleMaps
    {
        public void findPath(string from, string to, string mode)
        {
            Console.WriteLine($"Google Maps: Finding path from {from} to {to} using {mode} mode.");

            IPathCalculatorStrategy pathCalculatorStrategy = PathCalculatorFactory.getPathCalculatorForMode(mode);
            pathCalculatorStrategy.findPath(from, to);
        }
    }
}
