using Code.Gameplay.Features.Loot.Systems;
using Code.Infrastructure.Systems;
using Code.Meta.Features.Hud.CoinsHolder.Systems;

namespace Code.Gameplay.Features.Loot
{
	public sealed class LootFeature : Feature
	{
		public LootFeature(ISystemsFactory systems)
		{
			Add(systems.Create<SetLootSpriteSystem>());

			Add(systems.Create<CastForPullableSystem>());

			Add(systems.Create<PullTowardsHeroSystem>());
			Add(systems.Create<CollectWhenNearToHeroSystem>());

			Add(systems.Create<CollectCoinsSystem>());
			Add(systems.Create<CollectBulletSystem>());
			Add(systems.Create<CollectMissileSystem>());
			Add(systems.Create<CollectEnchantItemSystem>());
			Add(systems.Create<CollectEffectItemSystem>());
			Add(systems.Create<CollectShieldItemSystem>());

			Add(systems.Create<UpdateCoinsTextInHolderSystem>());

			Add(systems.Create<CleanupCollectedSystem>());
		}
	}
}