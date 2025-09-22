using Assets.Code.Common.Destruct.Systems;
using Assets.Code.Infrastructure.Systems;

namespace Assets.Code.Common.Destruct
{
	public sealed class ProcessMetaDestructedFeature : Feature
	{
		public ProcessMetaDestructedFeature(ISystemsFactory systems)
		{
			Add(systems.Create<CleanupMetaDestructedSystem>());
		}
	}
}