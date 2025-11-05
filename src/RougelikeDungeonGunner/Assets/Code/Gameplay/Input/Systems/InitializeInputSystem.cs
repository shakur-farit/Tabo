using Code.Common.Entity;
using Code.Common.Extensions;
using Code.GamePlatform;
using Code.GamePlatform.Services;
using Entitas;
using UnityEngine;

namespace Code.Gameplay.Input.Systems
{
	public class InitializeInputSystem : IInitializeSystem
	{
    private readonly IGamePlatformProvider _platformProvider;

    public InitializeInputSystem(IGamePlatformProvider platformProvider) => 
      _platformProvider = platformProvider;

    public void Initialize()
    {
      InputEntity input = CreateInputEntity.Empty()
        .With(x => x.isInput = true);

      GetPlatform(input);
    }

    private InputEntity GetPlatform(InputEntity entity)
    {
      switch (_platformProvider.GetGamePlatform())
      {
        case GamePlatformTypeId.Standalone:
          entity.isStandaloneInput = true;
          break;
        case GamePlatformTypeId.Mobile:
          entity.isMobileInput = true;
          break;
      }

      return entity;
    }
  }
}