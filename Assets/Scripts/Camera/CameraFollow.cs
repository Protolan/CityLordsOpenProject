using PlayerLogic;
using UnityEngine;
using Zenject;

namespace Camera
{
    public class CameraFollow: MonoBehaviour
    {
        [Inject] private Player _player;
        [SerializeField] private Vector3 _offsets;
        
        private void Update()
        {
            var position = _player.transform.position;
            transform.position = position + _offsets;
        }
    }
}