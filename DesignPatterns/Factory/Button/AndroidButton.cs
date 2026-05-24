using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Button
{
    internal class AndroidButton : IButton
    {
        public void clickButton()
        {
            Console.WriteLine("Android Button Clicked!");
        }
    }
}
