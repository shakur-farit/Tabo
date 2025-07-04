using UnityEngine;

namespace Code.Meta.Features.Shop.EnchantUIEntry.Configs
{
	[CreateAssetMenu(menuName = "Dungeon Gunner/Weapon Information/Enchant Stat UI Entry Config",
		fileName = "EnchantStatUIEntryConfig")]
	public class EnchantStatUIEntryConfig : ScriptableObject
	{
		public EnchantStatUIEntryTypeId TypeId;
		public GameObject ViewPrefab;
	}
}