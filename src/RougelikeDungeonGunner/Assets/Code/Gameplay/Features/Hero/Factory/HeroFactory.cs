using Code.Common.Entity;
using Code.Common.Extensions;
using Code.Infrastructure.Identifiers;
using System.Collections.Generic;
using Code.Gameplay.Features.CharacterStats;
using Code.Gameplay.StaticData;
using UnityEngine;
using System;
using Code.Gameplay.Features.Hero.Configs;

namespace Code.Gameplay.Features.Hero.Factory
{
	public class HeroFactory : IHeroFactory
	{
		private const int StartingCoinsCount = 0;
		private const float PickupRadius = 2f;
		private readonly IIdentifierService _identifier;
		private readonly IStaticDataService _staticDataService;


		public HeroFactory(IIdentifierService identifier, IStaticDataService staticDataService)
		{
			_identifier = identifier;
			_staticDataService = staticDataService;
		}

		public GameEntity CreateHero(HeroTypeId typeId, Vector3 at)
		{
			switch (typeId)
			{
				case HeroTypeId.TheGeneral:
					return CreateTheGeneral(typeId, at);
			}

			throw new Exception($"Hero with type id {typeId} does not exist");
		}

		private GameEntity CreateTheGeneral(HeroTypeId typeId, Vector3 at) =>
			CreateHeroEntity(typeId, at)
				.With(x => x.isTheGeneral = true);

		private GameEntity CreateHeroEntity(HeroTypeId typeId, Vector3 at)
		{
			HeroConfig config = _staticDataService.GetHeroConfig(HeroTypeId.TheGeneral);

			Dictionary<Stats, float> baseStats = InitStats.EmptyStatDictionary()
					.With(x => x[Stats.Speed] = config.MovementSpeed)
					.With(x => x[Stats.MaxHp] = config.MaxHp)
				;

			return CreateEntity.Empty()
					.AddId(_identifier.Next())
					.AddHeroTypeId(typeId)
					.AddWorldPosition(at)
					.AddDirection(Vector2.zero)
					.AddBaseStats(baseStats)
					.AddStatModifiers(InitStats.EmptyStatDictionary())
					.AddCurrentHp(baseStats[Stats.MaxHp])
					.AddMaxHp(baseStats[Stats.MaxHp])
					.AddSpeed(baseStats[Stats.Speed])
					.AddViewPrefab(config.ViewPrefab)
					.AddCoins(StartingCoinsCount)
					.AddPickupRadius(PickupRadius)
					.With(x => x.isHero = true)
					.With(x => x.isMovementAvailable = true)
					.With(x => x.isUnweaponed = true)
				;
		}
	}
}