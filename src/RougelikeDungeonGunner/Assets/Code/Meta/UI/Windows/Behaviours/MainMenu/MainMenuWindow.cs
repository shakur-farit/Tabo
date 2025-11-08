using Code.Infrastructure.Loading;
using Code.Infrastructure.Services;
using Code.Infrastructure.States.GameStates;
using Code.Infrastructure.States.StateMachine;
using Code.Meta.UI.Windows.Services;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.Meta.UI.Windows.Behaviours.MainMenu
{
	public class MainMenuWindow : BaseWindow
	{
		[SerializeField] private Button _startGameButton;
		[SerializeField] private Button _settingsButton;
		[SerializeField] private Button _quitButton;
		[SerializeField] private Button _leadersButton;
		[SerializeField] private PlayerAuthentication _authentication;

    private IGameStateMachine _stateMachine;
		private IWindowService _windowService;
		private IQuitGameService _quit;

		[Inject]
		public void Constructor(
			IGameStateMachine stateMachine,
			IWindowService windowService,
			IQuitGameService quit)
		{
			Id = WindowId.MainMenuWindow;

			_stateMachine = stateMachine;
			_windowService = windowService;
			_quit = quit;
		}

		protected override void Initialize()
    {
      _startGameButton.onClick.AddListener(StartGame);
      _settingsButton.onClick.AddListener(OpenSettings);
      _leadersButton.onClick.AddListener(OpenLeaderboard);
      _quitButton.onClick.AddListener(QuitGame);
    }

		private async void StartGame()
    {
      if(await _authentication.IsNameValid() == false)
        return;

      await _stateMachine.Enter<LoadingBattleState, string>(Scenes.Gameplay);
	    _windowService.Close(WindowId.MainMenuWindow);
    }

		private void OpenSettings() => 
			_windowService.Open(WindowId.SettingsWindow);

		private void OpenLeaderboard() => 
			_windowService.Open(WindowId.LeaderboardWindow);

		private void QuitGame()
    {
	    _windowService.Close(WindowId.MainMenuWindow);
	    _quit.QuitGame();
    }
	}
}