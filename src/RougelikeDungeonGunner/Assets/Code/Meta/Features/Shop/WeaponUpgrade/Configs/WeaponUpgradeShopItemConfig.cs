using UnityEngine;

namespace Code.Meta.Features.Shop.WeaponUpgrade.Configs
{
	[CreateAssetMenu(menuName = "Dungeon Gunner/Shop/Weapon Upgrade Item Config", fileName = "WeaponUpgradeItemConfig")]
	public class WeaponUpgradeShopItemConfig : ScriptableObject
	{
		public WeaponUpgradeTypeId TypeId;
		public GameObject ViewPrefab;
		[Range(0, 10000)] public int Price;
		[Range(0, 1000)] public float UpgradeValue;
	}
}