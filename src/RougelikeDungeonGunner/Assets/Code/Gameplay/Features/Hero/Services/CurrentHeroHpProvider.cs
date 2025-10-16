using Code.Gameplay.StaticData;

namespace Code.Gameplay.Features.Hero.Services
{
  public class CurrentHeroHpProvider : ICurrentHeroHpProvider
  {
    private float _currentHp;

    private readonly IStaticDataService _staticDataService;

    public CurrentHeroHpProvider(IStaticDataService staticDataService) =>
      _staticDataService = staticDataService;

    public float GetCurrentHp(HeroTypeId typeId)
    {
      if (_currentHp == 0)
        return _currentHp = _staticDataService.GetHeroConfig(typeId).CurrentHp;

      return _currentHp;
    }

    public void SetCurrentHp(float currentHp) => 
      _currentHp = currentHp;
  }
}