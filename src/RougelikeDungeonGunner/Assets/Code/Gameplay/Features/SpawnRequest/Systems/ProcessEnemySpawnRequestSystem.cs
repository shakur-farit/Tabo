using Code.Gameplay.Features.Enemy.Factory;
using Entitas;

namespace Code.Gameplay.Features.Enemy.Systems
{
  public class ProcessEnemySpawnRequestSystem : IExecuteSystem
  {
    private readonly IEnemyFactory _enemyFactory;
    private readonly IGroup<GameEntity> _requests;
    private readonly IGroup<GameEntity> _requestSettings;

    public ProcessEnemySpawnRequestSystem(GameContext game, IEnemyFactory enemyFactory)
    {
      _enemyFactory = enemyFactory;
      _requests = game.GetGroup(GameMatcher
        .AllOf(
          GameMatcher.SpawnRequest,
          GameMatcher.SpawnPosition,
          GameMatcher.EnemyTypeId));

      _requestSettings = game.GetGroup(GameMatcher
        .AllOf(
          GameMatcher.SpawnRequestSetting,
          GameMatcher.EnemySpawnRequestSetting,
          GameMatcher.MaxSpawnPerFrame));
    }

    public void Execute()
    {
      foreach (GameEntity requestSetting in _requestSettings)
      {
        int processed = 0;

        foreach (GameEntity requests in _requests)
        {
          if (processed >= requestSetting.MaxSpawnPerFrame)
            break;

          _enemyFactory.CreateEnemy(requests.EnemyTypeId, requests.SpawnPosition);

          processed++;

          requests.isProcessed = true;
        }
      }
    }
  }
}