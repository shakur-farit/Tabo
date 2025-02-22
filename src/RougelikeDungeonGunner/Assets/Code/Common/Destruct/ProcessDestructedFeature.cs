using Code.Common.Systems;
using Code.Infrastructure;

namespace Code.Common
{
	public sealed class ProcessDestructedFeature : Feature
	{
		public ProcessDestructedFeature(ISystemsFactory systems)
		{
			Add(systems.Create<SelfDestructTimerSystem>());

			Add(systems.Create<CleanupGameDestructedViewSystem>());
			Add(systems.Create<CleanupGameDestructedSystem>());
		}
	}
}