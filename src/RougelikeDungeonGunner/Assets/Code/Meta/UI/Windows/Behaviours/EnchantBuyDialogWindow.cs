using Code.Gameplay.Features.Statuses;
using Code.Gameplay.Features.Weapon.Configs;
using Code.Gameplay.StaticData;
using Code.Meta.Features.Shop.Upgrade.Services;
using Code.Meta.Features.Shop.WeaponStatUIEntry.Configs;
using Code.Meta.UI.Windows.Service;
using Code.Progress.Provider;
using System.Linq;
using Code.Meta.Features.Shop.Enchant.Behaviours;
using Code.Meta.Features.Shop.Enchant.Configs;
using Code.Meta.Features.Shop.EnchantUIEntry.Behaviours;
using Code.Meta.Features.Shop.EnchantUIEntry.Configs;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.Meta.UI.Windows.Behaviours
{
	public class EnchantBuyDialogWindow : BaseWindow
	{
		[SerializeField] private Button _closeButton;
		[SerializeField] private Button _buyButton;
		[SerializeField] private EnchantToBuyItem _enchantToBuyItem;
		[SerializeField] private EnchantStatsUIHolder _holder;

		private IWindowService _windowService;
		private IProgressProvider _progressProvider;
		private IWeaponUpgradesCleaner _upgradeCleaner;
		private IStaticDataService _staticDataService;

		[Inject]
		public void Constructor(
			IWindowService windowService,
			IProgressProvider progressProvider,
			IWeaponUpgradesCleaner upgradeCleaner,
			IStaticDataService staticDataService)
		{
			Id = WindowId.EnchantBuyDialogWindow;

			_windowService = windowService;
			_progressProvider = progressProvider;
			_upgradeCleaner = upgradeCleaner;
			_staticDataService = staticDataService;
		}

		protected override void Initialize()
		{
			_buyButton.onClick.AddListener(BuyEnchant);
			_closeButton.onClick.AddListener(CloseWindow);

			_enchantToBuyItem.Setup(_progressProvider.ShopData.EnchantToBuyConfig);

			UpdateStatsEntry();
		}

		private void BuyEnchant()
		{
			if (IsNotEnoughCoins())
			{
				OpenNotEnoughCoinsWindow();
				return;
			}

			SubtractPrice();
			AddEnchant();
			CloseWindow();
		}

		private void SubtractPrice() =>
			_progressProvider.HeroData.CurrentCoinsCount -= _progressProvider.ShopData.EnchantToBuyConfig.Price;

		private void AddEnchant()
		{
			WeaponConfig weaponConfig = _staticDataService.GetWeaponConfig(_progressProvider.HeroData.CurrentWeaponTypeId);
			StatusSetup selectedEnchant = _progressProvider.WeaponData.SelectedEnchantUIStats;

			if (weaponConfig.StatusSetups.Any(e => e.StatusTypeId == selectedEnchant.StatusTypeId))
			{
				_windowService.Open(WindowId.EnchantAlreadyAppliedWindow);
				return;
			}

			weaponConfig.StatusSetups.Add(_progressProvider.WeaponData.SelectedEnchantUIStats);
		}

		private bool IsNotEnoughCoins() =>
			_progressProvider.HeroData.CurrentCoinsCount < _progressProvider.ShopData.EnchantToBuyConfig.Price;

		private void CloseWindow() =>
			_windowService.Close(WindowId.EnchantBuyDialogWindow);

		private void UpdateStatsEntry()
		{
			EnchantShopItemConfig config =
				_staticDataService.GetEnchantShopItemConfig(_progressProvider.ShopData.EnchantToBuyConfig.TypeId);

			_progressProvider.WeaponData.SelectedEnchantUIStats = config.Enchnat;

			foreach (EnchantStatUIEntry statUIEntry in config.EnchantStatUIEntries)
				_holder.CreateStats(statUIEntry.TypeId);
		}

		private void OpenNotEnoughCoinsWindow() =>
			_windowService.Open(WindowId.NotEnoughCoinsWindow);
	}
}