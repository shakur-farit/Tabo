using Code.Infrastructure.Services;
using Code.Infrastructure.States.GameStates;
using Code.Infrastructure.States.StateMachine;
using Code.Meta.UI.Windows.Service;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.Meta.UI.Windows.Behaviours
{
	public class GameOverWindow : BaseWindow
	{
		[SerializeField] private Button _quitButton;
		[SerializeField] private Button _restartButton;
		[SerializeField] private Button _leaderboardButton;

		private IGameStateMachine _stateMachine;
		private IQuitGameService _quit;
		private IWindowService _windowService;

		[Inject]
    public void Constructor(
	    IGameStateMachine stateMachine,
	    IQuitGameService quit,
	    IWindowService windowService)
    {
      Id = WindowId.GameOverWindow;

			_stateMachine = stateMachine;
			_quit = quit;
			_windowService = windowService;
		}

    protected override void Initialize()
    {
	    _restartButton.onClick.AddListener(RestartGame);
			_quitButton.onClick.AddListener(QuitGame);
			_leaderboardButton.onClick.AddListener(OpenLeaderboard);
    }

    private void RestartGame()
		{
			_windowService.Close(WindowId.GameOverWindow);
			_stateMachine.Enter<LoadingHomeScreenState>();
		}

    private void QuitGame()
		{
			_windowService.Close(WindowId.GameOverWindow);
			_quit.QuitGame();
		}

    private void OpenLeaderboard() => 
      _windowService.Open(WindowId.LeaderboardWindow);
  }
}