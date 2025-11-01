using Code.Gameplay.Features.SpecialEffect.Systems;
using Code.Infrastructure.Systems;

namespace Code.Gameplay.Features.SpecialEffect
{
	public sealed class SpecialEffectFeature : Feature
	{
		public SpecialEffectFeature(ISystemsFactory systems)
		{
			Add(systems.Create<CreateSpecialEffectOnShotSystem>());
			Add(systems.Create<CreatePoisonSpecialEffectSystem>());
			Add(systems.Create<SpecialEffectTargetFollowSystem>());

			Add(systems.Create<MarkSpecialEffectDestructedSystem>());
		}
	}
}