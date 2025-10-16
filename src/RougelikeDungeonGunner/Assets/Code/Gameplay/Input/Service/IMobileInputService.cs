namespace Code.Gameplay.Input.Service
{
  public interface IMobileInputService
  {
    float GetVerticalAxis();
    float GetHorizontalAxis();
    bool HasAxisInput();
  }
}