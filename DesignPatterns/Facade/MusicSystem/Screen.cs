using System;

namespace Facade.MusicSystem
{
    /// <summary>
    /// Subsystem component: Screen
    /// Part of the complex home theater system
    /// </summary>
    internal class Screen
    {
        public void down()
        {
            Console.WriteLine("[Screen] Screen coming DOWN...");
        }

        public void up()
        {
            Console.WriteLine("[Screen] Screen going UP...");
        }
    }
}
