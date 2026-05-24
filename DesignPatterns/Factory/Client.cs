using Factory.Button;
using Factory.Menu;

namespace Factory
{
    internal class Client
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("╔══════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                  FACTORY DESIGN PATTERN DEMO                  ║");
            Console.WriteLine("║          Creating Buttons for Different Platforms             ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════════╝\n");

            Flutter flutter=new Flutter();
            IUIFactory uiFactory = flutter.createUIFactory(SupportedPlatforms.IOS);

            IButton button = uiFactory.createButton();
            IMenu menu = uiFactory.createMenu();

            button.clickButton();
            menu.showMenu();

            // Create and click a Windows button
            IUIFactory windowsUIFactory = flutter.createUIFactory(SupportedPlatforms.Windows);
            IButton windowsButton= windowsUIFactory.createButton();
            windowsButton.clickButton();

            Console.WriteLine("\n" + new string('─', 62));
            Console.WriteLine("\n Key Insight: Client code doesn't directly instantiate");
            Console.WriteLine("   platform-specific classes. The factory handles all the");
            Console.WriteLine("   creation logic based on the platform!\n");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

    }
}
