using Sirenix.OdinInspector;
using UnityEngine;

namespace UI
{
    public class HUD: SerializedMonoBehaviour
    {
        private void Update()
        {
            HorizontalShow = Joystick.Horizontal;
        }

        public float HorizontalShow;

        public Joystick Joystick;
    }
}