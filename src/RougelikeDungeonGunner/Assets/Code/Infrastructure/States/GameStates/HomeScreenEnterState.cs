using Code.Infrastructure.States.StateInfrastructure;
using Code.Infrastructure.States.StateMachine;
using Code.Meta.UI.Windows;
using Code.Meta.UI.Windows.Service;
using Code.Sounds.Music;
using Code.Sounds.Music.Services;

namespace Code.Infrastructure.States.GameStates
{
	public class HomeScreenEnterState : SimpleState
	{
		private readonly IWindowService _windowService;
		private readonly IGameStateMachine _stateMachine;
		private readonly IMusicClipSetter _clipSetter;

    public HomeScreenEnterState(
			IWindowService windowService, 
			IGameStateMachine stateMachine,
			IMusicClipSetter clipSetter)
		{
			_windowService = windowService;
			_stateMachine = stateMachine;
			_clipSetter = clipSetter;
    }


		public override void Enter()
		{
			OpenMainMenuWindow();
      PlayMainMenuMusic();
      EnterToHomeScreenState();
    }

		private async void EnterToHomeScreenState() => 
			await _stateMachine.Enter<HomeScreenState>();

		private void OpenMainMenuWindow() => 
			_windowService.Open(WindowId.MainMenuWindow);

		private void PlayMainMenuMusic() => 
			_clipSetter.SetClip(MusicTypeId.MainMenuMusic);
	}
}