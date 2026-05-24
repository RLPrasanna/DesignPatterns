using Factory.Button;
using Factory.Menu;

namespace Factory
{
    internal class WindowsUIFactory : IUIFactory
    {
        public IButton createButton()
        {
            return new WindowsButton();
        }

        public IMenu createMenu()
        {
            return new WindowsMenu();
        }
    }
}
