using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    internal class PathCalculatorFactory
    {
        // Eager initialization of strategies based on mode of transportation
        private static readonly IPathCalculatorStrategy carPathCalculator = new CarPathCalculator();
        private static readonly IPathCalculatorStrategy bikePathCalculator = new BikePathCalculator();
        private static readonly IPathCalculatorStrategy walkPathCalculator = new WalkPathCalculator();

        public static IPathCalculatorStrategy getPathCalculatorForMode(string mode)
        {
            if (mode == "Car")
            {
                return carPathCalculator;
                // return new CarPathCalculator(); // Lazy initialization (commented out)

            }
            else if (mode == "Bike")
            {
                return bikePathCalculator;
                //return new BikePathCalculator();
            }
            else if (mode == "Walk")
            {
                return walkPathCalculator;
                //return new WalkPathCalculator();
            }
            else
            {
                throw new ArgumentException("Invalid mode of transportation");
            }
        }
    }
}
