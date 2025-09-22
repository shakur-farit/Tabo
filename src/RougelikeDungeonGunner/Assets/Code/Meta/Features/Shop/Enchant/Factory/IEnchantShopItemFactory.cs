using Assets.Code.Meta.Features.Shop.Enchant.Behaviours;
using UnityEngine;

namespace Assets.Code.Meta.Features.Shop.Enchant.Factory
{
	public interface IEnchantShopItemFactory
	{
		EnchantShopItem CreateEnchantShopItem(EnchantShopItemTypeId id, Transform parent);
	}
}