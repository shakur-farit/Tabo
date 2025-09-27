using Entitas;

namespace Code.Gameplay.Features.Enemy.Systems
{
  public class ShowEnemyTargetSpriteSystem : IExecuteSystem
  {
    private readonly IGroup<GameEntity> _enemies;

    public ShowEnemyTargetSpriteSystem(GameContext game)
    {
      _enemies = game.GetGroup(GameMatcher
        .AllOf(
          GameMatcher.Enemy,
          GameMatcher.EnemyTargetSpriteRenderer));
    }

    public void Execute()
    {
      foreach (GameEntity enemy in _enemies) 
        enemy.EnemyTargetSpriteRenderer.enabled = enemy.isClosestTarget;
    }
  }
}