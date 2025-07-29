using Code.Gameplay.Features.AStar.Systems;
using Code.Infrastructure.Systems;

namespace Code.Gameplay.Features.AStar
{
	public sealed class PathfindingFeature : Feature
	{
		public PathfindingFeature(ISystemsFactory systems)
		{
			Add(systems.Create<CreatePathfinderSystem>());
			Add(systems.Create<InitializePathfinderValidPositionsSystem>());
			Add(systems.Create<PathfindingTimerSystem>());
			Add(systems.Create<PathFindingSystem>());
		}
	}
}