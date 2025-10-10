using Code.Meta.Features.Shop.Enchant;
using UnityEngine;

namespace Code.Meta.Features.Shop.Services
{
	public interface IEnchantShopService
	{
		EnchantShopItemTypeId EnchantTypeId { get; }
		Sprite EnchantSprite { get; }
		int EnchantPrice { get; }
		void SetEnchantSprite(Sprite sprite);
		void SetEnchantPrice(int price);
		void SetEnchantTypeId(EnchantShopItemTypeId enchantToBuy);
		void ResetEnchantSetup();
	}
}