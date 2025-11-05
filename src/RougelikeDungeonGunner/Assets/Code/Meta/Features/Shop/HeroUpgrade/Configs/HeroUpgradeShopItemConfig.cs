using UnityEngine;

namespace Code.Meta.Features.Shop.HeroUpgrade.Configs
{
	[CreateAssetMenu(menuName = "Dungeon Gunner/Shop/Hero Upgrade Item Config", fileName = "HeroUpgradeItemConfig")]
	public class HeroUpgradeShopItemConfig : ScriptableObject
	{
		public HeroUpgradeTypeId TypeId;
		public GameObject ViewPrefab;
		public Sprite Sprite;
		[Range(0, 1000)] public int Price;
		[Range(0, 1000)] public float UpgradeValue;
	}
}