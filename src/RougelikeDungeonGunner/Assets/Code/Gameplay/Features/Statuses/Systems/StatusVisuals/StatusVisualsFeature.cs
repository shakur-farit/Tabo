using Code.Infrastructure;
using Code.Infrastructure.Systems;

namespace Code.Gameplay.Features.Statuses.Systems.StatusVisuals
{
	public sealed class StatusVisualsFeature : Feature
	{
		public StatusVisualsFeature(ISystemsFactory systems)
		{
			Add(systems.Create<ApplyPoisonVisualsSystem>());
			Add(systems.Create<ApplyFreezeVisualsSystem>());
			Add(systems.Create<UnapplyPoisonVisualsSystem>());
			Add(systems.Create<UnapplyFreezeVisualsSystem>());
		}
	}
}