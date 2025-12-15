using UnityEngine;
using Code.Leaderboard;
using Code.Meta;

namespace Code.Infrastructure.Services
{
  public class QuitGameService : IQuitGameService
  {
	  private readonly ILeaderboardUpdater _leaderboardUpdater;

	  public QuitGameService(ILeaderboardUpdater leaderboardUpdater) => 
		  _leaderboardUpdater = leaderboardUpdater;

	  public void QuitGame()
    {
      UpdateLeaderboard();

#if UNITY_EDITOR
      UnityEditor.EditorApplication.isPlaying = false;
#else
    Application.Quit();
#endif
    }

    private void UpdateLeaderboard() =>
	    _leaderboardUpdater.UpdateLeaderboard();
	}
}