using System.Linq;
using Code.Gameplay.Features.Hero;
using Code.Gameplay.Features.Hero.Services;
using Code.Gameplay.Features.Statuses;
using Code.Gameplay.Features.Weapon;
using Code.Gameplay.Features.Weapon.Services;
using Code.Gameplay.StaticData;
using Code.Meta.Features.Shop.Enchant.Behaviours;
using Code.Meta.Features.Shop.Enchant.Configs;
using Code.Meta.Features.Shop.EnchantUIEntry;
using Code.Meta.Features.Shop.EnchantUIEntry.Behaviours;
using Code.Meta.Features.Shop.EnchantUIEntry.Configs;
using Code.Meta.Features.Shop.EnchantUIEntry.Services;
using Code.Meta.Features.Shop.Services;
using Code.Meta.Features.Shop.WeaponStatUIEntry;
using Code.Meta.UI.Windows.Service;
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
		private IStaticDataService _staticDataService;
    private ICoinService _coinService;
    private IWeaponStatusSetupProvider _weaponStatusSetupProvider;
    private IEnchantShopService _shopService;
    private ICurrentHeroWeaponProvider _heroWeapon;
    private ISelectedEnchantUIEntryProvider _enchantUIEntry;

    [Inject]
		public void Constructor(
			IWindowService windowService,
      IStaticDataService staticDataService,
      ICoinService coinService,
      IWeaponStatusSetupProvider weaponStatusSetupProvider,
			ICurrentHeroWeaponProvider heroWeapon,
			ISelectedEnchantUIEntryProvider enchantUIEntry,
			IEnchantShopService shopService)
		{
			Id = WindowId.EnchantBuyDialogWindow;

			_windowService = windowService;
			_staticDataService = staticDataService;
      _coinService = coinService;
      _weaponStatusSetupProvider = weaponStatusSetupProvider;
      _shopService = shopService;
      _heroWeapon = heroWeapon;
      _enchantUIEntry = enchantUIEntry;
    }

		protected override void Initialize()
		{
			_buyButton.onClick.AddListener(BuyEnchant);
			_closeButton.onClick.AddListener(CloseWindow);

			_enchantToBuyItem.Setup(_shopService.EnchantSprite, _shopService.EnchantPrice);

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

		private void SubtractPrice()
    {
      int coinCount = _coinService.GetCurrentCoinCount();
      
      coinCount -= _shopService.EnchantPrice;

			_coinService.SetCurrentCoinCount(coinCount);
    }

    private void AddEnchant()
		{
      StatusSetup selectedEnchant = _enchantUIEntry.StatusSetup;
      WeaponTypeId currentWeapon = _heroWeapon.CurrentWeaponTypeId;

      if (_weaponStatusSetupProvider.GetStatusSetups(currentWeapon)
          .Any(e => e.StatusTypeId == selectedEnchant.StatusTypeId))
			{
				_windowService.Open(WindowId.EnchantAlreadyAppliedWindow);
				return;
			}

			_weaponStatusSetupProvider.AddBoughtStatusSetup(currentWeapon, selectedEnchant);
		}

		private bool IsNotEnoughCoins() =>
      _coinService.GetCurrentCoinCount() < _shopService.EnchantPrice;

		private void CloseWindow() =>
			_windowService.Close(WindowId.EnchantBuyDialogWindow);

		private void UpdateStatsEntry()
		{
			EnchantShopItemConfig config =
				_staticDataService.GetEnchantShopItemConfig(_shopService.EnchantTypeId);

			_enchantUIEntry.SetStatusSetup(config.Enchnat);

			foreach (EnchantStatUIEntry statUIEntry in config.EnchantStatUIEntries)
				_holder.CreateStats(statUIEntry.TypeId);
		}

		private void OpenNotEnoughCoinsWindow() =>
			_windowService.Open(WindowId.NotEnoughCoinsWindow);
	}
}