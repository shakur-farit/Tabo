namespace Code.Meta.Features.Shop.HeroUpgrade.Services
{
  public interface IHeroUpgradeBuyer
  {
    bool TryBuyUpgrade();
    bool IsNotEnoughCoins();
  }
}