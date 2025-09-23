using Code.Meta.Features.Shop.Weapon.Behaviours;
using UnityEngine;

namespace Code.Meta.Features.Shop.Weapon.Factory
{
	public interface IWeaponShopItemFactory
	{
		WeaponShopItem CreateWeaponShopItem(WeaponShopItemTypeId config, Transform parent);
	}
}