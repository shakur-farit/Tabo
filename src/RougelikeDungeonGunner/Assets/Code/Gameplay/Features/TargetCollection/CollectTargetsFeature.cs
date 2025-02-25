using Code.Gameplay.Features.TargetCollection.Systems;
using Code.Infrastructure;

namespace Code.Gameplay.Features.TargetCollection
{
	public sealed class CollectTargetsFeature : Feature
	{
		public CollectTargetsFeature(ISystemsFactory systems)
		{
			Add(systems.Create<CollectTargetsIntervalSystem>());
			Add(systems.Create<CastForTargetSystem>());

			Add(systems.Create<CleanupTargetBuffersSystem>());
		}
	}
}