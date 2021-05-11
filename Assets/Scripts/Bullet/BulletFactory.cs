using Asteroids.Barrel;
using UnityEngine;

namespace Asteroids.Bullet
{
    internal class BulletFactory: IBulletFactory
    {
        private ICreateGameObject _gameObjectCreationImplementation;
        
        public BulletFactory(IBulletProvider bulletProvider, IBarrelProvider barrelProvider, float force)
        {
            _gameObjectCreationImplementation = 
                new CreateGameObjectWithForce(bulletProvider.Bullet, barrelProvider.Barrel, force);
        }
        
        public void CreateBullet()
        {
            _gameObjectCreationImplementation.CreateGameObject();
        }
    }
}