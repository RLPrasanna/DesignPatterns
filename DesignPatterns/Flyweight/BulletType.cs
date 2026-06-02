using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    internal class BulletType
    {
        public string name { get; }
        public string color { get; }
        public int speed { get; }
        public int damage { get; }
        public byte[] image { get; }

        public BulletType(string name, string color, int speed, int damage, byte[] image)
        {
            this.name = name;
            this.color = color;
            this.speed = speed;
            this.damage = damage;
            this.image = image;
        }

        public void Render(int x, int y)
        {
            Console.WriteLine($"Rendering {name} bullet at ({x}, {y}) with color {color}, speed {speed}, and damage {damage}");
            // In a real game, this would draw the bullet image on the screen at the specified coordinates
        }
    }
}
