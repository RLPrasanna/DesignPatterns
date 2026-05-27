using Facade.MusicSystem;
using System;

namespace Facade
{
    /// <summary>
    /// Facade: Simplifies complex subsystem interactions
    /// Instead of clients managing all components individually,
    /// they interact with this single unified interface.
    /// </summary>
    internal class HomeTheatreFacade
    {
        // References to all subsystem components
        private DVDPlayer dvdPlayer;
        private Projector projector;
        private SoundSystem soundSystem;
        private Lights lights;
        private Screen screen;

        /// <summary>
        /// Constructor: Initialize facade with all subsystem components
        /// </summary>
        public HomeTheatreFacade(DVDPlayer dvd, Projector proj, SoundSystem sound, Lights lgt, Screen scr)
        {
            this.dvdPlayer = dvd;
            this.projector = proj;
            this.soundSystem = sound;
            this.lights = lgt;
            this.screen = scr;
        }

        /// <summary>
        /// Facade method: Watch a movie
        /// Orchestrates multiple subsystems with a single method call
        /// </summary>
        public void watchMovie(string movie)
        {
            Console.WriteLine($"\n>>> [Facade] Preparing home theater to watch: {movie}\n");

            // Step 1: Dim lights
            lights.dim(15);

            // Step 2: Lower screen
            screen.down();

            // Step 3: Turn on projector
            projector.on();
            projector.setInput("DVD");

            // Step 4: Turn on sound system and set volume
            soundSystem.on();
            soundSystem.setSurroundSound(true);
            soundSystem.setVolume(8);

            // Step 5: Turn on DVD player and play movie
            dvdPlayer.on();
            dvdPlayer.play(movie);

            Console.WriteLine($"\n>>> [Facade] Enjoy your movie!\n");
        }

        /// <summary>
        /// Facade method: End movie watching
        /// Turns off all subsystems with a single method call
        /// </summary>
        public void endMovie()
        {
            Console.WriteLine($"\n>>> [Facade] Shutting down home theater\n");

            // Step 1: Stop DVD
            dvdPlayer.stop();
            dvdPlayer.off();

            // Step 2: Turn off projector
            projector.off();

            // Step 3: Turn off sound system
            soundSystem.setSurroundSound(false);
            soundSystem.off();

            // Step 4: Raise screen
            screen.up();

            // Step 5: Turn on lights
            lights.on();

            Console.WriteLine($"\n>>> [Facade] Home theater is now OFF\n");
        }
    }
}
