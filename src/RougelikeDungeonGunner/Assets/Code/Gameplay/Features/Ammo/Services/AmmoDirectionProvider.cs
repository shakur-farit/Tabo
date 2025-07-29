using Code.Gameplay.Common.Random;
using UnityEngine;

namespace Code.Gameplay.Features.Ammo.Services
{
	public class AmmoDirectionProvider : IAmmoDirectionProvider
	{
		private readonly IRandomService _random;

		public AmmoDirectionProvider(IRandomService random) => 
			_random = random;

		public Vector3 GetDirection(GameEntity weapon)
		{
			float spreadAngle = _random.Range(weapon.MinPelletsDeviation, weapon.MaxPelletsDeviation);
			return Quaternion.Euler(0, 0, spreadAngle) * weapon.FirePositionTransform.right;
		}
	}
}