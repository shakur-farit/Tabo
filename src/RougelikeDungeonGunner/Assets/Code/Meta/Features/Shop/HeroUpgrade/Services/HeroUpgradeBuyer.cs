using Code.Gameplay.Features.Coin.Services;
using Code.Meta.Features.Shop.Services;

namespace Code.Meta.Features.Shop.HeroUpgrade.Services
{
  public class HeroUpgradeBuyer : IHeroUpgradeBuyer
  {
    private readonly ICoinService _coinService;
    private readonly IHeroUpgradeShopService _shopService;
    private readonly IHeroUpgradeService _heroUpgrade;

    public HeroUpgradeBuyer(
      ICoinService coinService,
      IHeroUpgradeShopService shopService,
      IHeroUpgradeService heroUpgrade)
    {
      _coinService = coinService;
      _shopService = shopService;
      _heroUpgrade = heroUpgrade;
    }

    public bool TryBuyUpgrade()
    {
      if (TryUpgrade())
      {
        SubtractPrice();
        return true;
      }

      return false;
    }

    private void SubtractPrice()
    {
      int coinCount = _coinService.GetCurrentCoinCount();

      coinCount -= _shopService.HeroUpgradePrice;

      _coinService.SetCurrentCoinCount(coinCount);
    }

    public bool IsNotEnoughCoins() =>
      _coinService.GetCurrentCoinCount() < _shopService.HeroUpgradePrice;

    private bool TryUpgrade() => 
      _heroUpgrade.TryUpgrade(_shopService.HeroUpgradeTypeId, _shopService.HeroUpgradeValue);
  }
}