using Code.Gameplay.Cameras.Provider;
using UnityEngine;

namespace Code.Gameplay.Input.Service
{
  public class MobileInputSystem
  {
    private readonly ICameraProvider _cameraProvider;
    private readonly PlayerInputActions _input;

    public MobileInputSystem(ICameraProvider cameraProvider)
    {
      _cameraProvider = cameraProvider;
      _input = new PlayerInputActions();
      _input.Enable();
    }

    public bool HasAxisInput()
    {
      Vector2 vector = _input.Moving.Move.ReadValue<Vector2>();

      return vector != Vector2.zero;
    }

    public float GetVerticalAxis() => _input.Moving.Move.ReadValue<Vector2>().y;
    public float GetHorizontalAxis() => _input.Moving.Move.ReadValue<Vector2>().x;
  }
}