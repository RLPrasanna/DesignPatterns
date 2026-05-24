using Factory.Button;
using Factory.Menu;

namespace Factory
{
    internal interface IUIFactory
    {
        IButton createButton();
        IMenu createMenu();

        //IDropDown CreateDropDown();
    }
}
