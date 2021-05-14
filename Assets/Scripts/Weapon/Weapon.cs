namespace Asteroids.Weapon
{
    internal class Weapon: IFire
    {
        private float _damagePoints = 10.0f;
        private IFire _fireImplementation;
        
        public float DamagePoints => _damagePoints;

        public Weapon(IFire fireImplementation)
        {
            _fireImplementation = fireImplementation;
        }
        
        public void Fire()
        {
            _fireImplementation.Fire();
        }
    }
}