using UnityEngine;

namespace Code.Gameplay.Features.Ammo.Services
{
	public interface IAmmoDirectionProvider
	{
		Vector3 GetDirection(GameEntity weapon);
	}
}