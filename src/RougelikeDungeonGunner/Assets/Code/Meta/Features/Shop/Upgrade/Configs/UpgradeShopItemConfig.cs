using Code.Infrastructure.View;
using UnityEngine;

namespace Code.Meta.Features.Shop.WeaponUpgrade.Configs
{
	[CreateAssetMenu(menuName = "Dungeon Gunner/Shop/Upgrade Item Config", fileName = "UpgradeItemConfig")]
	public class UpgradeShopItemConfig : ScriptableObject
	{
		public UpgradeShopItemTypeId TypeId;
		public EntityBehaviour ViewPrefab;
		[Range(0, 1000)] public int Price;
	}
}