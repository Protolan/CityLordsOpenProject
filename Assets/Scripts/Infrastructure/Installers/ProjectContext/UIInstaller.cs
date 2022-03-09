using Sirenix.OdinInspector;
using UI;
using UnityEngine;
using Zenject;

namespace Infrastructure.Installers.ProjectContext
{
    public class UIInstaller: MonoInstaller
    {
        [SerializeField][AssetsOnly] private HUD _hud;
        public override void InstallBindings()
        {
            var hud = Container.InstantiatePrefabForComponent<HUD>(_hud);
            Container.Bind<HUD>().FromInstance(hud).AsSingle();
        }
        
    }
}