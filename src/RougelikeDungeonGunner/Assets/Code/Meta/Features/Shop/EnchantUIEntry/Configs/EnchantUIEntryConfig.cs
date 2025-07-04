using System;
using System.Collections.Generic;
using UnityEngine;

namespace Code.Meta.Features.Shop.EnchantUIEntry.Configs
{
	[CreateAssetMenu(menuName = "Dungeon Gunner/Weapon Information/Enchant UI Entry Config", fileName = "EnchantUIEntryConfig")]
	public class EnchantUIEntryConfig : ScriptableObject
	{
		public EnchantUIEntryTypeId TypeId;
		public GameObject ViewPrefab;
		public Sprite Sprite;

		public List<EnchantStatUIEntry> EnchantStatUIEntries;
	}

	[Serializable]
	public class EnchantStatUIEntry
	{
		public EnchantStatUIEntryTypeId TypeId;
	}
}