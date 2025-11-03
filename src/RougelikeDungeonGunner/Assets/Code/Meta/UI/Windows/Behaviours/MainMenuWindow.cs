using Code.Infrastructure.Loading;
using Code.Infrastructure.Services;
using Code.Infrastructure.States.GameStates;
using Code.Infrastructure.States.StateMachine;
using Code.Meta.UI.Windows.Service;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.Meta.UI.Windows.Behaviours
{
	public class MainMenuWindow : BaseWindow
	{
		[SerializeField] private Button _startGameButton;
		[SerializeField] private Button _settingsButton;
		[SerializeField] private Button _quitButton;

		private IGameStateMachine _stateMachine;
		private IWindowService _windowService;
		private IQuitGameService _quit;
    private ILeaderboardGetter _leaderboard;

    [Inject]
		public void Constructor(
			IGameStateMachine stateMachine,
			IWindowService windowService,
			ILeaderboardGetter leaderboard,
			IQuitGameService quit)
		{
			Id = WindowId.MainMenuWindow;

			_stateMachine = stateMachine;
			_windowService = windowService;
			_quit = quit;
      _leaderboard = leaderboard;
    }

		protected override void Initialize()
    {
      _startGameButton.onClick.AddListener(StartGame);
      _settingsButton.onClick.AddListener(OpenSettings);
      _quitButton.onClick.AddListener(QuitGame);

			LB();
    }

    private void StartGame()
    {
	     _stateMachine.Enter<LoadingBattleState, string>(Scenes.Gameplay);
	    _windowService.Close(WindowId.MainMenuWindow);
    }

    private async void LB()
    {
      await _leaderboard.GetLeaderboard();
    }

    private void OpenSettings() => 
			_windowService.Open(WindowId.SettingsWindow);

		private void QuitGame()
    {
	    _windowService.Close(WindowId.MainMenuWindow);
	    _quit.QuitGame();
    }
	}
}