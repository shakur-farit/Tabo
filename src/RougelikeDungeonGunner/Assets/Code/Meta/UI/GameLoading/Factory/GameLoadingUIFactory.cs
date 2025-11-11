using Code.Gameplay.StaticData;
using Code.Meta.UI.GameLoading.Behaviours;
using Code.Meta.UI.GameLoading.Config;
using Zenject;

namespace Code.Meta.UI.GameLoading.Factory
{
	public class GameLoadingUIFactory : IGameLoadingUIFactory
	{
		private readonly IInstantiator _instantiator;
		private readonly IStaticDataService _staticDataService;

		public GameLoadingUIFactory(IInstantiator instantiator, IStaticDataService staticDataService)
		{
			_instantiator = instantiator;
			_staticDataService = staticDataService;
		}

		public GameLoadingUI CreateGameLoadingUI()
		{
			GameLoadingUIConfig config = _staticDataService.GetGameLoadingUIConfig();

			return _instantiator.InstantiatePrefabForComponent<GameLoadingUI>(config.ViewPrefab);
		}
	}
}