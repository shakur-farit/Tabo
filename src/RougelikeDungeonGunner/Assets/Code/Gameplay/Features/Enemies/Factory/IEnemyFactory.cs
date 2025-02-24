using UnityEngine;

namespace Code.Gameplay.Features.Enemies
{
	public interface IEnemyFactory
	{
		GameEntity Create(Vector3 at);
	}
}