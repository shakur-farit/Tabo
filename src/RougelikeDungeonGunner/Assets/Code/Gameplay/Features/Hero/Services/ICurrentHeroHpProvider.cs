namespace Code.Gameplay.Features.Hero.Services
{
  public interface ICurrentHeroHpProvider
  {
    float GetCurrentHp(HeroTypeId typeId);
    void SetCurrentHp(float currentHp);
  }
}