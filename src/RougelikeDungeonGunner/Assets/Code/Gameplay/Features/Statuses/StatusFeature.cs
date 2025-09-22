using Assets.Code.Gameplay.Features.Statuses.Systems;
using Assets.Code.Gameplay.Features.Statuses.Systems.StatusVisuals;
using Assets.Code.Infrastructure.Systems;

namespace Assets.Code.Gameplay.Features.Statuses
{
	public sealed class StatusFeature : Feature
	{
		public StatusFeature(ISystemsFactory systems)
		{
			Add(systems.Create<StatusDurationSystem>());
			Add(systems.Create<PeriodicDamageStatusSystem>());
			Add(systems.Create<PeriodicDamageOnAreaStatusSystem>());
			Add(systems.Create<ApplyFreezeStatusSystem>());
			Add(systems.Create<DamageOnAreaStatusSystem>());

			Add(systems.Create<StatusVisualsFeature>());

			Add(systems.Create<CleanupUnappliedStatusLinkedChangesSystem>());
			Add(systems.Create<CleanupUnappliedStatusesSystem>());
		}
	}
}