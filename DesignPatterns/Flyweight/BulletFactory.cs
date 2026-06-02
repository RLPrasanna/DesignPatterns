using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    internal class BulletFactory
    {
        private readonly Dictionary<string, BulletType> _bulletTypesCache = new Dictionary<string, BulletType>();

        public BulletType GetBulletType(string name, string color, int speed, int damage, byte[] image)
        {
            string key = $"{name}_{color}_{speed}_{damage}";
            if (!_bulletTypesCache.ContainsKey(key))
            {
                _bulletTypesCache[key] = new BulletType(name, color, speed, damage, image);
            }
            return _bulletTypesCache[key];
        }


    }
}
