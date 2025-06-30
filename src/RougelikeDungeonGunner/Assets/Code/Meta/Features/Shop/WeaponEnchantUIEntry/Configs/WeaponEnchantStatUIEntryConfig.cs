using UnityEngine;

namespace Code.Meta.Features.Shop.WeaponEnchantUIEntry.Configs
{
	[CreateAssetMenu(menuName = "Dungeon Gunner/Weapon Information/Weapon Enchant Stat UI Entry Config",
		fileName = "WeaponEnchantStatUIEntryConfig")]
	public class WeaponEnchantStatUIEntryConfig : ScriptableObject
	{
		public WeaponEnchantStatUIEntryTypeId TypeId;
		public GameObject ViewPrefab;
	}
}