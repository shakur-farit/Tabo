using System;
using Code.Gameplay.Features.Hero.Services;
using Code.Meta.Features.Shop.Upgrade;

namespace Code.Meta.UI.Windows.Behaviours
{
  public class HeroUpgradeService : IHeroUpgradeService
  {
    private readonly IHeroHpProvider _heroHp;
    private readonly ICurrentHeroTypeIdProvider _hero;
    private readonly IShieldRequestProvider _shieldRequest;

    public HeroUpgradeService(
	    IHeroHpProvider heroHp, 
	    ICurrentHeroTypeIdProvider hero,
	    IShieldRequestProvider shieldRequest)
    {
      _heroHp = heroHp;
      _hero = hero;
      _shieldRequest = shieldRequest;
    }

    public bool TryUpgrade(HeroUpgradeTypeId typeId, float value)
    {
      switch (typeId)
      {
        case HeroUpgradeTypeId.CurrentHp:
          return IncreaseCurrentHp(value);
        case HeroUpgradeTypeId.MaxHp:
          return IncreaseMaxHp(value);
        case HeroUpgradeTypeId.Shield:
	        return RequestShield();
      }

      throw new Exception($"Have no upgrades for {typeId} type");
    }

    private bool IncreaseCurrentHp(float value)
    {
      float currentCount = _heroHp.GetCurrentHp(_hero.CurrentHeroTypeId);
      float newCount = currentCount + value;

      if (newCount > _heroHp.GetMaxHp(_hero.CurrentHeroTypeId))
        return false;

      _heroHp.SetCurrentHp(newCount);
      return true;
    }

    private bool IncreaseMaxHp(float value)
    {
      float currentCount = _heroHp.GetMaxHp(_hero.CurrentHeroTypeId);
      float newCount = currentCount + value;
      _heroHp.SetMaxHp(newCount);
      return true;
    }

    private bool RequestShield()
    {
      if(_shieldRequest.IsRequiested)
        return false;

	    return _shieldRequest.IsRequiested = true;
    }
  }
}