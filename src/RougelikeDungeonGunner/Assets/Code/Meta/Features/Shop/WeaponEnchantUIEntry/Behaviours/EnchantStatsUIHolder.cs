using Code.Meta.Features.Shop.WeaponEnchantUIEntry.Factory;
using Code.Progress.Provider;
using UnityEngine;
using Zenject;

namespace Code.Meta.Features.Shop.WeaponEnchantUIEntry.Behaviours
{
	public class EnchantStatsUIHolder : MonoBehaviour
	{
		[SerializeField] private Transform _parent;

		private IProgressProvider _progressProvider;
		private IWeaponEnchantStatUIEntryFactory _factory;

		[Inject]
		public void Constructor(IProgressProvider progressProvider, IWeaponEnchantStatUIEntryFactory factory)
		{
			_progressProvider = progressProvider;
			_factory = factory;
		}

		public void CreateStats(WeaponEnchantStatUIEntryTypeId id)
		{
			switch (id)
			{
				case WeaponEnchantStatUIEntryTypeId.Value:
					_factory.CreateWeaponEnchantUIEntryItem(
						id,
						_parent,
						_progressProvider.WeaponData.SelectedEnchantUIStats.Value.ToString());
					break;
				case WeaponEnchantStatUIEntryTypeId.Duration:
					_factory.CreateWeaponEnchantUIEntryItem(
						id,
						_parent,
						_progressProvider.WeaponData.SelectedEnchantUIStats.StatusDuration.ToString());
					break;
				case WeaponEnchantStatUIEntryTypeId.Period:
					_factory.CreateWeaponEnchantUIEntryItem(
						id,
						_parent,
						_progressProvider.WeaponData.SelectedEnchantUIStats.Period.ToString());
					break;
				case WeaponEnchantStatUIEntryTypeId.Radius:
					_factory.CreateWeaponEnchantUIEntryItem(
						id,
						_parent,
						_progressProvider.WeaponData.SelectedEnchantUIStats.Radius.ToString());
					break;
			}
		}
	}
}