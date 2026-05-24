using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Menu
{
    internal class AndroidMenu:IMenu
    {
        public void showMenu()
        {
            Console.WriteLine("Android Menu Displayed!");
        }
    }
}
