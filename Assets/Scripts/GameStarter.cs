using System;
using UnityEngine;
using Zenject;

namespace UI
{
    public class GameStarter: MonoBehaviour
    {
        [SerializeField] private string Init = "Main";

        [Inject] private SceneLoader _sceneLoader;

        private void Start() => _sceneLoader.Load(Init);
    }
}