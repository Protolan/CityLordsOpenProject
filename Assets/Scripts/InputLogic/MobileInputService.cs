namespace InputLogic
{
    public class MobileInputService : IInputService
    {
        private readonly Joystick _joystick;

        public MobileInputService(Joystick joystick)
        {
            _joystick = joystick;
        }

        public float HorizontalAxis => _joystick.Horizontal;
        public float VerticalAxis => _joystick.Vertical;
    }
}