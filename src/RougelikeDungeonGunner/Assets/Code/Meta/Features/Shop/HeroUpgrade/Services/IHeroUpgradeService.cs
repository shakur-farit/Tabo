namespace Code.Meta.Features.Shop.HeroUpgrade.Services
{
  public interface IHeroUpgradeService
  {
    bool TryUpgrade(HeroUpgradeTypeId typeId, float value);
  }
}