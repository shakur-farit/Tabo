using Code.Gameplay.Features.Statuses;
using UnityEngine;

namespace Code.Meta.Features.Shop.WeaponEnchantUIEntry.Factory
{
	public interface IWeaponEnchantUIEntryFactory
	{
		void CreateWeaponEnchantUIEntryItem(WeaponEnchantUIEntryTypeId id, Transform parent, StatusSetup setup);
	}
}