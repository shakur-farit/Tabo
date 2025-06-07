using Code.Gameplay.Features.Statuses.Systems;
using Code.Gameplay.Features.Statuses.Systems.StatusVisuals;
using Code.Infrastructure;
using Code.Infrastructure.Systems;

namespace Code.Gameplay.Features.Statuses
{
	public sealed class StatusFeature : Feature
	{
		public StatusFeature(ISystemsFactory systems)
		{
			Add(systems.Create<StatusDurationSystem>());
			Add(systems.Create<PeriodicDamageStatusSystem>());
			Add(systems.Create<PeriodicDamageOnAreaStatusSystem>());
			Add(systems.Create<ApplyFreezeStatusSystem>());

			Add(systems.Create<StatusVisualsFeature>());

			Add(systems.Create<CleanupUnappliedStatusLinkedChangesSystem>());
			Add(systems.Create<CleanupUnappliedStatusesSystem>());
		}
	}
}