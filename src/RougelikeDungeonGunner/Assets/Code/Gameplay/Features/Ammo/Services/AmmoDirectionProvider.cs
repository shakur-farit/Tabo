using Code.Gameplay.Common.Random;
using UnityEngine;

namespace Code.Gameplay.Features.Ammo.Services
{
	public class AmmoDirectionProvider : IAmmoDirectionProvider
	{
		private readonly IRandomService _random;

		public AmmoDirectionProvider(IRandomService random) => 
			_random = random;

		public Vector3 GetDirection(float minPelletsDeviation, float maxPelletsDeviation, Vector3 direction)
		{
			float spreadAngle = _random.Range(minPelletsDeviation, maxPelletsDeviation);
			return Quaternion.Euler(0, 0, spreadAngle) * direction;
		}
	}
}