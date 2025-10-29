namespace Code.Gameplay.Features.Hero.Services
{
  public interface IHeroHpProvider
  {
    float GetCurrentHp(HeroTypeId typeId);
    void SetCurrentHp(float currentHp);
    float GetMaxHp(HeroTypeId typeId);
    void SetMaxHp(float maxHp);
  }
}