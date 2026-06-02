using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    internal class Client
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\n========== FLYWEIGHT DESIGN PATTERN DEMO ==========" + "\n");

            // Create a factory for shared bullet types.
            BulletFactory factory = new BulletFactory();

            // Reuse the same intrinsic bullet type for many bullets.
            var bulletType = factory.GetBulletType("ak49.png", "Yellow", 20, 90, new byte[] { 1, 2, 3 });

            List<Bullet> bullets = new();

            for (int i = 0; i < 1000; i++)
            {
                bullets.Add(new Bullet(i * 10, i * 20, bulletType));
            }

            Console.WriteLine($"Created {bullets.Count} bullets using one shared BulletType.");

            // Draw a few bullets to show the shared flyweight in use.
            bullets[0].Draw();
            bullets[1].Draw();
            bullets[2].Draw();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
