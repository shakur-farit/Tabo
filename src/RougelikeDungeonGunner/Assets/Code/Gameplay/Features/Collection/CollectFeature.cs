using Code.Gameplay.Features.Collection.Systems;
using Code.Infrastructure.Systems;

namespace Code.Gameplay.Features.Collection
{
	public sealed class CollectFeature : Feature
	{
		public CollectFeature(ISystemsFactory systems)
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