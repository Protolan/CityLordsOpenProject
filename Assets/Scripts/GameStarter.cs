using System;
using UnityEngine;
using Zenject;

public class GameStarter: MonoBehaviour
{
    [SerializeField] private string InitialScene = "Main";

    [Inject] private SceneLoader _sceneLoader;

    private void Start() => _sceneLoader.Load(InitialScene);
}