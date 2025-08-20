using Code.Gameplay.Features.TargetCollection.Systems;
using Code.Infrastructure.Systems;

namespace Code.Gameplay.Features.TargetCollection
{
	public sealed class CollectTargetsFeature : Feature
	{
		public CollectTargetsFeature(ISystemsFactory systems)
		{
			Add(systems.Create<CollectTargetsIntervalSystem>());
			Add(systems.Create<CastForTargetsWithNoLimitSystem>());
			Add(systems.Create<CastBoxForCollisionsSystem>());
			Add(systems.Create<CastLineForCollisionsSystem>());
			Add(systems.Create<CastForTargetsWithLimitSystem>());

			Add(systems.Create<MarkReachedSystem>());

			Add(systems.Create<CleanupTargetBuffersSystem>());
		}
	}
}