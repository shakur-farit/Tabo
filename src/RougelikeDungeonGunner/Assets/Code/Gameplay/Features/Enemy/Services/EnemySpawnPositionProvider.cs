using System.Collections.Generic;
using Code.Gameplay.Common.Random;
using UnityEngine;

namespace Code.Gameplay.Features.Enemy.Systems
{
	public class EnemySpawnPositionProvider : IEnemySpawnPositionProvider
	{
		private readonly IRandomService _random;

		public EnemySpawnPositionProvider(IRandomService random) => 
			_random = random;

		public Vector2 GetEnemyPosition(Vector2 heroPosition, float safeZoneRadius, List<Vector2> validPositions)
		{
			var position = GetRandomPosition(validPositions);

			if (Vector2.Distance(position, heroPosition) > safeZoneRadius)
				return position;
				

			return GetRandomPosition(validPositions);
		}

		private Vector2 GetRandomPosition(List<Vector2> validPositions)
		{
			int randomIndex = _random.Range(0, validPositions.Count);
			return validPositions[randomIndex];
		}
	}
}