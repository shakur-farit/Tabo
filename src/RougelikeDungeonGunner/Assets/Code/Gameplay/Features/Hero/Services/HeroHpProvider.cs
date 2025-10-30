using System;
using Code.Gameplay.StaticData;

namespace Code.Gameplay.Features.Hero.Services
{
  public class HeroHpProvider : IHeroHpProvider
  {
	  public event Action HpChanged;

    private float _currentHp;
    private float _maxHp;

    private readonly IStaticDataService _staticDataService;

    public HeroHpProvider(IStaticDataService staticDataService) =>
      _staticDataService = staticDataService;

    public float GetCurrentHp(HeroTypeId typeId)
    {
      if (_currentHp == 0)
        return _currentHp = _staticDataService.GetHeroConfig(typeId).CurrentHp;

      return _currentHp;
    }

    public float GetMaxHp(HeroTypeId typeId)
    {
      if (_maxHp == 0)
        return _maxHp = _staticDataService.GetHeroConfig(typeId).MaxHp;

      return _maxHp;
    }

    public void SetCurrentHp(float currentHp)
    {
	    _currentHp = currentHp;

      HpChanged?.Invoke();
    }

    public void SetMaxHp(float maxHp)
    {
	    _maxHp = maxHp;

	    HpChanged?.Invoke();
		}

		public float GetHpPercent() =>
	    (_currentHp / _maxHp) * 100f;
  }
}