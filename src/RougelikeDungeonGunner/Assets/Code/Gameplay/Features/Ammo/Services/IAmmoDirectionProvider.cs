using UnityEngine;

namespace Assets.Code.Gameplay.Features.Ammo.Services
{
	public interface IAmmoDirectionProvider
	{
		Vector3 GetDirection(float minPelletsDeviation, float maxPelletsDeviation, Vector3 direction);
	}
}