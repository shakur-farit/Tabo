using System.Collections.Generic;
using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Enemy.Systems
{
	public class EnemyMoveSystem : IExecuteSystem
	{
		private const float MinDistance = 0.5f;

		private readonly List<GameEntity> _buffer = new(32);

		private readonly IGroup<GameEntity> _enemies;

		public EnemyMoveSystem(GameContext game)
		{
			_enemies = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Enemy,
					GameMatcher.Path));
		}

		public void Execute()
		{
			foreach (GameEntity enemy in _enemies.GetEntities(_buffer))
			{
				Vector2 chaserPosition = enemy.WorldPosition;

				if (enemy.Path == null || enemy.Path.Count == 0)
				{
					enemy.isMoving = false;
					continue;
				}

				Vector2 target = enemy.Path[0];

				Vector2 direction = (target - chaserPosition).normalized;

				enemy.ReplaceDirection(direction);
				enemy.isMoving = true;

				if (Vector2.Distance(chaserPosition, enemy.Path[0]) < MinDistance)
					enemy.Path.RemoveAt(0);
			}
		}
	}
}