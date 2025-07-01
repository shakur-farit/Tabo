using Code.Gameplay.Features.Statuses;
using UnityEngine;

namespace Code.Meta.Features.Shop.WeaponStatUIEntry.Configs
{
	[CreateAssetMenu(menuName = "Dungeon Gunner/Shop/Enchant Item Config", fileName = "EnchantItemConfig")]
	public class EnchantShopItemConfig : ScriptableObject
	{
		public EnchantShopItemTypeId TypeId;
		public GameObject ViewPrefab;
		public Sprite Sprite;
		[Range(1,10000)] public int Price;
		public StatusSetup Enchnat;
	}
}