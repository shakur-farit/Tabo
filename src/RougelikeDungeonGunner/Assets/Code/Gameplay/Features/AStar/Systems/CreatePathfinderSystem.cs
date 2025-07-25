using System.Collections.Generic;
using Code.Common.Entity;
using Code.Common.Extensions;
using Entitas;

namespace Code.Gameplay.Features.Enemy.Systems
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
					.With(x => x.isPathfinder = true);

				dungeon.isPathfinderAvailable = true;
			}
		}
	}
}