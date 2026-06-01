using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    internal class ChocolateCone : IIceCream
    {
        private IIceCream iceCream;

        //Chocolate Cone can behave like a base as well as Addon.
        public ChocolateCone() { }

        public ChocolateCone(IIceCream iceCream)
        {
            this.iceCream = iceCream;
        }

        public int getCost()
        {
            if (this.iceCream != null)
            {
                return this.iceCream.getCost() + 30;
            }
            return 30;
        }

        public string getDescription()
        {
            if (this.iceCream != null)
            {
                return this.iceCream.getDescription()+" + Chocolate Cone";
            }
            return "Chocolate Cone";
        }
    }
}
