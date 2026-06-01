using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    internal class ChocoChips : IIceCream
    {
        private IIceCream iceCream;

        public ChocoChips(IIceCream iceCream)
        {
            this.iceCream = iceCream;
        }
        public int getCost()
        {
            //Always check for null pointer exception
            if (this.iceCream != null) 
            {
                return this.iceCream.getCost();
            }
            return 0;
        }

        public string getDescription()
        {
            return this.iceCream.getDescription()+ " + Choco Chips";
        }
    }
}
