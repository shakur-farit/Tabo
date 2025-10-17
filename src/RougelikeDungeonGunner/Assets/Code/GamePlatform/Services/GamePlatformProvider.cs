namespace Code.Gameplay.Input.Systems
{
  public class GamePlatformProvider : IGamePlatformProvider
  {
    public GamePlatformTypeId GetGamePlatform()
    {
#if UNITY_EDITOR
      return GamePlatformTypeId.Mobile;
#elif UNITY_STANDALONE
            return GamePlatformTypeId.Standalone;
#elif UNITY_ANDROID || UNITY_IOS
            return GamePlatformTypeId.Mobile;
#elif UNITY_WEBGL
            if (Application.isMobilePlatform)
                return GamePlatformTypeId.Mobile;
            else
                return GamePlatformTypeId.Standalone;
#else
            return GamePlatformTypeId.Unknown;
#endif
    }
  }
}