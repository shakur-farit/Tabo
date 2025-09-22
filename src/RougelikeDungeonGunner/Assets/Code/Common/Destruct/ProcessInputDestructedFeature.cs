using Assets.Code.Common.Destruct.Systems;
using Assets.Code.Infrastructure.Systems;

namespace Assets.Code.Common.Destruct
{
	public sealed class ProcessInputDestructedFeature : Feature
	{
		public ProcessInputDestructedFeature(ISystemsFactory systems)
		{
			Add(systems.Create<CleanupInputDestructedSystem>());
		}
	}
}