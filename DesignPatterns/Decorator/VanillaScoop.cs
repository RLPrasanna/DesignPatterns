using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    internal class VanillaScoop : IIceCream
    {
        private IIceCream iceCream;

        public VanillaScoop(IIceCream iceCream)
        {
            this.iceCream = iceCream;
        }

        public int getCost()
        {
            return this.iceCream.getCost() + 40;
        }

        public string getDescription()
        {
            return this.iceCream.getDescription()+" + Vanilla Scoop";
        }
    }
}
