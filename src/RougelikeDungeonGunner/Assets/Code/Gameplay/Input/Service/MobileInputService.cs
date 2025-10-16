using Code.Gameplay.Cameras.Provider;

namespace Code.Gameplay.Input.Service
{
  public class MobileInputService : InputService, IMobileInputService
  {
    public MobileInputService(ICameraProvider cameraProvider) : base(cameraProvider)
    {
    }
  }
}