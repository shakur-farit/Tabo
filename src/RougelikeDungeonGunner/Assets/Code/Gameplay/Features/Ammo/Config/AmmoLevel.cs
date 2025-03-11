using System;
using System.Collections.Generic;
using Code.Gameplay.Features.Effects;

namespace Code.Gameplay.Features.Ammo.Config
{
	[Serializable]
	public class AmmoLevel
	{
		public float Speed;
		public int Pierce = 1;
		public float ContactRadius;
		public List<EffectSetup> EffectSetups;
	}
}