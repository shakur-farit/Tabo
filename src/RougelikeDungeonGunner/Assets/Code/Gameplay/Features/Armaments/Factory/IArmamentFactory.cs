using UnityEngine;

namespace Code.Gameplay.Features.Armaments
{
	public interface IArmamentFactory
	{
		GameEntity CreatePistolBullet(int level, Vector3 at);
	}
}