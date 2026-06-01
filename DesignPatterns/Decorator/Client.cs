using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    internal class Client
    {
        public static void Main(string[] args)
        {
            IIceCream iceCream =
                new ChocoChips(
                        new StrawberryScoop(
                                new ChocolateCone(
                                        new ChocoChips(
                                                new OrangeCone()
                                        )
                                 )
                        )
                );
            
            Console.WriteLine(iceCream.getDescription());
            Console.WriteLine(iceCream.getCost());
        }
    }
}
