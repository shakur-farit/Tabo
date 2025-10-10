using Code.Meta.Features.Shop.EnchantUIEntry.Factory;
using UnityEngine;
using Zenject;

namespace Code.Meta.Features.Shop.EnchantUIEntry.Behaviours
{
	public class EnchantStatsUIHolder : MonoBehaviour
	{
		[SerializeField] private Transform _parent;

		private IWeaponEnchantStatUIEntryFactory _factory;
    private ISelectedEnchantUIEntryProvider _enchantUIEntry;

    [Inject]
		public void Constructor(ISelectedEnchantUIEntryProvider enchantUIEntry, IWeaponEnchantStatUIEntryFactory factory)
    {
      _enchantUIEntry = enchantUIEntry;
			_factory = factory;
		}

		public void CreateStats(EnchantStatUIEntryTypeId id)
		{
			switch (id)
			{
				case EnchantStatUIEntryTypeId.Value:
					_factory.CreateWeaponEnchantUIEntryItem(
						id,
						_parent,
						_enchantUIEntry.StatusSetup.Value.ToString());
					break;
				case EnchantStatUIEntryTypeId.Duration:
					_factory.CreateWeaponEnchantUIEntryItem(
						id,
						_parent,
            _enchantUIEntry.StatusSetup.StatusDuration.ToString());
					break;
				case EnchantStatUIEntryTypeId.Period:
					_factory.CreateWeaponEnchantUIEntryItem(
						id,
						_parent,
						_enchantUIEntry.StatusSetup.Period.ToString());
					break;
				case EnchantStatUIEntryTypeId.Radius:
					_factory.CreateWeaponEnchantUIEntryItem(
						id,
						_parent,
						_enchantUIEntry.StatusSetup.Radius.ToString());
					break;
			}
		}
	}
}