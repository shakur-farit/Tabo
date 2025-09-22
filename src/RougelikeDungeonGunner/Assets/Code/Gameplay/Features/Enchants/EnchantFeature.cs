using Assets.Code.Gameplay.Features.Enchants.Systems;
using Assets.Code.Infrastructure.Systems;
using Assets.Code.Meta.Features.Hud.EnchantHolder.Systems;

namespace Assets.Code.Gameplay.Features.Enchants
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
			Add(systems.Create<FlameEnchantSystem>());
			Add(systems.Create<ExplosiveEnchantSystem>());

			Add(systems.Create<AddEnchantVisualToHolderSystem>());
			Add(systems.Create<UpdateEnchantTimeLeftVisualSystem>());

			Add(systems.Create<MarkDestructedOnEnchantTimeUpSystem>());
			Add(systems.Create<MarkDestructedOnEnchantAlreadyHeldSystem>());

			Add(systems.Create<RemoveEnchantFromWeaponSystem>());
			Add(systems.Create<RemoveEnchantVisualFromHolderSystem>());
		}
	}
}