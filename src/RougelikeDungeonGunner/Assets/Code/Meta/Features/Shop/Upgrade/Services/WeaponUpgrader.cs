using Code.Meta.Features.Shop.Upgrade.Configs;
using Code.Progress.Provider;

namespace Code.Meta.Features.Shop.Upgrade.Services
{
	public class WeaponUpgrader : IWeaponUpgrader
	{
		private readonly IProgressProvider _progressProvider;
		private readonly IWeaponUpgradeValidator _validator;
		private readonly IWeaponUpgradesProvider _provider;

		public WeaponUpgrader(
			IProgressProvider progressProvider,
			IWeaponUpgradeValidator validator,
			IWeaponUpgradesProvider provider)
		{
			_progressProvider = progressProvider;
			_validator = validator;
			_provider = provider;
		}

		public void Upgrade(WeaponUpgradeShopItemConfig config)
		{
			if(EnoughCoins(config.Price) == false)
				return;

			if (_validator.CanUpgrade(config) == false)
				return;

			_provider.AddUpgrade(config.TypeId, config.UpgradeValue);

			SubtractPrice(config.Price);
		}

		private bool EnoughCoins(int price) => 
			_progressProvider.HeroData.CurrentCoinsCount >= price;

		private void SubtractPrice(int price) =>
			_progressProvider.HeroData.CurrentCoinsCount -= price;
	}
}