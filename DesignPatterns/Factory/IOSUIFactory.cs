using Factory.Button;
using Factory.Menu;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    internal class IOSUIFactory : IUIFactory
    {
        public IButton createButton()
        {
            return new IOSButton();
        }

        public IMenu createMenu()
        {
            return new IOSMenu();
        }
    }
}
