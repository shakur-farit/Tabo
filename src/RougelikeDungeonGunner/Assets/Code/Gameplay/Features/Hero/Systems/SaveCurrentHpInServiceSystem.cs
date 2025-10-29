using Code.Gameplay.Features.Hero.Services;
using Entitas;

namespace Code.Gameplay.Features.Hero.Systems
{
  public class SaveCurrentHpInServiceSystem : IExecuteSystem
  {
    private readonly IHeroHpProvider _heroHp;
    private readonly IGroup<GameEntity> _heroes;

    public SaveCurrentHpInServiceSystem(GameContext game, IHeroHpProvider heroHp)
    {
      _heroHp = heroHp;
      _heroes = game.GetGroup(GameMatcher
        .AllOf(
          GameMatcher.CurrentHp,
          GameMatcher.Hero));
    }

    public void Execute()
    {
      foreach (GameEntity hero in _heroes)
      {
        _heroHp.SetCurrentHp(hero.CurrentHp);
      }
    }
  }
}