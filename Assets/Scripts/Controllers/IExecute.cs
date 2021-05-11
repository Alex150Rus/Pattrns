using UnityEngine;

namespace Asteroids.Controllers
{
    internal interface IExecute : IInputController
    {
        void Execute(float deltaTime);
    }
}