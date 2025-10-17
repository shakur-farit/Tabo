using Code.Gameplay.Cameras.Provider;

namespace Code.Gameplay.Input.Service
{
  public class MobileInputService : InputService, IMobileInputService
  {
	  public MobileInputService(ICameraProvider cameraProvider) : base(cameraProvider)
	  {
	  }

	  public bool GetFireButtonPressed() => Input.Player.Shoot.IsPressed();

	  public bool GetFireButtonDown() => Input.Player.Shoot.WasPressedThisFrame();

	  public bool GetFireButtonUp() => Input.Player.Shoot.WasReleasedThisFrame();
	}
}