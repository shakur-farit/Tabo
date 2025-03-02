using System;
using Code.Infrastructure.View;

namespace Code.Gameplay.Features.Abilities
{
	[Serializable]
	public class AbilityLevel
	{
		public EntityBehaviour ViewPrefab;
		public float Cooldown;
		public ProjectileSetup ProjectileSetup;
	}
}