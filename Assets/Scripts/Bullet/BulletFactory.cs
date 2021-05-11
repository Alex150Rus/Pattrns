using Asteroids.Barrel;
using UnityEngine;

namespace Asteroids.Bullet
{
    internal class BulletFactory: IBulletFactory
    {
        private ICreateGameObject _gameObjectCreationImplementation;
        
        public BulletFactory(ICreateGameObject gameObjectCreationImplementation)
        {
            _gameObjectCreationImplementation = 
                gameObjectCreationImplementation;
        }
        
        public void CreateBullet()
        {
            _gameObjectCreationImplementation.CreateGameObject();
        }
    }
}