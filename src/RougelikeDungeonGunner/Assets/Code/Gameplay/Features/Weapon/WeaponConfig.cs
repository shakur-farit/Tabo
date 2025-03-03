using System.Collections.Generic;
using Code.Gameplay.Features.Abilities;
using UnityEngine;

namespace Code.Gameplay.Features.Weapon
{
	[CreateAssetMenu(menuName = "Dungeon Gunner/Weapon Config", fileName = "WeaponConfig")]
	public class WeaponConfig : ScriptableObject
	{
		public WeaponId WeaponId;
		public AbilityId AbilityId;
		public Vector2 FirePosition;

		public List<WeaponLevel> Levels;
	}
}