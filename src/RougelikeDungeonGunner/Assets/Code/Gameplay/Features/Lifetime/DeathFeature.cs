using Assets.Code.Gameplay.Features.Lifetime.Systems;
using Assets.Code.Infrastructure.Systems;

namespace Assets.Code.Gameplay.Features.Lifetime
{
	public sealed class DeathFeature : Feature
	{
		public DeathFeature(ISystemsFactory systems)
		{
			Add(systems.Create<MarkDeadSystem>());
			Add(systems.Create<UnapplyStatusesOfDeadTargetSystem>());
		}
	}
}