using Code.Infrastructure.View;
using UnityEngine;

namespace Code.Meta.Features.Shop.WeaponUpgrade.Configs
{
	[CreateAssetMenu(menuName = "Dungeon Gunner/Shop/Weapon Upgrade Config", fileName = "UpgradeConfig")]
	public class ShopWeaponUpgradeConfig : ScriptableObject
	{
		public ShopWeaponUpgradeTypeId TypeId;
		public EntityBehaviour ViewPrefab;
		[Range(0, 1000)] public int Price;
	}
}