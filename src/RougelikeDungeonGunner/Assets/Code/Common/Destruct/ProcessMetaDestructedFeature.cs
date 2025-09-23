using Code.Common.Destruct.Systems;
using Code.Infrastructure.Systems;

namespace Code.Common.Destruct
{
	public sealed class ProcessMetaDestructedFeature : Feature
	{
		public ProcessMetaDestructedFeature(ISystemsFactory systems)
		{
			Add(systems.Create<CleanupMetaDestructedSystem>());
		}
	}
}