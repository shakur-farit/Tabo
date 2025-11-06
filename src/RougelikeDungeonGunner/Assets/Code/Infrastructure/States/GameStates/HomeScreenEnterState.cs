using Code.Infrastructure.Loading;
using Code.Infrastructure.States.StateInfrastructure;
using Code.Infrastructure.States.StateMachine;
using Code.Meta.UI.Windows;
using Code.Meta.UI.Windows.Services;
using Code.Sounds.Music;
using Code.Sounds.Music.Services;

namespace Code.Infrastructure.States.GameStates
{
	public class HomeScreenEnterState : SimpleState
	{
		private readonly IWindowService _windowService;
		private readonly IGameStateMachine _stateMachine;
		private readonly IMusicClipSetter _clipSetter;
		private readonly ISceneLoader _sceneLoader;

		public HomeScreenEnterState(
			IWindowService windowService, 
			IGameStateMachine stateMachine,
			IMusicClipSetter clipSetter,
			ISceneLoader sceneLoader)
		{
			_windowService = windowService;
			_stateMachine = stateMachine;
			_clipSetter = clipSetter;
			_sceneLoader = sceneLoader;
		}


		public override void Enter()
		{
			OpenMainMenuWindow();
      PlayMainMenuMusic();
      EnterToHomeScreenState();
			_sceneLoader.UnloadScene(Scenes.GameLoading);
    }

		private async void EnterToHomeScreenState() => 
			await _stateMachine.Enter<HomeScreenState>();

		private void OpenMainMenuWindow() => 
			_windowService.Open(WindowId.MainMenuWindow);

		private void PlayMainMenuMusic() => 
			_clipSetter.SetClip(MusicTypeId.MainMenuMusic);
	}
}