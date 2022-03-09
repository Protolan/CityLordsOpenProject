using System;
using Factories;
using PlayerInput;
using UnityEngine;
using Zenject;

namespace Infrastructure.Installers
{
    public class MainSceneLoader: MonoBehaviour
    {
        [SerializeField] private Transform SpawnPoint;
        [Inject] private UIFactory _uiFactory;
        [Inject] private PlayerFactory _playerFactory;
        [Inject] private IInputService _inputService;
        private void Start()
        {
            _uiFactory.CreateHUD();
       
            _playerFactory.CreatePlayer(SpawnPoint.position);
        }

        private void Update()
        {
            Debug.Log(_inputService.HorizontalAxis);
        }
    }
}