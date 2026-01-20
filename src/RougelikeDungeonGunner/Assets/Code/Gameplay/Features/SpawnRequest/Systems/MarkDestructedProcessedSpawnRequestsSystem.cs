using Entitas;

namespace Code.Gameplay.Features.Enemy.Systems
{
  public class MarkDestructedProcessedSpawnRequestsSystem : IExecuteSystem
  {
    private readonly IGroup<GameEntity> _requests;

    public MarkDestructedProcessedSpawnRequestsSystem(GameContext game)
    {
      _requests = game.GetGroup(GameMatcher
        .AllOf(
          GameMatcher.SpawnRequest, GameMatcher.Processed));
    }

    public void Execute()
    {
      foreach (GameEntity requests in _requests)
      {
        requests.isDestructed = true;
      }
    }
  }
}