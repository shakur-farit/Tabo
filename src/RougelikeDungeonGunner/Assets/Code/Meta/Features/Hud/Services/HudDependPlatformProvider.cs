using System;
using Code.GamePlatform;
using Code.GamePlatform.Services;
using Code.Meta.UI.Windows;

namespace Code.Meta.Features.Hud.Services
{
  public class HudDependPlatformProvider : IHudDependPlatformProvider
  {
    private readonly IGamePlatformProvider _platformProvider;

    public HudDependPlatformProvider(IGamePlatformProvider platformProvider) => 
      _platformProvider = platformProvider;

    public WindowId GetHud()
    {
      switch (_platformProvider.GetGamePlatform())
      {
        case GamePlatformTypeId.Standalone:
          return WindowId.StandaloneHud;
        case GamePlatformTypeId.Mobile:
          return WindowId.MobileHud;
      }

      throw new Exception("Have no HUD for this platform");
    }
  }
}