using Code.Gameplay.Features.Statuses;
using UnityEngine;

namespace Code.Meta.Features.Shop.WeaponEnchantUIEntry.Factory
{
	public interface IEnchantUIEntryFactory
	{
		void CreateWeaponEnchantUIEntryItem(EnchantUIEntryTypeId id, Transform parent, StatusSetup setup);
	}
}