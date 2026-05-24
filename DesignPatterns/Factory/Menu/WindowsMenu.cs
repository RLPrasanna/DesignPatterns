using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Menu
{
    internal class WindowsMenu : IMenu
    {
        public void showMenu()
        {
            Console.WriteLine("Windows Menu Displayed!");
        }
    }
}
