using Code.Common.Extensions;
using Code.Gameplay.Features.AmmoPattern.Factory;
using Entitas;

namespace Code.Gameplay.Features.Enemy.Systems
{
  public class ProcessAmmoPatternSpawnRequestSystem : IExecuteSystem
  {
    private readonly IAmmoPatternFactory _ammoPatternFactory;
    private readonly IGroup<GameEntity> _requests;
    private readonly IGroup<GameEntity> _requestSettings;

    public ProcessAmmoPatternSpawnRequestSystem(
	    GameContext game, 
	    IAmmoPatternFactory ammoPatternFactory)
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
          GameMatcher.AmmoPatternSpawnRequestSetting,
          GameMatcher.MaxSpawnPerFrame));
    }

    public void Execute()
    {
      foreach (GameEntity requestSetting in _requestSettings)
      {
        int processed = 0;

        foreach (GameEntity request in _requests)
        {
          if (processed >= requestSetting.MaxSpawnPerFrame)
            break;

          GameEntity pattern = _ammoPatternFactory.CreatePattern(request.AmmoPatternSetup, request.AmmoTypeId,
            request.FirePositionTransform.position, request.Direction);

          pattern.AddProducerId(request.ProducerId);

          if (request.isRotationAvailable && request.isRotating)
          {
            pattern
							.With(x => x.isRotationAvailable = true)
							.With(x => x.isRotating = true);
					}

					processed++;

          request.isProcessed = true;
        }
      }
    }
  }
}