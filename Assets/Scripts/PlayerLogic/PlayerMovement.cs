using InputLogic;
using UnityEngine;
using Zenject;

namespace PlayerLogic
{
    [RequireComponent(typeof(CharacterController))]
    public class PlayerMovement : MonoBehaviour
    {
        [Inject] private IInputService _inputService;
        private CharacterController _characterController;
        [Min(0)] public float Speed = 10f;
        [Min(0)] public float Gravity = 10f;
        
        private void Start()
        {
            _characterController = GetComponent<CharacterController>();
        }

        private void Update()
        {
            var direction = Vector3.forward * _inputService.VerticalAxis + Vector3.right * +_inputService.HorizontalAxis;
            _characterController.Move(direction * Time.deltaTime * Speed);
            ApplyGravity();
        }

        private void ApplyGravity() => 
            _characterController.Move(Vector3.down * Time.deltaTime * Gravity);
    }
}