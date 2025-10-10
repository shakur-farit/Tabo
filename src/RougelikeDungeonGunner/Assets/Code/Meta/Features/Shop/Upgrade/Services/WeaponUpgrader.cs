using Code.Gameplay.Features.Hero;
using Code.Gameplay.Features.Hero.Services;
using Code.Meta.Features.Shop.Upgrade.Configs;
using Code.Meta.UI.Windows;
using Code.Meta.UI.Windows.Service;

namespace Code.Meta.Features.Shop.Upgrade.Services
{
	public class WeaponUpgrader : IWeaponUpgrader
	{
		private readonly IWeaponUpgradeValidator _validator;
		private readonly IWeaponUpgradesProvider _provider;
		private readonly IWindowService _windowService;
    private readonly ICoinService _coinService;

    public WeaponUpgrader(
			IWeaponUpgradeValidator validator,
			IWeaponUpgradesProvider provider,
			IWindowService windowService,
      ICoinService coinService)
		{
			_validator = validator;
			_provider = provider;
			_windowService = windowService;
      _coinService = coinService;
    }

		public void Upgrade(WeaponUpgradeShopItemConfig config)
		{
			if (EnoughCoins(config.Price) == false)
			{
				_windowService.Open(WindowId.NotEnoughCoinsWindow);
				return;
			}

			if (_validator.CanUpgrade(config) == false)
			{
				_windowService.Open(WindowId.MaxValueReachedWindow);
				return;
			}

			_provider.AddUpgrade(config.TypeId, config.UpgradeValue);

			SubtractPrice(config.Price);
		}

		private bool EnoughCoins(int price) => 
			_coinService.GetCurrentCoinCount() >= price;

		private void SubtractPrice(int price)
    {
      int coinCount = _coinService.GetCurrentCoinCount();

      coinCount -= price;

			_coinService.SetCurrentCoinCount(coinCount);
    }
  }
}