using Code.Gameplay.Features.Enchants.Systems;
using Code.Gameplay.Features.Loot.Systems;
using Code.Infrastructure;

namespace Code.Gameplay.Features.Enchants
{
	public sealed class EnchantFeature : Feature
	{
		public EnchantFeature(ISystemsFactory systems)
		{
			Add(systems.Create<MarkEnchantAlreadyHeldSystem>());
			Add(systems.Create<UpdateAlreadyHeldEnchantTimeLeftSystem>());
			Add(systems.Create<AddEnchantToWeaponSystem>());
			Add(systems.Create<LimitWeaponEnchantsSystem>());

			Add(systems.Create<PoisonEnchantSystem>());
			Add(systems.Create<FreezeEnchantSystem>());

			Add(systems.Create<AddEnchantVisualToHolderSystem>());
			Add(systems.Create<UpdateEnchantTimeLeftVisualSystem>());

			Add(systems.Create<MarkDestructedOnEnchantTimeUpSystem>());
			Add(systems.Create<MarkDestructedOnEnchantAlreadyHeldSystem>());

			Add(systems.Create<RemoveEnchantFromWeaponSystem>());
			Add(systems.Create<RemoveEnchantVisualFromHolderSystem>());
		}
	}
}