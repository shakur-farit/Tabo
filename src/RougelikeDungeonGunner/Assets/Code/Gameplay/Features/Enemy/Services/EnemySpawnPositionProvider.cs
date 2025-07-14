using Code.Gameplay.Common.Random;
using UnityEngine;

namespace Code.Gameplay.Features.Enemy.Systems
{
	public class EnemySpawnPositionProvider : IEnemySpawnPositionProvider
	{
		private readonly IRandomService _random;

		public EnemySpawnPositionProvider(IRandomService random) => 
			_random = random;

		public Vector2 GetEnemyPosition(Vector2 roomMinPosition, Vector2 roomMaxPosition, Vector2 heroPosition, float safeZoneRadius)
		{
			const int maxAttempts = 100;

			for (int i = 0; i < maxAttempts; i++)
			{
				Vector2 enemyPosition = GetRandomPosition(roomMinPosition, roomMaxPosition);

				if (Vector2.Distance(enemyPosition, heroPosition) > safeZoneRadius)
					return enemyPosition;
			}

			return GetRandomPosition(roomMinPosition, roomMaxPosition);
		}

		private Vector2 GetRandomPosition(Vector2 min, Vector2 max) =>
			new(_random.Range(min.x, max.x),
				_random.Range(min.y, max.y));
	}
}