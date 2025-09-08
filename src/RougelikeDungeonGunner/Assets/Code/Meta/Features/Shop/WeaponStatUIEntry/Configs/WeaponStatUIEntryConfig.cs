using UnityEngine;

namespace Code.Meta.Features.Shop.WeaponStatUIEntry.Configs
{
	[CreateAssetMenu(menuName = "Dungeon Gunner/Weapon Information/Weapon Stats UI Entry Config",
		fileName = "WeaponStatUIEntryConfig")]
	public class WeaponStatUIEntryConfig : ScriptableObject
	{
		public WeaponStatUIEntryTypeId TypeId;
		public GameObject ViewPrefab;
	}
}