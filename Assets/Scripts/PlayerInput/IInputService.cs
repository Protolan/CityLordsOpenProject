using UnityEngine;

namespace PlayerInput
{
    public interface IInputService
    {
        public float HorizontalAxis { get; }
        public float VerticalAxis { get; }
    }
}
