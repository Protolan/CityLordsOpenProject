using Factories;
using UnityEngine;
using Zenject;

namespace PlayerInput
{
    public class StandaloneInputService : IInputService
    {
        private const string Horizontal = "Horizontal";
        private const string Vertical = "Vertical";
        private readonly UIFactory _factory;

        [Inject]
        public StandaloneInputService(UIFactory factory) => _factory = factory;

        public float HorizontalAxis
        {
            get
            {
                Debug.Log("TryGet");
                if(_factory.HUD.Joystick.Horizontal == 0) Debug.Log(Input.GetAxis(Horizontal));
                return _factory.HUD.Joystick.Horizontal == 0 ? Input.GetAxis(Horizontal) : _factory.HUD.Joystick.Horizontal;
            }
        }

        public float VerticalAxis =>
            _factory.HUD.Joystick.Vertical == 0 ? Input.GetAxis(Vertical) : _factory.HUD.Joystick.Vertical;
    }
}