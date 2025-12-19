using UnityEngine;
using Entitas;

namespace Code.Gameplay.Features.Enemy.Systems
{
  public class TargetDetectingSystem : IExecuteSystem
  {
    private readonly IGroup<GameEntity> _enemies;
    private readonly IGroup<GameEntity> _heroes;

    public TargetDetectingSystem(GameContext game)
    {
      _enemies = game.GetGroup(GameMatcher
        .AllOf(
          GameMatcher.Enemy,
          GameMatcher.WorldPosition,
          GameMatcher.TargetDetectingRadius));

      _heroes = game.GetGroup(GameMatcher
        .AllOf(
          GameMatcher.Hero,
          GameMatcher.WorldPosition));
    }

    public void Execute()
    {
      foreach (GameEntity enemy in _enemies)
      foreach (GameEntity hero in _heroes)
      {
        float distance = Vector3.Distance(enemy.WorldPosition, hero.WorldPosition);

        enemy.isTargetDetected = distance <= enemy.TargetDetectingRadius;
      }
    }
  }
}