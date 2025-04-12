using System.Collections.Generic;
using Code.Infrastructure.View;
using UnityEngine;

namespace Code.Gameplay.Features.Weapon.Configs
{
	[CreateAssetMenu(menuName = "Dungeon Gunner/Weapon Config", fileName = "WeaponConfig")]
	public class WeaponConfig : ScriptableObject
	{
		public WeaponTypeId WeaponTypeId;
		public EntityBehaviour ViewPrefab;
		public Sprite Sprite;
		public Vector2 FirePosition;

		public List<WeaponLevel> Levels;
	}
}