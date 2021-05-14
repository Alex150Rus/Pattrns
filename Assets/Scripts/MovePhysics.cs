using UnityEngine;

namespace Asteroids
{
    internal class MovePhysics : IMove
    {
        private readonly Rigidbody2D _rigidbody2D;
        private Vector2 _force;
        protected float _speed = 1.0f;

        public float Speed => _speed; 

        public MovePhysics(Rigidbody2D rigidbody2D)
        {
            _rigidbody2D = rigidbody2D;
        }
        
        public void Move(float horizontal, float vertical, float deltaTime)
        {
            _force.Set(horizontal, vertical);
            _rigidbody2D.AddRelativeForce(_force * _speed);
        }
    }
}