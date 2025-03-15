using System;
using System.Collections.Generic;
using Code.Gameplay.Features.Effects;
using Code.Gameplay.Features.Statuses;

namespace Code.Gameplay.Features.Ammo.Config
{
	[Serializable]
	public class AmmoLevel
	{
		public float Speed;
		public int Pierce = 1;
		public float ContactRadius;
		public List<EffectSetup> EffectSetups;
		public List<StatusSetup> StatusSetups;
	}
}