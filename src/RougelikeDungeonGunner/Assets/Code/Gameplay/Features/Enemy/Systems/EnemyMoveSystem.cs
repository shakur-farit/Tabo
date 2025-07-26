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
					GameMatcher.PendingPath));
		}

		public void Execute()
		{
			foreach (GameEntity enemy in _enemies.GetEntities(_buffer))
			{
				Vector2 chaserPosition = enemy.WorldPosition;

				if (enemy.hasCurrentPath == false)
					enemy.ReplaceCurrentPath(enemy.PendingPath);

				if (enemy.CurrentPath.Count == 0 || enemy.CurrentPath == null)
				{
					enemy.isMoving = false;
					continue;
				}

				Vector2 target = enemy.CurrentPath[0];

				Vector2 direction = (target - chaserPosition).normalized;

				enemy.ReplaceDirection(direction);
				enemy.isMoving = true;

				if (Vector2.Distance(chaserPosition, enemy.CurrentPath[0]) < MinDistance)
				{
					enemy.CurrentPath.RemoveAt(0);

					if (IsNewPathRequired(enemy.CurrentPath, enemy.PendingPath))
						enemy.ReplaceCurrentPath(enemy.PendingPath);
				}
			}
		}

		private bool IsNewPathRequired(List<Vector2Int> current, List<Vector2Int> pending)
		{
			if (current == null || current.Count == 0)
				return true;

			int pendingCount = pending.Count;
			int currentCount = current.Count;

			if (pendingCount < currentCount)
				return true;

			for (int i = 0; i < currentCount; i++)
			{
				if (pending[pendingCount - currentCount + i] != current[i])
					return true;
			}

			return false;
		}
	}
}