using Code.Gameplay.Cameras.Provider;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

namespace Code.Gameplay.Input.Service
{
  public class StandaloneInputService : InputService, IStandaloneInputService
  {
    public StandaloneInputService(ICameraProvider cameraProvider) : base(cameraProvider)
    {
    }

    public Vector2 GetWorldMousePosition()
    {
      if (CameraProvider.MainCamera == null || Mouse.current == null)
        return Vector2.zero;

      Vector3 screenPos = Mouse.current.position.ReadValue();
      return CameraProvider.MainCamera.ScreenToWorldPoint(screenPos);
    }

    public Vector2 GetScreenMousePosition() => CameraProvider.MainCamera && Mouse.current != null
      ? Mouse.current.position.ReadValue()
      : Vector2.zero;

    public bool GetLeftMouseButtonPressed() => 
	    Mouse.current.leftButton.isPressed && !EventSystem.current.IsPointerOverGameObject();

    public bool GetLeftMouseButtonDown() =>
      Mouse.current.leftButton.wasPressedThisFrame && !EventSystem.current.IsPointerOverGameObject();

    public bool GetLeftMouseButtonUp() =>
      Mouse.current.leftButton.wasReleasedThisFrame && !EventSystem.current.IsPointerOverGameObject();

    public bool GetPauseButtonDown() => 
      Input.Player.Pause.WasReleasedThisFrame();

    public bool GetWeaponReloadButtonDown() =>
      Input.Player.ReloadWeapon.WasReleasedThisFrame();
  }
}