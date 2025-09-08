using Code.Meta.Features.Shop.Upgrade.Configs;
using Code.Meta.UI.Windows;
using Code.Meta.UI.Windows.Service;
using Code.Progress.Provider;

namespace Code.Meta.Features.Shop.Upgrade.Services
{
	public class WeaponUpgrader : IWeaponUpgrader
	{
		private readonly IProgressProvider _progressProvider;
		private readonly IWeaponUpgradeValidator _validator;
		private readonly IWeaponUpgradesProvider _provider;
		private readonly IWindowService _windowService;

		public WeaponUpgrader(
			IProgressProvider progressProvider,
			IWeaponUpgradeValidator validator,
			IWeaponUpgradesProvider provider,
			IWindowService windowService)
		{
			_progressProvider = progressProvider;
			_validator = validator;
			_provider = provider;
			_windowService = windowService;
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
			_progressProvider.HeroData.CurrentCoinsCount >= price;

		private void SubtractPrice(int price) =>
			_progressProvider.HeroData.CurrentCoinsCount -= price;
	}
}