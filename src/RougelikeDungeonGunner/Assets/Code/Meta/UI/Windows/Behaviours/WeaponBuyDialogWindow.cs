using Code.Gameplay.Features.Weapon.Configs;
using Code.Gameplay.StaticData;
using Code.Meta.Features.Shop.Upgrade.Services;
using Code.Meta.Features.Shop.Weapon.Behaviours;
using Code.Meta.Features.Shop.Weapon.Configs;
using Code.Meta.UI.Windows.Service;
using Code.Progress.Provider;
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
			{
				_statUIEntryFactory
					.CreateStatUIEntryItem(uiEntry.StatUIEntryType, _weaponStatsHolder, weaponConfig);
			}
		}

		private void OpenNotEnoughCoinsWindow() => 
			_windowService.Open(WindowId.NotEnoughCoinsWindow);
	}
}