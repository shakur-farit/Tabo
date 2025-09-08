using Code.Gameplay.Features.Weapon.Configs;
using Code.Gameplay.StaticData;
using Code.Meta.Features.Shop.Upgrade.Services;
using Code.Meta.Features.Shop.Weapon.Behaviours;
using Code.Meta.UI.Windows.Service;
using Code.Progress.Provider;
using Code.Meta.Features.Shop.WeaponStatUIEntry.Behaviours;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.Meta.UI.Windows.Behaviours
{
	public class WeaponBuyDialogWindow : BaseWindow
	{
		[SerializeField] private Button _closeButton;
		[SerializeField] private Button _buyButton;
		[SerializeField] private WeaponToBuyItem weaponToBuyItem;
		[SerializeField] private WeaponStatsUIHolder _statsUIHolder;

		private IWindowService _windowService;
		private IProgressProvider _progressProvider;
		private IWeaponUpgradesCleaner _upgradeCleaner;
		private IStaticDataService _staticDataService;

		[Inject]
		public void Constructor(
			IWindowService windowService,
			IProgressProvider progressProvider,
			IWeaponUpgradesCleaner upgraderCleaner,
			IStaticDataService staticDataService)
		{
			Id = WindowId.WeaponBuyDialogWindow;

			_windowService = windowService;
			_progressProvider = progressProvider;
			_upgradeCleaner = upgraderCleaner;
			_staticDataService = staticDataService;
		}

		protected override void Initialize()
		{
			_buyButton.onClick.AddListener(BuyWeapon);
			_closeButton.onClick.AddListener(CloseWindow);

			weaponToBuyItem.Setup(_progressProvider.ShopData.WeaponToBuyConfig);

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
			_upgradeCleaner.CleanUpgrades();

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
				_statsUIHolder.CreateStatUIEntryItem(uiEntry.StatUIEntryType, weaponConfig);
		}

		private void OpenNotEnoughCoinsWindow() =>
			_windowService.Open(WindowId.NotEnoughCoinsWindow);
	}
}