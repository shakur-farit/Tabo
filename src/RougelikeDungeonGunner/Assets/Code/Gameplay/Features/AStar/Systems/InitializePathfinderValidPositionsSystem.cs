using System.Collections.Generic;
using Code.Gameplay.Features.AStar.Services;
using Entitas;

namespace Code.Gameplay.Features.AStar.Systems
{
	public class InitializePathfinderValidPositionsSystem : IExecuteSystem
	{
		private readonly List<GameEntity> _buffer = new(1);

		private readonly IGroup<GameEntity> _pathfinders;
		private readonly IPathfinderInitializer _pathfinder;

		public InitializePathfinderValidPositionsSystem(GameContext game, IPathfinderInitializer pathfinder)
		{
			_pathfinder = pathfinder;
			_pathfinders = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Pathfinder,
					GameMatcher.ValidPositions)
				.NoneOf(GameMatcher.PathfinderInitialized));
		}

		public void Execute()
		{
			foreach (GameEntity pathfinders in _pathfinders.GetEntities(_buffer))
			{
				_pathfinder.Initialize(pathfinders.ValidPositions);

				pathfinders.isPathfinderInitialized = true;
			}
		}
	}
}