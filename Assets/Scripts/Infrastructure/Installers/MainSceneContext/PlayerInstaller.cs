using PlayerLogic;
using Sirenix.OdinInspector;
using UnityEngine;
using Zenject;

namespace Infrastructure.Installers.MainSceneContext
{
    public class PlayerInstaller : MonoInstaller
    {
        [SerializeField][AssetsOnly] private Player _player;
        [SerializeField][SceneObjectsOnly] private Transform _spawnPosition;

        public override void InstallBindings()
        {
            var player = Container
                .InstantiatePrefabForComponent<Player>(_player, _spawnPosition.position, Quaternion.identity, null);
            Container.Bind<Player>().FromInstance(player).AsSingle();
        }
    }
}