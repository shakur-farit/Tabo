using Assets.Code.Meta.Features.Shop.WeaponStatUIEntry.Behaviours;
using UnityEngine;

namespace Assets.Code.Meta.Features.Shop.WeaponStatUIEntry.Factory
{
	public interface IWeaponStatUIEntryItemFactory
	{
		WeaponStatUIEntryItem CreateStatUIEntryItem(WeaponStatUIEntryTypeId id, Transform parent,
			string valueText);
	}
}