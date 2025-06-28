using UnityEngine;

namespace Code.Meta.Features.Shop.Weapon.Configs
{
	[CreateAssetMenu(menuName = "Dungeon Gunner/Shop/Weapon Stats Description Config", fileName = "WeaponStatUIEntryConfig")]
	public class WeaponStatUIEntryConfig : ScriptableObject
	{
		public WeaponStatUIEntryTypeId Id;
		public float Value;
		public GameObject ViewPrefab;
	}
}