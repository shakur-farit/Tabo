using System;
using Code.Gameplay.Features.Hero.Configs;
using Code.Gameplay.Features.Hero.Services;
using Code.Gameplay.StaticData;
using UnityEngine;
using Zenject;

namespace Code.Meta.Features.Information.HeroInformation.Behaviours
{
	public class HeroInfoRenderer : MonoBehaviour
	{
		[SerializeField] private HeroStatsUIHolder _heroStatsUIHolder;

		private ICurrentHeroTypeIdProvider _currentHero;
		private IStaticDataService _staticData;

		[Inject]
		public void Constructor(ICurrentHeroTypeIdProvider currentHero, IStaticDataService staticData)
		{
			_currentHero = currentHero;
			_staticData = staticData;
		}

		private void Start() =>
			ShowStats();

		private void ShowStats()
		{
			HeroConfig config = _staticData.GetHeroConfig(_currentHero.CurrentHeroTypeId);

			foreach (HeroStatUIEntry statUIEntry in config.StatsUIEntry)
				_heroStatsUIHolder.CreateStatUIEntryItem(statUIEntry.StatUIEntryType, config);
		}
	}
}