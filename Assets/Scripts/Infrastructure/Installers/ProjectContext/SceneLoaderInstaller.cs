using UnityEngine;
using Zenject;

namespace Infrastructure.Installers.ProjectContext
{
    public class SceneLoaderInstaller : MonoInstaller, ICoroutineRunner
    {
        public override void InstallBindings()
        {
            Container.Bind<SceneLoader>().FromInstance(new SceneLoader(this)).AsSingle();
        }
        
        
    }
}