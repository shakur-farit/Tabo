using System;
using Code.Gameplay.Features.Weapon.Configs;
using Code.Gameplay.StaticData;
using Code.Meta.Features.Shop.Upgrade.Services;
using Code.Meta.Features.Shop.Weapon.Behaviours;
using Code.Meta.Features.Shop.Weapon.Configs;
using Code.Meta.UI.Windows.Service;
using Code.Progress.Provider;
using System.Linq;
using Code.Gameplay.Features.Effects;
using Code.Meta.Features.Shop.WeaponStatUIEntry;
using Code.Meta.Features.Shop.WeaponStatUIEntry.Factory;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.Meta.UI.Windows.Behaviours
{
	public class WeaponBuyDialogWindow : BaseWindow
	{
		[SerializeField] private Button _closeButton;
		[SerializeField] private Button _buyButton;
		[SerializeField] private WeaponToBuyShopItem _weaponToBuyShopItem;
		[SerializeField] private Transform _weaponStatsHolder;

		private IWindowService _windowService;
		private IProgressProvider _progressProvider;
		private IWeaponUpgradesCleaner _upgraderCleaner;
		private IStaticDataService _staticDataService;
		private IWeaponStatUIEntryItemFactory _statUIEntryFactory;

		[Inject]
		public void Constructor(
			IWindowService windowService,
			IProgressProvider progressProvider,
			IWeaponUpgradesCleaner upgraderCleaner,
			IStaticDataService staticDataService,
			IWeaponStatUIEntryItemFactory statUIEntryFactory)
		{
			Id = WindowId.WeaponBuyDialogWindow;

			_windowService = windowService;
			_progressProvider = progressProvider;
			_upgraderCleaner = upgraderCleaner;
			_staticDataService = staticDataService;
			_statUIEntryFactory = statUIEntryFactory;
		}

		protected override void Initialize()
		{
			_buyButton.onClick.AddListener(BuyWeapon);
			_closeButton.onClick.AddListener(CloseWindow);

			_weaponToBuyShopItem.Setup(_progressProvider.ShopData.WeaponToBuyConfig);

			UpdateStatsEntry();
		}

		private void BuyWeapon()
		{
			if (IsNotEnoughCoins())
			{
				OpenNotEnoughCoinsWindow();
				return;
			}

			SubtractPrice();
			CleanUpgrades();
			ChangeCurrentWeapon();
			CloseWindow();
		}

		private void SubtractPrice() =>
			_progressProvider.HeroData.CurrentCoinsCount -= _progressProvider.ShopData.WeaponToBuyConfig.Price;

		private void ChangeCurrentWeapon()
		{
			_progressProvider.HeroData.CurrentWeaponTypeId =
				_progressProvider.ShopData.WeaponToBuyConfig.WeaponTypeId;
			_progressProvider.ShopData.WeaponToBuyConfig = null;
		}

		private void CleanUpgrades() =>
			_upgraderCleaner.CleanUpgrades();

		private bool IsNotEnoughCoins() =>
			_progressProvider.HeroData.CurrentCoinsCount < _progressProvider.ShopData.WeaponToBuyConfig.Price;

		private void CloseWindow() =>
			_windowService.Close(WindowId.WeaponBuyDialogWindow);

		private void UpdateStatsEntry()
		{
			WeaponConfig weaponConfig =
				_staticDataService
					.GetWeaponConfig(_progressProvider.ShopData.WeaponToBuyConfig.WeaponTypeId);

			foreach (WeaponStatUIEntry uiEntry in weaponConfig.StatsUIEntry)
				CreateStatUIEntryItem(uiEntry.StatUIEntryType, _weaponStatsHolder, weaponConfig);
		}

		private void OpenNotEnoughCoinsWindow() =>
			_windowService.Open(WindowId.NotEnoughCoinsWindow);

		private void CreateStatUIEntryItem(WeaponStatUIEntryTypeId id, Transform parent,
			WeaponConfig weaponConfig)
		{
			switch (id)
			{
				case WeaponStatUIEntryTypeId.Pierce:
					CreatePierceUiEntry(id, parent, weaponConfig);
					break;
				case WeaponStatUIEntryTypeId.Damage:
					CreateDamageUiEntry(id, parent, weaponConfig);
					break;
				case WeaponStatUIEntryTypeId.Accuracy:
					CreateAccuracyUiEntry(id, parent, weaponConfig);
					break;
				case WeaponStatUIEntryTypeId.EnchantSlots:
					CreateEnchantSlotsUiEntry(id, parent, weaponConfig);
					break;
				case WeaponStatUIEntryTypeId.Cooldown:
					CreateCooldownUiEntry(id, parent, weaponConfig);
					break;
				case WeaponStatUIEntryTypeId.FireRange:
					CreateFireRangeUiEntry(id, parent, weaponConfig);
					break;
				case WeaponStatUIEntryTypeId.InfinityAmmo:
					CreateInfinityAmmoUiEntry(id, parent);
					break;
				case WeaponStatUIEntryTypeId.PrechargingTime:
					CreatePrechargingTimeUiEntry(id, parent, weaponConfig);
					break;
				case WeaponStatUIEntryTypeId.ReloadTime:
					CreateReloadTimeUiEntry(id, parent, weaponConfig);
					break;
				case WeaponStatUIEntryTypeId.PelletCount:
					CreatePelletCountUiEntry(id, parent, weaponConfig);
					break;
				case WeaponStatUIEntryTypeId.MagazineSize:
					CreateMagazineSizeUiEntry(id, parent, weaponConfig);
					break;
				default:
					throw new Exception($"UI entry with type id {id} does not exist");
			}
		}

		private void CreateAccuracyUiEntry(WeaponStatUIEntryTypeId id, Transform parent,
			WeaponConfig weaponConfig) =>
			_statUIEntryFactory
				.CreateStatUIEntryItem(id, parent, weaponConfig.Stats.Accuracy + "%");

		private void CreateEnchantSlotsUiEntry(WeaponStatUIEntryTypeId id, Transform parent,
			WeaponConfig weaponConfig) =>
			_statUIEntryFactory
				.CreateStatUIEntryItem(id, parent, weaponConfig.Stats.EnchantSlots.ToString());

		private void CreateCooldownUiEntry(WeaponStatUIEntryTypeId id, Transform parent,
			WeaponConfig weaponConfig) =>
			_statUIEntryFactory
				.CreateStatUIEntryItem(id, parent, weaponConfig.Stats.Cooldown.ToString());

		private void CreateFireRangeUiEntry(WeaponStatUIEntryTypeId id, Transform parent,
			WeaponConfig weaponConfig) =>
			_statUIEntryFactory
				.CreateStatUIEntryItem(id, parent, weaponConfig.Stats.FireRange.ToString());

		private void CreateInfinityAmmoUiEntry(WeaponStatUIEntryTypeId id, Transform parent) =>
			_statUIEntryFactory
				.CreateStatUIEntryItem(id, parent, string.Empty);

		private void CreatePrechargingTimeUiEntry(WeaponStatUIEntryTypeId id, Transform parent,
			WeaponConfig weaponConfig) =>
			_statUIEntryFactory
				.CreateStatUIEntryItem(id, parent, weaponConfig.Stats.PrechargingTime.ToString());

		private void CreateReloadTimeUiEntry(WeaponStatUIEntryTypeId id, Transform parent,
			WeaponConfig weaponConfig) =>
			_statUIEntryFactory
				.CreateStatUIEntryItem(id, parent, weaponConfig.Stats.ReloadTime.ToString());

		private void CreatePelletCountUiEntry(WeaponStatUIEntryTypeId id, Transform parent,
			WeaponConfig weaponConfig) =>
			_statUIEntryFactory
				.CreateStatUIEntryItem(id, parent, weaponConfig.Stats.PelletCount.ToString());

		private void CreateMagazineSizeUiEntry(WeaponStatUIEntryTypeId id, Transform parent,
			WeaponConfig weaponConfig) =>
			_statUIEntryFactory
				.CreateStatUIEntryItem(id, parent, weaponConfig.Stats.MagazineSize.ToString());

		private void CreatePierceUiEntry(WeaponStatUIEntryTypeId id, Transform parent,
			WeaponConfig weaponConfig) =>
			_statUIEntryFactory
				.CreateStatUIEntryItem(id, parent, weaponConfig.Stats.Pierce.ToString());

		private void CreateDamageUiEntry(WeaponStatUIEntryTypeId id, Transform parent,
			WeaponConfig weaponConfig)
		{
			float damage = weaponConfig
				.EffectSetups
				.FirstOrDefault(e => e.EffectTypeId == EffectTypeId.Damage)?.Value ?? 0f;
			
			_statUIEntryFactory
				.CreateStatUIEntryItem(id, parent, damage.ToString());
		}
	}
}