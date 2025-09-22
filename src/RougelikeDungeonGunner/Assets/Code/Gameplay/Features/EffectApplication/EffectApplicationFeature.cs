using Assets.Code.Gameplay.Features.EffectApplication.Systems;
using Assets.Code.Infrastructure.Systems;

namespace Assets.Code.Gameplay.Features.EffectApplication
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