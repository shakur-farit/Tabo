using Code.Gameplay.Features.Enchants.Systems;
using Code.Infrastructure;

namespace Code.Gameplay.Features.Enchants
{
	public sealed class EnchantFeature : Feature
	{
		public EnchantFeature(ISystemsFactory systems)
		{
			Add(systems.Create<PoisonEnchantSystem>());
			Add(systems.Create<FreezeEnchantSystem>());
			
			Add(systems.Create<AddEnchantVisualToHolderSystem>());
			Add(systems.Create<UpdateEnchantTimeLeftVisualSystem>());

			Add(systems.Create<MarkEnchantDestructedSystem>());
			Add(systems.Create<RemoveEnchantFromWeaponSystem>());
			Add(systems.Create<RemoveEnchantVisualFromHolderSystem>());
		}
	}
}