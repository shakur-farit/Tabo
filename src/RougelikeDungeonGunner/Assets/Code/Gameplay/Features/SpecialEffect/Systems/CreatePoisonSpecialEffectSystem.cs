using Entitas;

namespace Code.Gameplay.Features.SpecialEffect.Systems
{
  public class CreatePoisonSpecialEffectSystem : IExecuteSystem
  {
    private readonly IGroup<GameEntity> _statuses;

    public CreatePoisonSpecialEffectSystem(GameContext game)
    {
      _statuses = game.GetGroup(GameMatcher
        .AllOf(
          GameMatcher.Poison,
          GameMatcher.Applied,
          GameMatcher.TargetId));
    }

    public void Execute()
    {
      foreach (GameEntity status in _statuses)
      {
        
      }
    }
  }
}