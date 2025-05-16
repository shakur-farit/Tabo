using Code.Infrastructure.View;
using UnityEngine;

namespace Code.Meta.Features.Shop.NewWeapon.Configs
{
	[CreateAssetMenu(menuName = "Dungeon Gunner/Shop/New Weapon Config", fileName = "WeaponConfig")]
	public class ShopWeaponConfig : ScriptableObject
	{
		public ShopWeaponTypeId TypeId;
		public EntityBehaviour ViewPrefab;
		public Sprite Sprite;
		[Range(0, 1000)] public int Price;
	}
}