using UnityEngine;

namespace Code.Gameplay.Features.Enchants.Configs
{
	[CreateAssetMenu(menuName = "Dungeon Gunner/Enchant Config", fileName = "EnchantConfig")]
	public class EnchantConfig : ScriptableObject
	{
		public EnchantTypeId TypeId;
		public GameObject ViewPrefab;
		public Sprite Sprite;
		[Range(0f, 100f)] public float Duration;
	}
}