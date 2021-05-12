using System;
using Asteroids.Barrel;
using Asteroids.Bullet;
using UnityEngine;
using Asteroids.ControllableUnit;
using Asteroids.Controllers;
using Asteroids.Weapon;

namespace Asteroids
{
    internal sealed class Player : MonoBehaviour
    {
        [SerializeField] private float _speed;
        [SerializeField] private float _acceleration;
        [SerializeField] private float _hp;
        [SerializeField] private Rigidbody2D _bullet;
        [SerializeField] private Transform _barrel;
        [SerializeField] private float _force;
        private Camera _camera;
        private Ship _ship;
        private Weapon.Weapon _weapon;
        private InputController _inputController;
        private Health.Health _health;

        private void Start()
        {
            _camera = Camera.main;
            var rigidbody2D = GetComponent<Rigidbody2D>();
            var movePhysics = new AccelerationPhysicsMove(rigidbody2D, _acceleration);
            
            var rotation = new RotationShip(transform);
            _ship = new Ship(movePhysics, rotation);

            var objectCreateImplementation = new CreateGameObjectWithForce(
                new BulletProvider(_bullet).Bullet,
                new BarrelProvider(_barrel).Barrel,
                _force
            );
            
            var bulletFactory = new BulletFactory(objectCreateImplementation);
            var fireImplementation = new FireImplementation(bulletFactory);
            _weapon = new Weapon.Weapon(fireImplementation);

            _health = new Health.Health();
            _health.Hp = _hp;
            _health.OnZeroHealth += DestroyGameObject;

            _inputController = new InputController(_ship, _weapon, _camera, transform);

        }

        private void Update()
        {
            _inputController.Execute(Time.deltaTime);
        }

        private void FixedUpdate()
        {
            _inputController.FixedExecute();
        }

        private void OnCollisionEnter2D(Collision2D other)
        {
            _health.Hp--;
        }

        private void DestroyGameObject()
        {
            Destroy(gameObject);
        }

        private void OnDestroy()
        {
            _health.OnZeroHealth -= DestroyGameObject;
        }
    }
}
