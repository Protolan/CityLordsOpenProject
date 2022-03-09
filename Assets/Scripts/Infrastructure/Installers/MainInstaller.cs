using Factories;
using Zenject;

namespace Infrastructure.Installers
{
    public class MainInstaller: MonoInstaller
    {
        public override void InstallBindings() => Container.Bind<PlayerFactory>().AsSingle();
    }
}