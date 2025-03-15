using Code.Gameplay.Features.EffectApplication.Systems;
using Code.Infrastructure;

namespace Code.Gameplay.Features.EffectApplication
{
	public sealed class EffectApplicationFeature : Feature
	{
		public EffectApplicationFeature(ISystemsFactory systems)
		{
			Add(systems.Create<ApplyEffectsOnTargetsSystem>());
			Add(systems.Create<ApplyStatusesOnTargetsSystem>());
		}
	}
}