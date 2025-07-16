using System.Collections.Generic;
using UnityEngine;

namespace Code.Gameplay.Features.Enemy.Systems
{
	public interface IEnemySpawnPositionProvider
	{
		Vector2 GetEnemyPosition(Vector2 heroPosition, float safeZoneRadius, List<Vector2> validPositions);
	}
}