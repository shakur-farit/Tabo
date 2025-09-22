using Assets.Code.Infrastructure.Systems;
using Code.Common.Systems;

namespace Code.Common
{
	public sealed class ProcessInputDestructedFeature : Feature
	{
		public ProcessInputDestructedFeature(ISystemsFactory systems)
		{
			Add(systems.Create<CleanupInputDestructedSystem>());
		}
	}
}