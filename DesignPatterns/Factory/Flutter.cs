
using Factory.Button;
using Factory.Menu;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    /// <summary>
    /// ABSTRACT FACTORY PATTERN DEMONSTRATION
    /// 
    /// This class demonstrates the Abstract Factory Pattern:
    /// 
    /// Pattern Flow:
    /// 1. Client requests a factory for a specific platform (e.g., iOS)
    /// 2. Flutter.createUIFactory() returns the appropriate concrete factory
    /// 3. Client uses this factory to create platform-specific UI components
    /// 4. The factory ensures that iOS components work together (iOS button + iOS menu)
    /// 
    /// Benefits:
    /// - Client code doesn't know about concrete platform classes
    /// - Easy to add new platforms (just create new factory + concrete classes)
    /// - Ensures related products (button + menu) are created together
    /// 
    /// Structure:
    /// ┌─────────────┐
    /// │   Flutter   │ ← Creates appropriate factory
    /// └─────────────┘
    ///        ↓
    /// ┌──────────────────────┐
    /// │ IUIFactory (Abstract) │ ← Interface defining factory contract
    /// └──────────────────────┘
    ///    ↙          ↓          ↘
    /// ┌──────────────┐  ┌──────────────┐  ┌──────────────┐
    /// │   IOSFactory │  │AndroidFactory│  │WindowsFactory│
    /// └──────────────┘  └──────────────┘  └──────────────┘
    ///    Creates:         Creates:          Creates:
    ///  iOS Button &     Android Button &    Windows Button &
    ///  iOS Menu         Android Menu        Windows Menu
    /// </summary>
    internal class Flutter
    {
        public void refreshUI()
        {
            Console.WriteLine("Flutter UI Refreshed!");
        }

        // Additional non factory methods

        // Let's move all the factory methods in separate interface UIFactory.
        //IButton CreateButton()
        //{
        //    if(OperatingSystem.IsAndroid())
        //    {
        //        return new AndroidButton();
        //    }
        //    else if (OperatingSystem.IsIOS())
        //    {
        //        return new IOSButton();
        //    }
        //    else if (OperatingSystem.IsWindows())
        //    {
        //        return new WindowsButton();
        //    }
        //    else
        //    {
        //        throw new NotSupportedException("Unsupported platform");
        //    }
        //}

        //IMenu CreateMenu()
        //{

        //}

        //Create a factory method to get the corresponding UIFactory based on the platform.
        public IUIFactory createUIFactory(SupportedPlatforms platform)
        {
            // This can be moved to a helper class to follow single responsibility principle.
            //if (platform == "IOS")
            //{
            //    return new IOSUIFactory();
            //}
            //else if (platform == "Android")
            //{
            //    return new AndroidUIFactory();
            //}
            //else if (platform == "Windows")
            //{
            //    return new WindowsUIFactory();
            //}
            //else
            //{
            //    throw new NotSupportedException("Unsupported platform");
            //}

            return UIFactoryHelper.GetUIFactory(platform);
        }

    }
}
