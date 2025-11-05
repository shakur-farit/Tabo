using Code.Meta.Features.Shop.HeroUpgrade.Behaviours;
using UnityEngine;

namespace Code.Meta.Features.Shop.HeroUpgrade.Factory
{
	public interface IHeroUpgradeShopItemFactory
	{
		HeroUpgradeShopItem CreateHeroUpgradeShopItem(HeroUpgradeTypeId id, Transform parent);
	}
}