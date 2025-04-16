using Code.Gameplay.Features.Loot.Systems;
using Code.Infrastructure;

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

			Add(systems.Create<CleanupCollectedSystem>());
		}
	}
}