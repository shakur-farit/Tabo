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

    [Inject]
		public void Constructor(IGameStateMachine stateMachine, IWindowService windowService, IQuitGameService quit)
		{
			Id = WindowId.MainMenuWindow;

      _stateMachine = stateMachine;
			_windowService = windowService;
      _quit = quit;
    }

		protected override void Initialize()
		{
			_startGameButton.onClick.AddListener(EnterToBattle);
			_startGameButton.onClick.AddListener(CloseWindow);
			_settingsButton.onClick.AddListener(OpenSettingsWindow);
			_quitButton.onClick.AddListener(Quit);
		}

		private void EnterToBattle() => 
			_stateMachine.Enter<LoadingBattleState, string>(Scenes.Gameplay);

    private void OpenSettingsWindow() =>
      _windowService.Open(WindowId.SettingsWindow);

    private void Quit()
    {
      CloseWindow();

			_quit.QuitGame();
    }

    private void CloseWindow() => 
			_windowService.Close(WindowId.MainMenuWindow);
	}
}