using UnityEngine;

namespace Code.Gameplay.Features.Enemy.Factory
{
	public interface IEnemyFactory
	{
		GameEntity Create(Vector3 at);
	}
}