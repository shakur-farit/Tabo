using System;

namespace Code.Gameplay.Features.Ammo.Config
{
	[Serializable]
	public class AmmoLevel
	{
		public float Speed;
		public int Pierce = 1;
		public float ContactRadius;
	}
}