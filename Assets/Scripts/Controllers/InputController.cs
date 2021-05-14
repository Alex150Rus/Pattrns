using Asteroids.ControllableUnit;
using Asteroids.Weapon;
using UnityEngine;

namespace Asteroids.Controllers
{
    internal class InputController: IInputController, IExecute, IFixedExecute
    {
        private Ship _ship;
        private Weapon.Weapon _weapon;
        private Camera _camera;
        private Transform _player;
        
        public InputController(Ship ship, Weapon.Weapon weapon, Camera camera, Transform player)
        {
            _ship = ship;
            _weapon = weapon;
            _camera = camera;
            _player = player;
        }
        
        public void Execute(float deltaTime)
        {
            var direction = Input.mousePosition - _camera.WorldToScreenPoint(_player.position);
            _ship.Rotation(direction);
            
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                _ship.AddAcceleration();
            }

            if (Input.GetKeyUp(KeyCode.LeftShift))
            {
                _ship.RemoveAcceleration();
            }
           
            if (Input.GetButtonDown("Fire1"))
            {
                _weapon.Fire();
            }
        }

        public void FixedExecute()
        {
            _ship.Move(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), Time.deltaTime);

        }
    }
}