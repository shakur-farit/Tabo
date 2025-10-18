using Code.Meta.UI.Windows;

namespace Code.Infrastructure.States.GameStates
{
  public interface IHudDependPlatformProvider
  {
    WindowId GetHud();
  }
}