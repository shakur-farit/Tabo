using UnityEngine;
using UnityEngine.Serialization;

namespace Code.Meta.Features.Shop.WeaponUpgrade.Configs
{
	[CreateAssetMenu(menuName = "Dungeon Gunner/Shop/Weapon Upgrade Item Config", fileName = "UpgradeItemConfig")]
	public class WeaponUpgradeShopItemConfig : ScriptableObject
	{
		public WeaponUpgradeShopItemTypeId TypeId;
		public GameObject ViewPrefab;
		[Range(0, 1000)] public int Price;
		[FormerlySerializedAs("UpgareValue")] [Range(0, 1000)] public float UpgradeValue;
	}
}