using UnityEngine;

namespace Code.Meta.Features.Shop.WeaponStatUIEntry.Configs
{
	public interface IEnchantShopItemFactory
	{
		EnchantShopItem CreateEnchantShopItem(EnchantShopItemTypeId id, Transform parent);
	}
}