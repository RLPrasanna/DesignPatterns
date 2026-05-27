using Facade.MusicSystem;
using System;

namespace Facade
{
    /// <summary>
    /// Client demonstrating the Facade Pattern
    /// Shows the difference between:
    /// 1. Using subsystems directly (complex, error-prone)
    /// 2. Using the Facade (simple, coordinated)
    /// </summary>
    internal class Client
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\n========== FACADE DESIGN PATTERN DEMO ==========\n");

            // Step 1: Without Facade - Client must manage all subsystems directly
            Console.WriteLine("--- SCENARIO 1: Without Facade (Manual Control) ---\n");

            DVDPlayer dvd = new DVDPlayer();
            Projector projector = new Projector();
            SoundSystem sound = new SoundSystem();
            Lights lights = new Lights();
            Screen screen = new Screen();

            // Client has to manually coordinate all these steps
            Console.WriteLine("[Client] Setting up theater manually...\n");
            lights.dim(10);
            screen.down();
            projector.on();
            projector.setInput("DVD");
            sound.on();
            sound.setVolume(5);
            sound.setSurroundSound(true);
            dvd.on();
            dvd.play("Inception");

            Console.WriteLine("\nPress any key to continue to Facade example...");
            Console.ReadKey();

            // Step 2: With Facade - Client uses a single simplified interface
            Console.WriteLine("\n--- SCENARIO 2: With Facade (Simple Unified Interface) ---\n");

            // Create the facade
            HomeTheatreFacade homeTheater = new HomeTheatreFacade(dvd, projector, sound, lights, screen);

            homeTheater.watchMovie("The Matrix");
            homeTheater.endMovie();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
