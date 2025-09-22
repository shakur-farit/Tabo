using Assets.Code.Meta.Features.Shop.Weapon.Behaviours;
using UnityEngine;

namespace Assets.Code.Meta.Features.Shop.Weapon.Factory
{
	public interface IWeaponShopItemFactory
	{
		WeaponShopItem CreateWeaponShopItem(WeaponShopItemTypeId config, Transform parent);
	}
}