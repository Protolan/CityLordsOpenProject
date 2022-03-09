using AssetProvider;
using UnityEngine;
using Zenject;

namespace Factories
{
    public class PlayerFactory
    {
        private readonly IAssetProvider _provider;
        [Inject]
        public PlayerFactory(IAssetProvider provider) => _provider = provider;
        [Inject] private DiContainer _diContainer;

        private GameObject _player;

        public GameObject Player => _player;

        public GameObject CreatePlayer(Vector3 at)
        {
            var playerPrefab = _provider.GetObject<GameObject>(AssetPaths.Player);
            _player = _diContainer.InstantiatePrefab(playerPrefab, at, Quaternion.identity, null);
            return _player;
        }
    }
}