using System.ComponentModel;
using InputLogic;
using Zenject;

namespace Infrastructure.Installers.ProjectContext
{
    public class InputServiceInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<IInputService>().To<StandaloneInputService>().AsSingle();
        }
    }
}