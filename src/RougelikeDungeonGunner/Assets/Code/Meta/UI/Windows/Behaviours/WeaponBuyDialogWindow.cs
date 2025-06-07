using Code.Meta.Features.Shop.Upgrade.Services;
using Code.Meta.Features.Shop.Weapon.Behaviours;
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

		private IWindowService _windowService;
		private IProgressProvider _progressProvider;
		private IWeaponUpgradeService _upgradeService;

		[Inject]
		public void Constructor(IWindowService windowService, IProgressProvider progressProvider, IWeaponUpgradeService upgradeService)
		{
			Id = WindowId.WeaponBuyDialogWindow;

			_windowService = windowService;
			_progressProvider = progressProvider;
			_upgradeService = upgradeService;
		}

		protected override void Initialize()
		{
			_buyButton.onClick.AddListener(BuyWeapon);
			_closeButton.onClick.AddListener(CloseWindow);

			_weaponToBuyShopItem.Setup(_progressProvider.ShopData.WeaponToBuyConfig);
		}

		private void BuyWeapon()
		{
			if(IsNotEnoughCoins())
				return;

			SubtractPrice();
			RemoveUpgrades();
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

		private void RemoveUpgrades() => 
			_upgradeService.RemoveUpgrades();

		private bool IsNotEnoughCoins() => 
			_progressProvider.HeroData.CurrentCoinsCount < _progressProvider.ShopData.WeaponToBuyConfig.Price;

		private void CloseWindow() =>
			_windowService.Close(WindowId.WeaponBuyDialogWindow);
	}
}