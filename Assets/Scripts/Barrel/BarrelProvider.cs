using UnityEngine;

namespace Asteroids.Barrel
{
    internal class BarrelProvider : IBarrelProvider
    {
        private Transform _barrel;
        public Transform Barrel => _barrel;

        public BarrelProvider(Transform barrel)
        {
            _barrel = barrel;
        }
    }
}