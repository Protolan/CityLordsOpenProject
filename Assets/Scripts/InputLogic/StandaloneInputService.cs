using UI;
using UnityEngine;
using Zenject;

namespace InputLogic
{
    public class StandaloneInputService : IInputService
    {
        private const string Horizontal = "Horizontal";
        private const string Vertical = "Vertical";
        private readonly HUD _hud;

        [Inject]
        public StandaloneInputService(HUD hud) => _hud = hud;

        public float HorizontalAxis => 
            _hud.Joystick.Horizontal == 0 ? Input.GetAxis(Horizontal) : _hud.Joystick.Horizontal;

        public float VerticalAxis =>
            _hud.Joystick.Vertical == 0 ? Input.GetAxis(Vertical) : _hud.Joystick.Vertical;
    }
}