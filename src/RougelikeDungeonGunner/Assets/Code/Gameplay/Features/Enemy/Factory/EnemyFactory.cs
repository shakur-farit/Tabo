using System;
using System.Collections.Generic;
using Code.Common.Entity;
using Code.Common.Extensions;
using Code.Gameplay.Features.Effects;
using Code.Gameplay.StaticData;
using Code.Infrastructure.Identifiers;
using UnityEngine;

namespace Code.Gameplay.Features.Enemy.Factory
{
	public class EnemyFactory : IEnemyFactory
	{
		private const float AttackRadius = 0.5f;
		private const float AttackInterval = 0.5f;
		private const int TargetAmount = 1;
		private const float AttackTimerStartValue = 0;

		private readonly IIdentifierService _identifier;
		private readonly IStaticDataService _staticDataService;

		public EnemyFactory(IIdentifierService identifier, IStaticDataService staticDataService)
		{
			_identifier = identifier;
			_staticDataService = staticDataService;
		}

		public GameEntity CreateEnemy(Vector3 at, EnemyTypeId typeId)
		{
			switch (typeId)
			{
				case EnemyTypeId.Orc:
					return CreateOrc(at);
			}

			throw new Exception($"Enemy with type id {typeId} does not exist");
		}

		private GameEntity CreateOrc(Vector3 at)
		{
			EnemyConfig config = _staticDataService.GetEnemyConfig(EnemyTypeId.Orc);

			return CreateEnemyEntity(at, config)
					.AddEnemyTypeId(EnemyTypeId.Orc)
					.With(x => x.isOrc = true)
				;
		}

		private GameEntity CreateEnemyEntity(Vector3 at, EnemyConfig config)
		{
			return CreateEntity.Empty()
					.AddId(_identifier.Next())
					.AddWorldPosition(at)
					.AddDirection(Vector2.zero)
					.AddCurrentHp(config.CurrentHp)
					.AddMaxHp(config.MaxHp)
					.AddEffectSetups(new List<EffectSetup> { EffectSetup.FormId(EffectTypeId.Damage, config.Damage) })
					.AddSpeed(config.MovementSpeed)
					.AddTargetsBuffer(new List<int>(TargetAmount))
					.AddRadius(AttackRadius)
					.AddCollectTargetsInterval(AttackInterval)
					.AddCollectTargetsTimer(AttackTimerStartValue)
					.AddLayerMask(CollisionLayer.Hero.AsMask())
					.AddViewPrefab(config.PrefabView)
					.With(x => x.isEnemy = true)
					.With(x => x.isMovementAvailable = true)
				;
		}
	}
}