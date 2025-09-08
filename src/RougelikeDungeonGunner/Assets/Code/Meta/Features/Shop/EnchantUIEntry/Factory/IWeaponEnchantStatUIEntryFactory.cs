using UnityEngine;

namespace Code.Meta.Features.Shop.EnchantUIEntry.Factory
{
	public interface IWeaponEnchantStatUIEntryFactory
	{
		void CreateWeaponEnchantUIEntryItem(EnchantStatUIEntryTypeId id, Transform parent, string value);
	}
}