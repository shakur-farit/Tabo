using Code.Gameplay.Features.Statuses;
using UnityEngine;

namespace Code.Meta.Features.Shop.EnchantUIEntry.Factory
{
	public interface IEnchantUIEntryFactory
	{
		void CreateWeaponEnchantUIEntryItem(EnchantUIEntryTypeId id, Transform parent, StatusSetup setup);
	}
}