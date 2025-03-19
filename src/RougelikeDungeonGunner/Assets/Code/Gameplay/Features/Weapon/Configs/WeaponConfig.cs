using System.Collections.Generic;
using Code.Gameplay.Features.Ammo;
using Code.Infrastructure.View;
using UnityEngine;

namespace Code.Gameplay.Features.Weapon.Configs
{
	[CreateAssetMenu(menuName = "Dungeon Gunner/Weapon Config", fileName = "WeaponConfig")]
	public class WeaponConfig : ScriptableObject
	{
		public WeaponId WeaponId;
		public EntityBehaviour PrefabView;
		public Sprite WeaponSprite;
		public AmmoId AmmoId;
		public Vector2 FirePosition;

		public List<WeaponLevel> Levels;
	}
}