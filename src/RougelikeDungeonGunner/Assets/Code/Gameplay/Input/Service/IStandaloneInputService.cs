using UnityEngine;

namespace Code.Gameplay.Input.Service
{
  public interface IStandaloneInputService : IInputService
  {
    bool GetLeftMouseButtonPressed();
    bool GetLeftMouseButtonDown();
    Vector2 GetScreenMousePosition();
    Vector2 GetWorldMousePosition();
    bool GetLeftMouseButtonUp();
    bool GetWeaponReloadButtonDown();
    bool GetPauseButtonDown();
  }
}