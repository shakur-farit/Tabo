using UnityEngine;

namespace Code.Gameplay.Features.Enemy.Systems
{
	public interface IEnemySpawnPositionProvider
	{
		Vector2 GetEnemyPosition(Vector2 roomMinPosition, Vector2 roomMaxPosition, Vector2 heroPosition, float safeZoneRadius);
	}
}