using Code.Gameplay.Features.Ammo.Factory;
using Code.Gameplay.Features.TargetCollection;
using Code.Infrastructure.View;
using UnityEngine;

namespace Code.Gameplay.Features.Ammo.Configs
{
	[CreateAssetMenu(menuName = "Dungeon Gunner/Ammo Config", fileName = "AmmoConfig")]
	public class AmmoConfig : ScriptableObject
	{
		public AmmoTypeId TypeId;

		public EntityBehaviour ViewPrefab;

		public AmmoStats Stats;

		public CollisionCastSetup CastSetup;
	}
}