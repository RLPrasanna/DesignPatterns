using Factory.Button;
using Factory.Menu;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    internal class AndroidUIFactory : IUIFactory
    {
        public IButton createButton()
        {
            return new AndroidButton();
        }

        public IMenu createMenu()
        {
            return new AndroidMenu();
        }
    }
}
