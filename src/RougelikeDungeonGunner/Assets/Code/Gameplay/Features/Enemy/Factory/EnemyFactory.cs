using System;
using System.Collections.Generic;
using Code.Common.Entity;
using Code.Common.Extensions;
using Code.Infrastructure.Identifiers;
using UnityEngine;

namespace Code.Gameplay.Features.Enemy.Factory
{
	public class EnemyFactory : IEnemyFactory
	{
		private const string EnemyViewPath = "Enemy";

		private readonly IIdentifierService _identifier;


		public EnemyFactory(IIdentifierService identifier) =>
			_identifier = identifier;

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
			return CreateEntity.Empty()
					.AddId(_identifier.Next())
					.AddEnemyTypeId(EnemyTypeId.Orc)
					.AddWorldPosition(at)
					.AddDirection(Vector2.zero)
					.AddCurrentHp(3)
					.AddMaxHp(5)
					.AddDamage(1)
					.AddSpeed(1)
					.AddTargetsBuffer(new List<int>(1))
					.AddRadius(0.5f)
					.AddCollectTargetsInterval(0.5f)
					.AddCollectTargetsTimer(0)
					.AddLayerMask(CollisionLayer.Hero.AsMask())
					.AddViewPath(EnemyViewPath)
					.With(x => x.isEnemy = true)
					.With(x => x.isMovementAvailable = true)
				;
		}
	}
}