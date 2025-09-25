using System.Collections.Generic;
using Entitas;

namespace Code.Gameplay.Features.Dungeon.Systems
{
	public class GetEnemySpawnValidPositionsSystem : IExecuteSystem
	{
    private readonly IValidPositionsProvider _validPositionsProvider;
    private readonly List<GameEntity> _buffer = new(1);

		private readonly IGroup<GameEntity> _dungeons;

		public GetEnemySpawnValidPositionsSystem(GameContext game, IValidPositionsProvider validPositionsProvider)
    {
      _validPositionsProvider = validPositionsProvider;
      _dungeons = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.CollisionTilemap,
					GameMatcher.EnemySpawnValidSprite)
				.NoneOf(GameMatcher.EnemySpawnValidPositions));
    }

		public void Execute()
		{
			foreach (GameEntity dungeon in _dungeons.GetEntities(_buffer))
			{
				dungeon.AddEnemySpawnValidPositions(_validPositionsProvider.GetValidPositions(dungeon.CollisionTilemap, dungeon.EnemySpawnValidSprite));
			}
		}
  }
}