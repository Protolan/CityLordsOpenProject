using Factories;
using UnityEngine;
using Zenject;

namespace Camera
{
    public class CameraFollow: MonoBehaviour
    {
        [Inject] private PlayerFactory _playerFactory;
        [SerializeField] private Vector3 _offsets;
        
        private void Update()
        {
            var position = _playerFactory.Player.transform.position;
            transform.position = position + _offsets;
        }
    }
}