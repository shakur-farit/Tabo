using Code.Gameplay.Features.SpecialEffect.Systems;
using Code.Infrastructure.Systems;

namespace Code.Gameplay.Features.SpecialEffect
{
	public sealed class SpecialEffectFeature : Feature
	{
		public SpecialEffectFeature(ISystemsFactory systems)
		{
			Add(systems.Create<CreateSpecialEffectSystem>());
			Add(systems.Create<SetupParticleSystemForSpecialEffectSystem>());
		}
	}
}