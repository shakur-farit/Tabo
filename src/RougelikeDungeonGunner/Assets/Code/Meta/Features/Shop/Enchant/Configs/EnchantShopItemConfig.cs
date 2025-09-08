using System.Collections.Generic;
using Code.Gameplay.Features.Statuses;
using Code.Meta.Features.Shop.EnchantUIEntry.Configs;
using UnityEngine;

namespace Code.Meta.Features.Shop.Enchant.Configs
{
	[CreateAssetMenu(menuName = "Dungeon Gunner/Shop/Enchant Item Config", fileName = "EnchantItemConfig")]
	public class EnchantShopItemConfig : ScriptableObject
	{
		public EnchantShopItemTypeId TypeId;
		public GameObject ViewPrefab;
		public Sprite Sprite;
		[Range(1,10000)] public int Price;
		public StatusSetup Enchnat;
		public List<EnchantStatUIEntry> EnchantStatUIEntries;
	}
}