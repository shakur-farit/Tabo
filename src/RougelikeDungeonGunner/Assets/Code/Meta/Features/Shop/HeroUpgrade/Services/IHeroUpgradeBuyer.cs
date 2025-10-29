namespace Code.Meta.UI.Windows.Behaviours
{
  public interface IHeroUpgradeBuyer
  {
    bool TryBuyUpgrade();
    bool IsNotEnoughCoins();
  }
}