using AssetProvider;
using UI;
using Zenject;
using Object = UnityEngine.Object;

namespace Factories
{
    public class UIFactory
    {
        private readonly IAssetProvider _provider;
        private HUD _hud;
        public HUD HUD => _hud;
        
        [Inject]
        public UIFactory(IAssetProvider provider) => _provider = provider;

        public HUD CreateHUD()
        {
            _hud = Object.Instantiate(_provider.GetObject<HUD>(AssetPaths.HUD));
            return _hud;
        }
    }
}