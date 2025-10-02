namespace Code.Common.Entity
{
  public static class CreateSoundsEntity
  {
    public static SoundsEntity Empty() =>
      Contexts.sharedInstance.sounds.CreateEntity();
  }
}