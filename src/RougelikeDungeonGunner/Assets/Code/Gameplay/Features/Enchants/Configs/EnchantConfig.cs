using UnityEngine;

namespace Code.Gameplay.Features.Enchants.Configs
{
	[CreateAssetMenu(menuName = "Dungeon Gunner/Enchant Config", fileName = "EnchantConfig")]
	public class EnchantConfig : ScriptableObject
	{
		public EnchantTypeId TypeId;
		public float Duration;
	}
}