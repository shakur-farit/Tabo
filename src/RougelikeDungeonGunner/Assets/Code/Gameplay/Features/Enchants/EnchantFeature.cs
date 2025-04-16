using Code.Infrastructure;

namespace Code.Gameplay.Features.Effects
{
	public sealed class EnchantFeature : Feature
	{
		public EnchantFeature(ISystemsFactory systems)
		{
			Add(systems.Create<PoisonEnchantSystem>());
		}
	}
}