using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Menu
{
    internal class IOSMenu : IMenu
    {
        public void showMenu()
        {
            Console.WriteLine("iOS Menu Displayed!");
        }
    }
}
