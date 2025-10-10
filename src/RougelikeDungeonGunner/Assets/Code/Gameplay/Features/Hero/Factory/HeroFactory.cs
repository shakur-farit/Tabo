using System;
using System.Collections.Generic;
using Code.Common.Entity;
using Code.Common.Extensions;
using Code.Gameplay.Features.Aura;
using Code.Gameplay.Features.CharacterStats;
using Code.Gameplay.Features.Collection;
using Code.Gameplay.Features.Hero.Configs;
using Code.Gameplay.Features.Hero.Services;
using Code.Gameplay.Features.Weapon;
using Code.Gameplay.StaticData;
using Code.Infrastructure.Identifiers;
using UnityEngine;

namespace Code.Gameplay.Features.Hero.Factory
{
	public class HeroFactory : IHeroFactory
	{
		private const int BufferSize = 16;

		private readonly IIdentifierService _identifier;
		private readonly IStaticDataService _staticDataService;
    private readonly ICoinService _coinService;
    private readonly ICurrentHeroWeaponProvider _heroWeapon;

		public HeroFactory(
			IIdentifierService identifier, 
			IStaticDataService staticDataService,
			ICoinService coinService,
			ICurrentHeroWeaponProvider heroWeapon)
		{
			_identifier = identifier;
			_staticDataService = staticDataService;
      _coinService = coinService;
      _heroWeapon = heroWeapon;
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

			return CreateGameEntity.Empty()
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
					.AddCoins(_coinService.GetCurrentCoinCount())
					.AddPickupRadius(config.LootPickupRadius)
					.AddCurrentWeaponTypeId(CurrentWeapon(config))
					.AddAuraRequest(config.StartAura)
					.AddDestroyableTargetsBuffer(new(BufferSize))
					.AddDestroyableCollectRadius(config.DestroyableCollidingRadius)
					.AddDestroyableTargetLayerMask(CollisionLayer.Destroyable.AsMask())
					.With(x => x.isHero = true)
					.With(x => x.isMovementAvailable = true)
					.With(x => x.isLinerMovement = true)
					.With(x => x.isUnweaponed = true)
					.With(x => x.isReadyToCollectTargets = true)
					.With(x => x.isCollectTargetsContinuously = true)
					.With(x => x.isReusable = true)
				;
		}

		private WeaponTypeId CurrentWeapon(HeroConfig config)
		{
			if (_heroWeapon.CurrentWeaponTypeId == WeaponTypeId.Unknown)
			{
				_heroWeapon.SetCurrentHeroWeapon(config.StartWeapon);
				return config.StartWeapon;
			}

			return _heroWeapon.CurrentWeaponTypeId;
		}
	}
}