using UnityEngine;

namespace Code.Meta.Features.Information.WeaponInformation.Configs
{
	[CreateAssetMenu(menuName = "Dungeon Gunner/Information/Weapon Stats UI Entry Config", fileName = "WeaponStatUIEntryConfig")]
	public class WeaponStatUIEntryConfig : ScriptableObject
	{
		public WeaponStatUIEntryTypeId TypeId;
		public GameObject ViewPrefab;
	}
}