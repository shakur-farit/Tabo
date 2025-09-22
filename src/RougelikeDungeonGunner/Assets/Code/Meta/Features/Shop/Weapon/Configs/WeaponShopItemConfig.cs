using Assets.Code.Gameplay.Features.Weapon;
using UnityEngine;

namespace Assets.Code.Meta.Features.Shop.Weapon.Configs
{
	[CreateAssetMenu(menuName = "Dungeon Gunner/Shop/Weapon Item Config", fileName = "WeaponItemConfig")]
	public class WeaponShopItemConfig : ScriptableObject
	{
		public WeaponShopItemTypeId TypeId;
		public WeaponTypeId WeaponTypeId;
		public GameObject ViewPrefab;
		public Sprite Sprite;
		[Range(0, 1000)] public int Price;
	}
}