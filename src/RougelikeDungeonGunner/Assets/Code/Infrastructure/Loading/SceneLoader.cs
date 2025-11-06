using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Code.Infrastructure.Loading
{
  public class SceneLoader : ISceneLoader
  {
    private readonly ICoroutineRunner _coroutineRunner;

    public SceneLoader(ICoroutineRunner coroutineRunner)
    {
      _coroutineRunner = coroutineRunner;
    }

    public void LoadScene(string name, Action onLoaded = null) =>
      _coroutineRunner.StartCoroutine(Load(name, onLoaded));

    public void LoadSceneAdditive(string name, Action onLoaded = null) =>
	    _coroutineRunner.StartCoroutine(LoadAdditive(name, onLoaded));

		public void UnloadScene(string name, Action onUnloaded = null) =>
			_coroutineRunner.StartCoroutine(Unload(name, onUnloaded));


		private IEnumerator Load(string nextScene, Action onLoaded)
    {
      if (SceneManager.GetActiveScene().name == nextScene)
      {
        onLoaded?.Invoke();
        yield break;
      }

      AsyncOperation waitNextScene = SceneManager.LoadSceneAsync(nextScene);

      while (!waitNextScene.isDone)
        yield return null;

      onLoaded?.Invoke();
    }

    private IEnumerator LoadAdditive(string nextScene, Action onLoaded)
    {
	    if (SceneManager.GetActiveScene().name == nextScene)
	    {
		    onLoaded?.Invoke();
		    yield break;
	    }

	    AsyncOperation waitNextScene = SceneManager.LoadSceneAsync(nextScene, LoadSceneMode.Additive);

	    while (!waitNextScene.isDone)
		    yield return null;

	    onLoaded?.Invoke();
    }

    private IEnumerator Unload(string sceneName, Action onUnloaded)
    {
	    if (!SceneManager.GetSceneByName(sceneName).isLoaded)
	    {
		    onUnloaded?.Invoke();
		    yield break;
	    }

	    AsyncOperation asyncUnload = SceneManager.UnloadSceneAsync(sceneName);

	    while (!asyncUnload.isDone)
		    yield return null;

	    onUnloaded?.Invoke();
    }
	}
}