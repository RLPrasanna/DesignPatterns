using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Button
{
    internal class IOSButton : IButton
    {
        public void clickButton()
        {
            Console.WriteLine("iOS Button Clicked!");
        }
    }
}
