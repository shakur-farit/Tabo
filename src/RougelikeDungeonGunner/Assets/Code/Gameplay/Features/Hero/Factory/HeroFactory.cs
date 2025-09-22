using System;
using System.Collections.Generic;
using Assets.Code.Common.Extensions;
using Assets.Code.Gameplay.Features.Aura;
using Assets.Code.Gameplay.Features.CharacterStats;
using Assets.Code.Gameplay.Features.Collection;
using Assets.Code.Gameplay.Features.Hero.Configs;
using Assets.Code.Gameplay.Features.Weapon;
using Assets.Code.Gameplay.StaticData;
using Assets.Code.Infrastructure.Identifiers;
using Assets.Code.Progress.Provider;
using Code.Common.Entity;
using UnityEngine;

namespace Assets.Code.Gameplay.Features.Hero.Factory
{
	public class HeroFactory : IHeroFactory
	{
		private const float PickupRadius = 2f;
		private readonly IIdentifierService _identifier;
		private readonly IStaticDataService _staticDataService;
		private readonly IProgressProvider _progressProvider;

		public HeroFactory(
			IIdentifierService identifier, 
			IStaticDataService staticDataService,
			IProgressProvider progressProvider)
		{
			_identifier = identifier;
			_staticDataService = staticDataService;
			_progressProvider = progressProvider;
		}

		public GameEntity CreateHero(HeroTypeId typeId, Vector3 at)
		{
			switch (typeId)
			{
				case HeroTypeId.TheGeneral:
					return CreateTheGeneral(typeId, at);
				case HeroTypeId.TheScientist:
					return CreateTheScientist(typeId, at);
				case HeroTypeId.TheThief:
					return CreateTheThief(typeId, at);
			}

			throw new Exception($"Hero with type id {typeId} does not exist");
		}

		private GameEntity CreateTheGeneral(HeroTypeId typeId, Vector3 at) =>
			CreateHeroEntity(typeId, at)
				.With(x => x.isTheGeneral = true);
		private GameEntity CreateTheScientist(HeroTypeId typeId, Vector3 at) =>
			CreateHeroEntity(typeId, at)
				.With(x => x.isTheScientist = true);
		private GameEntity CreateTheThief(HeroTypeId typeId, Vector3 at) =>
			CreateHeroEntity(typeId, at)
				.With(x => x.isTheThief = true);

		private GameEntity CreateHeroEntity(HeroTypeId typeId, Vector3 at)
		{
			HeroConfig config = _staticDataService.GetHeroConfig(typeId);
			CollisionCastSetup castSetup = config.CastSetup;

			Dictionary<Stats, float> baseStats = InitStats.EmptyStatDictionary()
					.With(x => x[Stats.Speed] = config.MovementSpeed)
					.With(x => x[Stats.MaxHp] = config.MaxHp)
				;

			return CreateEntity.Empty()
					.AddId(_identifier.Next())
					.AddHeroTypeId(typeId)
					.AddWorldPosition(at)
					.AddDirection(Vector2.zero)
					.AddForwardCastDistance(castSetup.ForwardCastDistance)
					.AddBoxCastWidth(castSetup.Width)
					.AddBoxCastHeight(castSetup.Height)
					.AddBaseStats(baseStats)
					.AddStatModifiers(InitStats.EmptyStatDictionary())
					.AddCurrentHp(config.CurrentHp)
					.AddMaxHp(baseStats[Stats.MaxHp])
					.AddSpeed(baseStats[Stats.Speed])
					.AddViewPrefab(config.ViewPrefab)
					.AddCoins(_progressProvider.HeroData.CurrentCoinsCount)
					.AddPickupRadius(PickupRadius)
					.AddCurrentWeaponTypeId(CurrentWeapon(config))
					.AddAuraRequest(config.StartAura)
					.With(x => x.isHero = true)
					.With(x => x.isMovementAvailable = true)
					.With(x => x.isLinerMovement = true)
					.With(x => x.isUnweaponed = true)
				;
		}

		private WeaponTypeId CurrentWeapon(HeroConfig config)
		{
			if (_progressProvider.HeroData.CurrentWeaponTypeId == WeaponTypeId.Unknown)
			{
				_progressProvider.HeroData.CurrentWeaponTypeId = config.StartWeapon;
				return config.StartWeapon;
			}

			return _progressProvider.HeroData.CurrentWeaponTypeId;
		}
	}
}