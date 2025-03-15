using Code.Infrastructure;

namespace Code.Gameplay.Features.Statuses
{
	public sealed class StatusFeature : Feature
	{
		public StatusFeature(ISystemsFactory systems)
		{
			Add(systems.Create<StatusDurationSystem>());

			Add(systems.Create<CleanupUnappliedStatusesSystem>());
		}
	}
}