using Code.Gameplay.Features.Coin.Services;
using Code.Meta.Features.Shop.WeaponUpgrade.Configs;
using Code.Meta.UI.Windows.Services;

namespace Code.Meta.Features.Shop.WeaponUpgrade.Services
{
	public class WeaponUpgrader : IWeaponUpgrader
	{
		private readonly IWeaponUpgradeValidator _validator;
		private readonly IWeaponUpgradesProvider _provider;
    private readonly IDialogueService _dialogueService;
    private readonly ICoinService _coinService;

    public WeaponUpgrader(
			IWeaponUpgradeValidator validator,
			IWeaponUpgradesProvider provider,
			IDialogueService dialogueService,
      ICoinService coinService)
		{
			_validator = validator;
			_provider = provider;
      _dialogueService = dialogueService;
      _coinService = coinService;
    }

		public void Upgrade(WeaponUpgradeShopItemConfig config)
		{
			if (EnoughCoins(config.Price) == false)
			{
				_dialogueService.OpenNotEnoughCoinsDialogue();
        return;
			}

			if (_validator.CanUpgrade(config) == false)
			{
        _dialogueService.OpenMaxValueDialogue();
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