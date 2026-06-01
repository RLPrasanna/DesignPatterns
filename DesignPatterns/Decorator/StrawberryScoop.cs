using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    internal class StrawberryScoop : IIceCream
    {
        private IIceCream iceCream;

        public StrawberryScoop(IIceCream iceCream)
        {
            this.iceCream = iceCream;
        }
        public int getCost()
        {
            return this.iceCream.getCost() + 30;
        }

        public string getDescription()
        {
            return this.iceCream.getDescription() + " + Strawberry Scoop";
        }
    }
}
