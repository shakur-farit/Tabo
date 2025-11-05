using Code.Gameplay.StaticData;
using Code.Leaderboard.Behaviours;
using Code.Leaderboard.Config;
using UnityEngine;
using Zenject;

namespace Code.Leaderboard.Factory
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