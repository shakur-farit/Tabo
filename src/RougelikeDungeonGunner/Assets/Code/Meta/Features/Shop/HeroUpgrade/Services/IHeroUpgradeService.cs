using Code.Meta.Features.Shop.Upgrade;

namespace Code.Meta.UI.Windows.Behaviours
{
  public interface IHeroUpgradeService
  {
    bool TryUpgrade(HeroUpgradeTypeId typeId, float value);
  }
}