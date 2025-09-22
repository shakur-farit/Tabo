using UnityEngine;

namespace Assets.Code.Gameplay.Features.Enemy.Factory
{
	public interface IEnemyFactory
	{
		GameEntity CreateEnemy(EnemyTypeId typeId, Vector3 at);
	}
}