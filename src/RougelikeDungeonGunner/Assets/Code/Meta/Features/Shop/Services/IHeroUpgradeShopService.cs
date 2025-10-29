using Code.Meta.Features.Shop.Upgrade;
using UnityEngine;

namespace Code.Meta.Features.Shop.Services
{
  public interface IHeroUpgradeShopService
  {
    HeroUpgradeTypeId HeroUpgradeTypeId { get; }
    Sprite HeroUpgradeSprite { get; }
    int HeroUpgradePrice { get; }
    float HeroUpgradeValue { get; }
    void SetHeroUpgradeSprite(Sprite sprite);
    void SetHeroUpgradePrice(int price);
    void SetHeroUpgradeTypeId(HeroUpgradeTypeId heroUpgradeType);
    void ResetHeroUpgradeSetup();
    void SetHeroUpgradeValue(float value);
  }
}