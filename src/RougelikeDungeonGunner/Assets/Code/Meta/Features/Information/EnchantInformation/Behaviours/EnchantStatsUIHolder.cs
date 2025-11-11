using Code.Meta.Features.Information.EnchantInformation.Factory;
using Code.Meta.Features.Shop.EnchantUIEntry.Services;
using UnityEngine;
using Zenject;

namespace Code.Meta.Features.Information.EnchantInformation.Behaviours
{
	public class EnchantStatsUIHolder : MonoBehaviour
	{
		[SerializeField] private Transform _parent;

		private IEnchantStatUIEntryFactory _factory;
    private ISelectedEnchantUIEntryProvider _enchantUIEntry;

    [Inject]
		public void Constructor(ISelectedEnchantUIEntryProvider enchantUIEntry, IEnchantStatUIEntryFactory factory)
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