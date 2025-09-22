using Assets.Code.Infrastructure.Systems;
using Code.Common.Systems;

namespace Code.Common
{
	public sealed class ProcessMetaDestructedFeature : Feature
	{
		public ProcessMetaDestructedFeature(ISystemsFactory systems)
		{
			Add(systems.Create<CleanupMetaDestructedSystem>());
		}
	}
}