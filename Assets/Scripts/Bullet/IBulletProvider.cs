using UnityEngine;

namespace Asteroids.Bullet
{
    internal interface IBulletProvider
    {
        Rigidbody2D Bullet
        {
            get;
        }
    }
}