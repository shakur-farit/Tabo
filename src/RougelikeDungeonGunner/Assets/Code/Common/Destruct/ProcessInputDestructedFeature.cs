using Code.Common.Destruct.Systems;
using Code.Infrastructure.Systems;

namespace Code.Common.Destruct
{
	public sealed class ProcessInputDestructedFeature : Feature
	{
		public ProcessInputDestructedFeature(ISystemsFactory systems)
		{
			Add(systems.Create<CleanupInputDestructedSystem>());
		}
	}
}