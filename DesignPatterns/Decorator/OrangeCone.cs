using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    internal class OrangeCone : IIceCream
    {
        //Orange Cone will only behave like a base
        public int getCost()
        {
            return 10;
        }

        public string getDescription()
        {
            return "Orange Cone";
        }
    }
}
