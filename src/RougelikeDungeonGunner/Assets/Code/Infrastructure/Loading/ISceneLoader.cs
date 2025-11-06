using System;

namespace Code.Infrastructure.Loading
{
  public interface ISceneLoader
  {
    void LoadScene(string name, Action onLoaded = null);
    void LoadSceneAdditive(string name, Action onLoaded = null);
    void UnloadScene(string name, Action onUnloaded = null);
  }
}