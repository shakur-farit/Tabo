﻿using Code.Gameplay.Features.Enemy.Systems;
using Code.Infrastructure;

namespace Code.Gameplay.Features.Enemy
{
	public sealed class EnemyFeature : Feature
	{
		public EnemyFeature(ISystemsFactory systems)
		{
			Add(systems.Create<ChaseHeroSystem>());
			Add(systems.Create<AnimateEnemyMovementSystem>());
			Add(systems.Create<EnemyDeathSystem>());
			Add(systems.Create<FinalizeEnemyDeathProcessingSystem>());
		}
	}
}