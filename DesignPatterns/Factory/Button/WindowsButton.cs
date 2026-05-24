using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Button
{
    internal class WindowsButton: IButton
    {
        public void clickButton()
        {
            Console.WriteLine("Windows Button Clicked!");
        }
    }
}
