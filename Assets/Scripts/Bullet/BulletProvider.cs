using UnityEngine;

namespace Asteroids.Bullet
{
    internal class BulletProvider : IBulletProvider
    {
        private Rigidbody2D _rigidbody2D;
        public Rigidbody2D Bullet => _rigidbody2D;

        public BulletProvider(Rigidbody2D rigidbody2D)
        {
            _rigidbody2D = rigidbody2D;
        }
    }
}