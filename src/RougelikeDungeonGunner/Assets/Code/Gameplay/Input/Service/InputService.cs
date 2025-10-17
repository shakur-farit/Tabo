using Code.Gameplay.Cameras.Provider;
using UnityEngine;

namespace Code.Gameplay.Input.Service
{
	public class InputService : IInputService
	{
    protected readonly ICameraProvider CameraProvider;
    protected readonly PlayerInputActions Input;

    public InputService(ICameraProvider cameraProvider)
    {
      CameraProvider = cameraProvider;
      Input = new PlayerInputActions();
			Input.Enable();
    }

    public bool HasAxisInput() => GetHorizontalAxis() != 0 || GetVerticalAxis() != 0;

    public float GetVerticalAxis() => Input.Player.Move.ReadValue<Vector2>().y;
    public float GetHorizontalAxis() => Input.Player.Move.ReadValue<Vector2>().x;
  }
}