using System;
using Code.Gameplay.Features.Statuses;
using Code.Meta.Features.Shop.WeaponEnchantUIEntry.Factory;
using UnityEngine;
using Zenject;

namespace Code.Meta.Features.Shop.WeaponEnchantUIEntry.Behaviours
{
	public class EnchantsUIHolder : MonoBehaviour
	{
		[SerializeField] private Transform _holder;

		private IEnchantUIEntryFactory _factory;

		[Inject]
		public void Constructor(IEnchantUIEntryFactory factory) => 
			_factory = factory;

		public void CreateEnchantUIEntryItem(StatusSetup setup)
		{
			switch (setup.StatusTypeId)
			{
				case StatusTypeId.Poison:
					_factory.CreateWeaponEnchantUIEntryItem(EnchantUIEntryTypeId.Poison, _holder, setup);
					break;
				case StatusTypeId.Freeze:
					_factory.CreateWeaponEnchantUIEntryItem(EnchantUIEntryTypeId.Freeze, _holder, setup);
					break;
				case StatusTypeId.Flame:
					_factory.CreateWeaponEnchantUIEntryItem(EnchantUIEntryTypeId.Flame, _holder, setup);
					break;
				default:
					throw new Exception($"Enchant UI entry with type id {setup.StatusTypeId} does not exist");
			}
		}
	}
}