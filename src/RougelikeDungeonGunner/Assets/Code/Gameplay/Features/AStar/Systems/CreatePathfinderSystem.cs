using System.Collections.Generic;
using Code.Common.Entity;
using Code.Common.Extensions;
using Entitas;

namespace Code.Gameplay.Features.AStar.Systems
{
	public class CreatePathfinderSystem : IExecuteSystem
	{
		private const float MinDistanceForRepath = 1f;

		private readonly List<GameEntity> _buffer = new(1);

		private readonly IGroup<GameEntity> _dungeons;

		public CreatePathfinderSystem(GameContext game)
		{
			_dungeons = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Dungeon,
					GameMatcher.EnemySpawnValidPositions)
				.NoneOf(GameMatcher.PathfinderAvailable));
		}

		public void Execute()
		{
			foreach (GameEntity dungeon in _dungeons.GetEntities(_buffer))
			{
				CreateGameEntity.Empty()
					.AddEnemySpawnValidPositions(dungeon.EnemySpawnValidPositions)
					.AddMinDistanceForRepath(MinDistanceForRepath)
					.AddPathfindingIntervalTimer(2f)
					.AddPathfindingTimerLeft(2f)
					.With(x => x.isPathfinder = true);

				dungeon.isPathfinderAvailable = true;
			}
		}
	}
}