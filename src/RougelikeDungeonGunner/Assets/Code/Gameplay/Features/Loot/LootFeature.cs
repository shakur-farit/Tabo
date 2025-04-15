using Code.Gameplay.Features.Enemy;
using Code.Gameplay.Features.Loot.Systems;
using Code.Infrastructure;
using System;
using Code.Gameplay.Features.Enemy.Behaviours;
using Code.Gameplay.Features.Enemy.Configs;
using UnityEngine.Serialization;

namespace Code.Gameplay.Features.Loot
{
	public sealed class LootFeature : Feature
	{
		public LootFeature(ISystemsFactory systems)
		{
			Add(systems.Create<CastForPullableSystem>());

			Add(systems.Create<PullTowardsHeroSystem>());
			Add(systems.Create<CollectWhenNearToHeroSystem>());

			Add(systems.Create<CollectCoinsSystem>());
			Add(systems.Create<CollectEffectItemSystem>());
			Add(systems.Create<CollectTemporaryStatusItemSystem>());

			Add(systems.Create<CleanupCollectedSystem>());
		}
	}
}