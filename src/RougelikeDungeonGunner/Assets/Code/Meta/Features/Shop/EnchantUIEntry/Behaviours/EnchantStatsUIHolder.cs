using Code.Meta.Features.Shop.EnchantUIEntry.Factory;
using Code.Progress.Provider;
using UnityEngine;
using Zenject;

namespace Code.Meta.Features.Shop.EnchantUIEntry.Behaviours
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

		public void CreateStats(EnchantStatUIEntryTypeId id)
		{
			switch (id)
			{
				case EnchantStatUIEntryTypeId.Value:
					_factory.CreateWeaponEnchantUIEntryItem(
						id,
						_parent,
						_progressProvider.WeaponData.SelectedEnchantUIStats.Value.ToString());
					break;
				case EnchantStatUIEntryTypeId.Duration:
					_factory.CreateWeaponEnchantUIEntryItem(
						id,
						_parent,
						_progressProvider.WeaponData.SelectedEnchantUIStats.StatusDuration.ToString());
					break;
				case EnchantStatUIEntryTypeId.Period:
					_factory.CreateWeaponEnchantUIEntryItem(
						id,
						_parent,
						_progressProvider.WeaponData.SelectedEnchantUIStats.Period.ToString());
					break;
				case EnchantStatUIEntryTypeId.Radius:
					_factory.CreateWeaponEnchantUIEntryItem(
						id,
						_parent,
						_progressProvider.WeaponData.SelectedEnchantUIStats.Radius.ToString());
					break;
			}
		}
	}
}