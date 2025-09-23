using System.Collections.Generic;
using Code.Common.Entity;
using Code.Common.Extensions;
using Code.Gameplay.Features.AStar.Services;
using Entitas;

namespace Code.Gameplay.Features.AStar.Systems
{
	public class CreatePathfinderSystem : IExecuteSystem
	{
		private readonly IPathfinderInitializer _pathfinder;
		private const float MinDistanceForRepath = 1f;

		private readonly List<GameEntity> _buffer = new(1);

		private readonly IGroup<GameEntity> _dungeons;

		public CreatePathfinderSystem(GameContext game, IPathfinderInitializer pathfinder)
		{
			_pathfinder = pathfinder;
			_dungeons = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Dungeon,
					GameMatcher.ValidPositions)
				.NoneOf(GameMatcher.PathfinderAvailable));
		}

		public void Execute()
		{
			foreach (GameEntity dungeon in _dungeons.GetEntities(_buffer))
			{
				CreateEntity.Empty()
					.AddValidPositions(dungeon.ValidPositions)
					.AddMinDistanceForRepath(MinDistanceForRepath)
					.AddPathfindingIntervalTimer(2f)
					.AddPathfindingTimerLeft(2f)
					.With(x => x.isPathfinder = true);

				dungeon.isPathfinderAvailable = true;
			}
		}
	}
}