using System;

namespace Facade.MusicSystem
{
    /// <summary>
    /// Subsystem component: Lights
    /// Part of the complex home theater system
    /// </summary>
    internal class Lights
    {
        public void on()
        {
            Console.WriteLine("[Lights] Turning ON...");
        }

        public void off()
        {
            Console.WriteLine("[Lights] Turning OFF...");
        }

        public void dim(int level)
        {
            Console.WriteLine($"[Lights] Dimmed to: {level}%");
        }
    }
}
