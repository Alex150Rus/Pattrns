using Asteroids.Bullet;
using UnityEngine;

namespace Asteroids.Weapon
{
    internal class FireImplementation: IFire
    {
        private IBulletFactory _bulletFactory;
        private Transform _barrel;

        public FireImplementation(IBulletFactory bulletFactory)
        {
            _bulletFactory = bulletFactory;
        }
        public void Fire()
        {
            _bulletFactory.CreateBullet();
        }
    }
}