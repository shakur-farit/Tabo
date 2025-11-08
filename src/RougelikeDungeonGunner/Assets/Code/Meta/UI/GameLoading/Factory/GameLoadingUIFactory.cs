using Code.Gameplay.StaticData;
using Zenject;

namespace Code.Meta.UI.Windows
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