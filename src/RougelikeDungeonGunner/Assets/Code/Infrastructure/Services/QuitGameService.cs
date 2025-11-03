using Code.Progress.Data.Progress;

namespace Code.Infrastructure.Services
{
  public class QuitGameService : IQuitGameService
  {
    private readonly ISaveSystem _save;

    public QuitGameService(ISaveSystem save) => 
      _save = save;

    public void QuitGame()
    {
      _save.Save();

#if UNITY_EDITOR
      UnityEditor.EditorApplication.isPlaying = false;
#else
    Application.Quit();
#endif
    }
  }
}