using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    internal class UIFactoryHelper
    {
        public static IUIFactory GetUIFactory(SupportedPlatforms platform)
        {
            switch (platform)
            {
                case SupportedPlatforms.Android:
                    return new AndroidUIFactory();
                case SupportedPlatforms.IOS:
                    return new IOSUIFactory();
                case SupportedPlatforms.Windows:
                    return new WindowsUIFactory();
                default:
                    throw new ArgumentException("Unsupported platform: " + platform);
            }
        }
    }
}
