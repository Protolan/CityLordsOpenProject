using System;
using PlayerInput;
using Sirenix.OdinInspector;
using UnityEngine;
using Zenject;

namespace Movement
{
    [RequireComponent(typeof(CharacterController))]
    public class PlayerMovement : MonoBehaviour
    {
        [Inject] public IInputService _inputService;
        private CharacterController _characterController;
        public float Speed = 10f;
        
        private void Start()
        {
            _characterController = GetComponent<CharacterController>();
        }

        private void Update()
        {
            var direction = Vector3.forward * _inputService.VerticalAxis + Vector3.right * +_inputService.HorizontalAxis;
            _characterController.Move(direction * Time.deltaTime * Speed);
        }
    }
}