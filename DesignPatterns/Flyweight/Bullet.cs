using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    internal class Bullet
    {
        // In real, we could store the coordinates as a single struct or class, but for simplicity, we use separate fields here.
        public int x { get; }
        public int y { get; }

        // This is the intrinsic state that can be shared among bullets of the same type
        private readonly BulletType type;

        public Bullet(int x, int y, BulletType type)
        {
            this.x = x;
            this.y = y;
            this.type = type;
        }

        public void Draw()
        {
            type.Render(x, y);
        }
    }
}
