using Code.Meta.Features.Shop.Weapon.Configs;
using UnityEngine;

namespace Code.Meta.Features.Shop.Weapon.Behaviours
{
	public interface IWeaponShopItemFactory
	{
		WeaponShopItem CreateWeaponShopItem(WeaponShopItemConfig config, Transform parent);
	}
}