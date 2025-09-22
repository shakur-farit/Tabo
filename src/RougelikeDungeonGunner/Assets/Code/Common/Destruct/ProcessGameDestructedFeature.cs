using Assets.Code.Infrastructure.Systems;
using Code.Common.Systems;

namespace Code.Common
{
	public sealed class ProcessGameDestructedFeature : Feature
	{
		public ProcessGameDestructedFeature(ISystemsFactory systems)
		{
			Add(systems.Create<SelfDestructTimerSystem>());

			Add(systems.Create<CleanupGameDestructedViewSystem>());
			Add(systems.Create<CleanupGameDestructedSystem>());
		}
	}
}