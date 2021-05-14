using System;

namespace Asteroids.Health
{
    public class Health: IHealth
    {
        private float _hp;
        
        public event Action OnZeroHealth;

        public float Hp
        {
            get => _hp;
            set
            {
                if (value <= 0f) {
                    OnZeroHealth?.Invoke();
                    _hp = 0f;
                }
                else
                {
                    _hp = value;
                }
            }
        }
    }
}