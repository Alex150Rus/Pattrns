using System;

namespace Asteroids.Health
{
    internal interface IHealth
    {
        event Action OnZeroHealth; 
        float Hp
        {
            get;
            set;
        }
    }
}