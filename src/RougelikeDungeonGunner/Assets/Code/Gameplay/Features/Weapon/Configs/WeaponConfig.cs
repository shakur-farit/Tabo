using System.Collections.Generic;
using Code.Gameplay.Features.Abilities;
using UnityEngine;

namespace Code.Gameplay.Features.Weapon
{
	[CreateAssetMenu(menuName = "Dungeon Gunner/Weapon Config", fileName = "WeaponConfig")]
	public class WeaponConfig : ScriptableObject
	{
		public WeaponId WeaponId;
		public Sprite WeaponSprite;
		public AbilityId AmmoId;
		public Vector2 FirePosition;

		public List<WeaponLevel> Levels;
	}
}