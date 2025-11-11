using UnityEngine;

namespace Code.Meta.Features.Information.EnchantInformation.Factory
{
	public interface IEnchantStatUIEntryFactory
	{
		void CreateWeaponEnchantUIEntryItem(EnchantStatUIEntryTypeId id, Transform parent, string value);
	}
}