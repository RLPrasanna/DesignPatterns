using System;

namespace Facade.MusicSystem
{
    /// <summary>
    /// Subsystem component: Projector
    /// Part of the complex home theater system
    /// </summary>
    internal class Projector
    {
        public void on()
        {
            Console.WriteLine("[Projector] Turning ON...");
        }

        public void off()
        {
            Console.WriteLine("[Projector] Turning OFF...");
        }

        public void setInput(string input)
        {
            Console.WriteLine($"[Projector] Input set to: {input}");
        }
    }
}
