using UnityEngine;

namespace Code.Gameplay.Features.Ammo.Systems
{
	public interface IAmmoDirectionProvider
	{
		Vector3 GetDirection(GameEntity weapon);
	}
}