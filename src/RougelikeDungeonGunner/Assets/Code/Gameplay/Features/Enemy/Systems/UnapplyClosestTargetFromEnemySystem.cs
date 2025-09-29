using System.Collections.Generic;
using Entitas;

namespace Code.Gameplay.Features.Enemy.Systems
{
	public class UnapplyClosestTargetFromEnemySystem : IExecuteSystem
	{
		private readonly IGroup<GameEntity> _enemies;
		private readonly List<GameEntity> _buffer = new(1);

		public UnapplyClosestTargetFromEnemySystem(GameContext game)
		{
			_enemies = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Enemy,
					GameMatcher.ClosestTarget));
		}

		public void Execute()
		{
      foreach (GameEntity enemy in _enemies.GetEntities(_buffer)) 
        enemy.isClosestTarget = false;
    }
	}
}