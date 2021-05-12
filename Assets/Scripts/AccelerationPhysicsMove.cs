
using UnityEngine;

namespace Asteroids
{
    internal class AccelerationPhysicsMove: MovePhysics, IAccelerationMove
    {
        private float _acceleration;
        public AccelerationPhysicsMove(Rigidbody2D rigidbody2D, float acceleration) : base(rigidbody2D)
        {
            _acceleration = acceleration;
        }

        public void AddAcceleration()
        {
            _speed += _acceleration;
        }

        public void RemoveAcceleration()
        {
            _speed -= _acceleration;
        }
    }
}