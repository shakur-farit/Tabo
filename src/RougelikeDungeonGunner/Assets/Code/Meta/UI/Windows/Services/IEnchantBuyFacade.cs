using Code.Meta.Features.Shop.EnchantUIEntry.Behaviours;

namespace Code.Meta.UI.Windows.Behaviours
{
  public interface IEnchantBuyFacade
  {
    void BuyEnchant();
    void RenderStats(EnchantStatsUIHolder holder);
    void CloseWindow();
  }
}