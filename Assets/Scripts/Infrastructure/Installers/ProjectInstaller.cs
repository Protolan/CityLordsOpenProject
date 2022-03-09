using System;
using AssetProvider;
using Factories;
using PlayerInput;
using Zenject;

namespace Infrastructure.Installers
{
    public class ProjectInstaller : MonoInstaller, ICoroutineRunner
    {
        
        public override void InstallBindings()
        {
            Container.Bind<IAssetProvider>().To<ResourceAssetProvider>().AsSingle();
            Container.Bind<UIFactory>().AsSingle();
            Container.Bind<SceneLoader>().FromInstance(new SceneLoader(this)).AsSingle();
            Container.Bind<IInputService>().To<StandaloneInputService>().AsSingle();
        }
        
        
    }
}