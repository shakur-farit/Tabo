using Assets.Code.Gameplay.Features.SpecialEffect.Systems;
using Assets.Code.Infrastructure.Systems;

namespace Assets.Code.Gameplay.Features.SpecialEffect
{
	public sealed class SpecialEffectFeature : Feature
	{
		public SpecialEffectFeature(ISystemsFactory systems)
		{
			Add(systems.Create<CreateSpecialEffectSystem>());
		}
	}
}