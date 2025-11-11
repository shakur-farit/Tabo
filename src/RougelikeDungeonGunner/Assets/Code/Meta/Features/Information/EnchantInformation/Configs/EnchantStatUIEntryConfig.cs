using UnityEngine;

namespace Code.Meta.Features.Information.EnchantInformation.Configs
{
	[CreateAssetMenu(menuName = "Dungeon Gunner/Information/Enchant Stat UI Entry Config", fileName = "EnchantStatUIEntryConfig")]
	public class EnchantStatUIEntryConfig : ScriptableObject
	{
		public EnchantStatUIEntryTypeId TypeId;
		public GameObject ViewPrefab;
	}
}