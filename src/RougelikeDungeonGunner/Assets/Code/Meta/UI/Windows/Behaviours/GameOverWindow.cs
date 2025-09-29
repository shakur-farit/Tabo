using Code.Gameplay.Features.Music;
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

		private IWindowService _windowService;
		private IGameStateMachine _stateMachine;
    private IQuitGameService _quit;
    private IMusicClipSetter _clipSetter;

    [Inject]
		public void Constructor(
			IWindowService windowService, 
			IGameStateMachine stateMachine, 
			IQuitGameService quit,
			IMusicClipSetter clipSetter)
		{
			Id = WindowId.GameOverWindow;

			_windowService = windowService;
			_stateMachine = stateMachine;
      _quit = quit;
      _clipSetter = clipSetter;
		}

		protected override void Initialize()
		{
			_restartButton.onClick.AddListener(RestartGame);
			_quitButton.onClick.AddListener(QuitGame);

			PlayDungeonMelancholyMusic();
		}

		private void RestartGame()
		{
			CloseWindow();

			_stateMachine.Enter<LoadingHomeScreenState>();
		}

		private void QuitGame()
		{
			CloseWindow();

			_quit.QuitGame();
		}

		private void CloseWindow() =>
			_windowService.Close(WindowId.GameOverWindow);

		private void PlayDungeonMelancholyMusic() =>
			_clipSetter.SetClip(MusicTypeId.DungeonMelancholy);
	}
}