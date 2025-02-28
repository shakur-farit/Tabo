using UnityEngine;

namespace Code.Gameplay.Features.Enemy.Factory
{
	public interface IEnemyFactory
	{
		GameEntity CreateEnemy(Vector3 at, EnemyTypeId typeId);
	}
}