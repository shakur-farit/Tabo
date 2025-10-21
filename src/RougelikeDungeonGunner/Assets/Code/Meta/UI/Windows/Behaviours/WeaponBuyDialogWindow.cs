using Code.Gameplay.Features.Hero.Services;
using Code.Gameplay.Features.Weapon.Configs;
using Code.Gameplay.Features.Weapon.Services;
using Code.Gameplay.StaticData;
using Code.Meta.Features.Shop.Services;
using Code.Meta.Features.Shop.Upgrade.Services;
using Code.Meta.Features.Shop.Weapon.Behaviours;
using Code.Meta.Features.Shop.WeaponStatUIEntry.Behaviours;
using Code.Meta.UI.Windows.Service;
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
		private IWeaponUpgradesCleaner _upgradeCleaner;
		private IStaticDataService _staticDataService;
    private ICoinService _coinService;
    private IWeaponShopService _shopService;
    private ICurrentHeroWeaponProvider _heroWeapon;
    private ICurrentAmmoCountProvider _ammoCountProvider;

    [Inject]
		public void Constructor(
			IWindowService windowService,
			IWeaponUpgradesCleaner upgraderCleaner,
			IStaticDataService staticDataService,
			ICurrentHeroWeaponProvider heroWeapon,
      ICoinService coinService,
			ICurrentAmmoCountProvider ammoCountProvider,
			IWeaponShopService shopService)
		{
			Id = WindowId.WeaponBuyDialogWindow;

			_windowService = windowService;
			_upgradeCleaner = upgraderCleaner;
			_staticDataService = staticDataService;
      _coinService = coinService;
      _shopService = shopService;
      _ammoCountProvider = ammoCountProvider;
      _heroWeapon = heroWeapon;
		}

		protected override void Initialize()
		{
			_buyButton.onClick.AddListener(BuyWeapon);
			_closeButton.onClick.AddListener(CloseWindow);

			weaponToBuyItem.Setup(_shopService.WeaponSprite, _shopService.WeaponPrice);

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
			CleanAmmoCount();
			ChangeCurrentWeapon();
			CloseWindow();
		}

		private void SubtractPrice()
    {
      int coinCount = _coinService.GetCurrentCoinCount();

      coinCount -= _shopService.WeaponPrice;

			_coinService.SetCurrentCoinCount(coinCount);
    }

    private void ChangeCurrentWeapon()
		{
			_heroWeapon.SetCurrentHeroWeapon(_shopService.WeaponTypeId);

			_shopService.ResetWeaponSetup();
		}

		private void CleanUpgrades() =>
			_upgradeCleaner.CleanUpgrades();

    private void CleanAmmoCount() =>
      _ammoCountProvider.Clean();

    private bool IsNotEnoughCoins() =>
      _coinService.GetCurrentCoinCount() < _shopService.WeaponPrice;

		private void CloseWindow() =>
			_windowService.Close(WindowId.WeaponBuyDialogWindow);

		private void UpdateStatsEntry()
		{
			WeaponConfig weaponConfig =
				_staticDataService
					.GetWeaponConfig(_shopService.WeaponTypeId);

			foreach (WeaponStatUIEntry uiEntry in weaponConfig.StatsUIEntry)
				_statsUIHolder.CreateStatUIEntryItem(uiEntry.StatUIEntryType, weaponConfig);
		}

		private void OpenNotEnoughCoinsWindow() =>
			_windowService.Open(WindowId.NotEnoughCoinsWindow);
	}
}