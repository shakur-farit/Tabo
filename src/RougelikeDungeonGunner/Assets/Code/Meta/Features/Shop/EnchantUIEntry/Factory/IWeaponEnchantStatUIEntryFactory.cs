using UnityEngine;

namespace Code.Meta.Features.Shop.WeaponEnchantUIEntry.Factory
{
	public interface IWeaponEnchantStatUIEntryFactory
	{
		void CreateWeaponEnchantUIEntryItem(EnchantStatUIEntryTypeId id, Transform parent, string value);
	}
}