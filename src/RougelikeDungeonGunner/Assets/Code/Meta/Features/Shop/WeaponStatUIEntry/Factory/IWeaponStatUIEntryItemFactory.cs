using Code.Gameplay.Features.Weapon.Configs;
using UnityEngine;

namespace Code.Meta.Features.Shop.Weapon.Configs
{
	public interface IWeaponStatUIEntryItemFactory
	{
		WeaponStatUIEntryItem CreateStatUIEntryItem(WeaponStatUIEntryTypeId id, Transform parent, WeaponConfig weaponConfig);
	}
}