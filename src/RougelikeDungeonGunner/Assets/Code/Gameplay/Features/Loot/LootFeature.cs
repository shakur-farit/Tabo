using Assets.Code.Gameplay.Features.Loot.Systems;
using Assets.Code.Infrastructure.Systems;
using Assets.Code.Meta.Features.Hud.CoinsHolder.Systems;

namespace Assets.Code.Gameplay.Features.Loot
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
			Add(systems.Create<CollectEnchantItemSystem>());
			Add(systems.Create<CollectEffectItemSystem>());
			Add(systems.Create<CollectShieldItemSystem>());

			Add(systems.Create<UpdateCoinsTextInHolderSystem>());

			Add(systems.Create<CleanupCollectedSystem>());
		}
	}
}