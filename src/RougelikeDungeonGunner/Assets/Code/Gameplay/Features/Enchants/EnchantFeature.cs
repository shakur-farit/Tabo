using Code.Gameplay.Features.Enchants.Systems;
using Code.Infrastructure;

namespace Code.Gameplay.Features.Enchants
{
	public sealed class EnchantFeature : Feature
	{
		public EnchantFeature(ISystemsFactory systems)
		{
			Add(systems.Create<PoisonEnchantSystem>());
		}
	}
}