using Code.Gameplay.Features.Enchants.Systems;
using Code.Infrastructure;
using Code.Meta.UI.Hud.EnchantHolder.Systems;

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
			Add(systems.Create<ExplosionEnchantSystem>());

			Add(systems.Create<AddEnchantVisualToHolderSystem>());
			Add(systems.Create<UpdateEnchantTimeLeftVisualSystem>());

			Add(systems.Create<MarkDestructedOnEnchantTimeUpSystem>());
			Add(systems.Create<MarkDestructedOnEnchantAlreadyHeldSystem>());

			Add(systems.Create<RemoveEnchantFromWeaponSystem>());
			Add(systems.Create<RemoveEnchantVisualFromHolderSystem>());
		}
	}
}