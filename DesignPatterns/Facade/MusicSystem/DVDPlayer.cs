using System;

namespace Facade.MusicSystem
{
    /// <summary>
    /// Subsystem component: DVD Player
    /// Part of the complex home theater system
    /// </summary>
    internal class DVDPlayer
    {
        public void on()
        {
            Console.WriteLine("[DVD Player] Turning ON...");
        }

        public void off()
        {
            Console.WriteLine("[DVD Player] Turning OFF...");
        }

        public void play(string movie)
        {
            Console.WriteLine($"[DVD Player] Now playing: {movie}");
        }

        public void stop()
        {
            Console.WriteLine("[DVD Player] Stopping playback...");
        }
    }
}
