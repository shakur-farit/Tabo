using Code.Gameplay.Features.Enchants.Systems;
using Code.Infrastructure.Systems;

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
			Add(systems.Create<FlameEnchantSystem>());
			Add(systems.Create<ExplosiveEnchantSystem>());

			Add(systems.Create<MarkDestructedOnEnchantTimeUpSystem>());
			Add(systems.Create<MarkDestructedOnEnchantAlreadyHeldSystem>());

			Add(systems.Create<RemoveEnchantFromWeaponSystem>());
		}
	}
}