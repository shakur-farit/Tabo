using Code.Gameplay.Features.Weapon.Configs;
using Code.Gameplay.StaticData;
using Code.Meta.Features.Shop.Upgrade.Services;
using Code.Meta.Features.Shop.Weapon.Behaviours;
using Code.Meta.UI.Windows.Service;
using Code.Progress.Provider;
using TMPro;
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

		[SerializeField] private TextMeshProUGUI _fireRangeText;
		[SerializeField] private TextMeshProUGUI _cooldownText;
		[SerializeField] private TextMeshProUGUI _reloadTimeText;
		[SerializeField] private TextMeshProUGUI _prechargingTimeText;
		[SerializeField] private TextMeshProUGUI _magazineSizeText;
		[SerializeField] private TextMeshProUGUI _pierceText;
		[SerializeField] private TextMeshProUGUI _pelletCountText;
		[SerializeField] private TextMeshProUGUI _enchantSlotsText;
		[SerializeField] private TextMeshProUGUI _isInfinityAmmoText;

		private IWindowService _windowService;
		private IProgressProvider _progressProvider;
		private IWeaponUpgradesCleaner _upgraderCleaner;
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
			_upgraderCleaner = upgraderCleaner;
			_staticDataService = staticDataService;
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

		private void UpdateStatsText()
		{
			WeaponConfig config = _staticDataService.GetWeaponConfig(_progressProvider.HeroData.CurrentWeaponTypeId);
			WeaponStats stats = config.Stats;

			if (stats.isInfinityAmmo)
			{
				_reloadTimeText.gameObject.SetActive(false);
				_magazineSizeText.gameObject.SetActive(false);
			}

			if (stats.PrechargingTime <= 0) 
				_prechargingTimeText.gameObject.SetActive(false);

			if(stats.ReloadTime <= 0)
				_reloadTimeText.gameObject.SetActive(false);

			if(stats.isInfinityAmmo == false)
				_isInfinityAmmoText.gameObject.SetActive(false);

			_fireRangeText.text = $"Fire range - {stats.FireRange}";
			_cooldownText.text = $"Cooldown - {stats.Cooldown}";
			_reloadTimeText.text = $"Reload time - {stats.ReloadTime}";
			_prechargingTimeText.text = $"Precharging time - {stats.PrechargingTime}";
			_pierceText.text = $"Pierce - {stats.Pierce}";
			_pelletCountText.text = $"Pellet count - {stats.PelletCount}";
			_enchantSlotsText.text = $"Enchant slots count - {stats.EnchantSlots}";
			_isInfinityAmmoText.text = "Infinity Ammo";
		}
	}
}