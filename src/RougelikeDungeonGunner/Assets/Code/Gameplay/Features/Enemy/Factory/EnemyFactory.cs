using System;
using System.Collections.Generic;
using Code.Common.Entity;
using Code.Common.Extensions;
using Code.Gameplay.Features.CharacterStats;
using Code.Gameplay.Features.Effects;
using Code.Gameplay.Features.Enemy.Configs;
using Code.Gameplay.Features.TargetCollection;
using Code.Gameplay.Features.Weapon;
using Code.Gameplay.StaticData;
using Code.Infrastructure.Identifiers;
using UnityEngine;

namespace Code.Gameplay.Features.Enemy.Factory
{
	public class EnemyFactory : IEnemyFactory
	{
		private const float AttackTimerStartValue = 0;

		private readonly IIdentifierService _identifier;
		private readonly IStaticDataService _staticDataService;

		public EnemyFactory(IIdentifierService identifier, IStaticDataService staticDataService)
		{
			_identifier = identifier;
			_staticDataService = staticDataService;
		}

		public GameEntity CreateEnemy(EnemyTypeId typeId, Vector3 at)
		{
			switch (typeId)
			{
				case EnemyTypeId.Orc:
					return CreateOrc(typeId, at);
				case EnemyTypeId.Hedusa:
					return CreateHedusa(typeId, at);
			}

			throw new Exception($"Enemy with type id {typeId} does not exist");
		}

		private GameEntity CreateOrc(EnemyTypeId typeId, Vector3 at) =>
			CreateEnemyEntity(typeId, at)
				.With(x => x.isOrc = true);

		private GameEntity CreateHedusa(EnemyTypeId typeId, Vector3 at) =>
			CreateEnemyEntity(typeId, at)
				.With(x => x.isHedusa = true);

		private GameEntity CreateEnemyEntity(EnemyTypeId typeId, Vector3 at)
		{
			EnemyConfig config = _staticDataService.GetEnemyConfig(typeId);
			CollisionCastSetup castSetup = config.CastSetup;

			Dictionary<Stats, float> baseStats = InitStats.EmptyStatDictionary()
					.With(x => x[Stats.Speed] = config.MovementSpeed)
					.With(x => x[Stats.MaxHp] = config.MaxHp)
					.With(x => x[Stats.Damage] = config.Damage)
				;
			return CreateEntity.Empty()
					.AddId(_identifier.Next())
					.AddEnemyTypeId(typeId)
					.AddWorldPosition(at)
					.AddLastTargetPosition(default)
					.AddDirection(Vector2.zero)
					.AddBaseStats(baseStats)
					.AddStatModifiers(InitStats.EmptyStatDictionary())
					.AddCurrentHp(config.CurrentHp)
					.AddMaxHp(baseStats[Stats.MaxHp])
					.AddEffectSetups(new List<EffectSetup> { EffectSetup.FormId(EffectTypeId.Damage, baseStats[Stats.Damage]) })
					.AddSpeed(baseStats[Stats.Speed])
					.AddBoxCastWidth(castSetup.Width)
					.AddBoxCastHeight(castSetup.Height)
					.AddTargetsBuffer(new List<int>(config.TargetAmount))
					.AddRadius(config.AttackRaduis)
					.AddCollectTargetsInterval(config.AttackInterlal)
					.AddCollectTargetsTimer(AttackTimerStartValue)
					.AddTargetLayerMask(CollisionLayer.Hero.AsMask())
					.AddViewPrefab(config.ViewPrefab)
					.With(x => x.AddCurrentWeaponTypeId(config.StartWeapon), when: config.StartWeapon != WeaponTypeId.NoWeapon)
					.With(x => x.isEnemy = true)
					.With(x => x.isMovementAvailable = true)
					.With(x => x.isLinerMovement = true)
					.With(x => x.isUnweaponed = true)
				;

		}
	}
}