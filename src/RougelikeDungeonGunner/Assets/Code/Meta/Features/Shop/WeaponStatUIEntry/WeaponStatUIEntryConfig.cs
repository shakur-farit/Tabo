using System.Text.RegularExpressions;
using UnityEngine;

namespace Code.Meta.Features.Shop.Weapon.Configs
{
	[CreateAssetMenu(menuName = "Dungeon Gunner/Shop/Weapon Stats UI Entry Config", fileName = "WeaponStatUIEntryConfig")]
	public class WeaponStatUIEntryConfig : ScriptableObject
	{
		public WeaponStatUIEntryTypeId TypeId;
		public GameObject ViewPrefab;
	}
}