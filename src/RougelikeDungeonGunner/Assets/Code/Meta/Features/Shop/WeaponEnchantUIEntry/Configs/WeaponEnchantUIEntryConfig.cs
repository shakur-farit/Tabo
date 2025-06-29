using System.Collections.Generic;
using UnityEngine;

namespace Code.Meta.Features.Shop.Weapon.Configs
{
	[CreateAssetMenu(menuName = "Dungeon Gunner/Shop/Weapon Enchant UI Entry Config", fileName = "WeaponEnchantUIEntryConfig")]
	public class WeaponEnchantUIEntryConfig : ScriptableObject
	{
		public WeaponEnchantUIEntryTypeId TypeId;
		public GameObject ViewPrefab;
		public Sprite Sprite;

		public List<EnchantStatUIEntry> EnchantStatUIEntries;
	}

	[SerializeField]
	public class EnchantStatUIEntry
	{
		public WeaponEnchantStatsUIEntryTypeId TypeId;
	}
}