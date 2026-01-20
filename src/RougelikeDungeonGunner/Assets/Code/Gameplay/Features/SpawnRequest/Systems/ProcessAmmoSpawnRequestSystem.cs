using Code.Gameplay.Features.AmmoPattern.Factory;
using Entitas;

namespace Code.Gameplay.Features.Enemy.Systems
{
  public class ProcessAmmoSpawnRequestSystem : IExecuteSystem
  {
    private readonly IAmmoPatternFactory _ammoPatternFactory;
    private readonly IGroup<GameEntity> _requests;
    private readonly IGroup<GameEntity> _requestSettings;

    public ProcessAmmoSpawnRequestSystem(GameContext game, IAmmoPatternFactory ammoPatternFactory)
    {
      _ammoPatternFactory = ammoPatternFactory;
      _requests = game.GetGroup(GameMatcher
        .AllOf(
          GameMatcher.SpawnRequest,
          GameMatcher.AmmoPatternSetup,
          GameMatcher.AmmoTypeId,
          GameMatcher.FirePositionTransform,
          GameMatcher.Direction,
          GameMatcher.ProducerId));

      _requestSettings = game.GetGroup(GameMatcher
        .AllOf(
          GameMatcher.SpawnRequestSetting,
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

          var pattern = _ammoPatternFactory.CreatePattern(requests.AmmoPatternSetup, requests.AmmoTypeId,
            requests.FirePositionTransform.position, requests.Direction);

          pattern.AddProducerId(requests.ProducerId);

          processed++;

          requests.isProcessed = true;
        }
      }
    }
  }
}