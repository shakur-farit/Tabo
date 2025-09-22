using System.Collections.Generic;
using UnityEngine;

namespace Assets.Code.Gameplay.Features.Enemy.Services
{
	public interface IEnemySpawnPositionProvider
	{
		Vector2 GetEnemyPosition(Vector2 heroPosition, float safeZoneRadius, List<Vector2Int> validPositions);
	}
}