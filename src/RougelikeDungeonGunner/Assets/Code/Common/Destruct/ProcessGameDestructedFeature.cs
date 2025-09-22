using Assets.Code.Common.Destruct.Systems;
using Assets.Code.Infrastructure.Systems;

namespace Assets.Code.Common.Destruct
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