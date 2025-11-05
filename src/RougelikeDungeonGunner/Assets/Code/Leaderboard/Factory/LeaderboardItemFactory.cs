using Code.Gameplay.StaticData;
using UnityEngine;
using Zenject;

namespace Code.Meta.UI.Windows.Behaviours
{
	public class LeaderboardItemFactory : ILeaderboardItemFactory
	{
		private readonly IInstantiator _instantiator;
		private readonly IStaticDataService _staticDataService;

		public LeaderboardItemFactory(IInstantiator instantiator, IStaticDataService staticDataService)
		{
			_instantiator = instantiator;
			_staticDataService = staticDataService;
		}

		public LeaderboardItem Create(Transform parent)
		{
			LeaderboardConfig config = _staticDataService.GetLeaderboard();

			return _instantiator.InstantiatePrefabForComponent<LeaderboardItem>(config.ItemViewPrefab, parent);
		}
	}
}