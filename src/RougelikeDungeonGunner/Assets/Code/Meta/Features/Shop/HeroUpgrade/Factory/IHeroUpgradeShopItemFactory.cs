using Code.Meta.Features.Shop.Enchant.Behaviours;
using Code.Meta.Features.Shop.Upgrade;
using UnityEngine;

namespace Code.Meta.Features.Shop.Enchant.Factory
{
	public interface IHeroUpgradeShopItemFactory
	{
		HeroUpgradeShopItem CreateHeroUpgradeShopItem(HeroUpgradeTypeId id, Transform parent);
	}
}