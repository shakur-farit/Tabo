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

		private IWindowService _windowService;
		private IGameStateMachine _stateMachine;

		[Inject]
		public void Constructor(IWindowService windowService, IGameStateMachine stateMachine)
		{
			Id = WindowId.GameOverWindow;

			_windowService = windowService;
			_stateMachine = stateMachine;
		}

		protected override void Initialize()
		{
			_restartButton.onClick.AddListener(RestartGame);
			_quitButton.onClick.AddListener(QuitGame);
		}

		private void RestartGame()
		{
			CloseWindow();

			_stateMachine.Enter<LoadingHomeScreenState>();
		}

		private void QuitGame()
		{
			CloseWindow();

#if UNITY_EDITOR
			UnityEditor.EditorApplication.isPlaying = false;
#else
    Application.Quit();
#endif
		}


		private void CloseWindow() =>
			_windowService.Close(WindowId.GameOverWindow);
	}
}