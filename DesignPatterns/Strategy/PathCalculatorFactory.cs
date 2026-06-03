using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    internal class PathCalculatorFactory
    {
        public static IPathCalculatorStrategy getPathCalculatorForMode(string mode)
        {
            if (mode == "Car")
            {
                return new CarPathCalculator();

            }
            else if (mode == "Bike")
            {
                return new BikePathCalculator();
            }
            else if (mode == "Walk")
            {
                return new WalkPathCalculator();
            }
            else
            {
                throw new ArgumentException("Invalid mode of transportation");
            }
        }
    }
}
