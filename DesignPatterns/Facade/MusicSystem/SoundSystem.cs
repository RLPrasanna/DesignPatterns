using System;

namespace Facade.MusicSystem
{
    /// <summary>
    /// Subsystem component: Sound System
    /// Part of the complex home theater system
    /// </summary>
    internal class SoundSystem
    {
        public void on()
        {
            Console.WriteLine("[Sound System] Turning ON...");
        }

        public void off()
        {
            Console.WriteLine("[Sound System] Turning OFF...");
        }

        public void setVolume(int level)
        {
            Console.WriteLine($"[Sound System] Volume set to: {level}");
        }

        public void setSurroundSound(bool enabled)
        {
            string status = enabled ? "ENABLED" : "DISABLED";
            Console.WriteLine($"[Sound System] Surround Sound: {status}");
        }
    }
}
