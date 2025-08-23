using Code.Infrastructure.Systems;

namespace Code.Gameplay.Features.Ammo
{
	public sealed class AuraFeature : Feature
	{
		public AuraFeature(ISystemsFactory systems)
		{
			Add(systems.Create<ApplyAuraSystem>());
		}
	}
}