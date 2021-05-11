using UnityEngine;

namespace Asteroids
{
    public class CreateGameObjectWithForce : ICreateGameObject
    {
        private Rigidbody2D _rigidbody2D;
        private Transform _parentTransform;
        private float _force;
        

        public CreateGameObjectWithForce(Rigidbody2D prefab, Transform parentTransform, float force)
        {
            _rigidbody2D = prefab;
            _parentTransform = parentTransform;
            _force = force;
        }
        
        public void CreateGameObject()
        {
            var temAmmunition = 
                GameObject.Instantiate(_rigidbody2D, _parentTransform.position, _parentTransform.rotation);
            temAmmunition.AddForce(_parentTransform.up * _force);
        }
    }
}