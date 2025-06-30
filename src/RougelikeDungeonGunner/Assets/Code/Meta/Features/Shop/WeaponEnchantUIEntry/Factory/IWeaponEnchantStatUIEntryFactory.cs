using UnityEngine;

namespace Code.Meta.Features.Shop.WeaponEnchantUIEntry.Factory
{
	public interface IWeaponEnchantStatUIEntryFactory
	{
		void CreateWeaponEnchantUIEntryItem(WeaponEnchantStatUIEntryTypeId id, Transform parent, string value);
	}
}