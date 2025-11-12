using Code.Infrastructure.States.StateInfrastructure;
using Code.Infrastructure.States.StateMachine;
using Code.Meta.Features.HeroSelector.Behaviours;
using Code.Meta.UI.GameLoading.Services;
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
    private readonly IHeroSelectorProvider _heroSelectorProvider;
    private readonly IGameLoadingUIService _gameLoadingUIService;

		public HomeScreenEnterState(
			IWindowService windowService, 
			IGameStateMachine stateMachine,
			IMusicClipSetter clipSetter,
      IHeroSelectorProvider heroSelectorProvider,
      IGameLoadingUIService gameLoadingUIService)
		{
			_windowService = windowService;
			_stateMachine = stateMachine;
			_clipSetter = clipSetter;
      _heroSelectorProvider = heroSelectorProvider;
      _gameLoadingUIService = gameLoadingUIService;
		}


		public override void Enter()
		{
			OpenMainMenuWindow();
      CreateHeroSelector();
			CloseGameLoadingUI();
      PlayMainMenuMusic();
      EnterToHomeScreenState();
    }

    private void OpenMainMenuWindow() => 
      _windowService.Open(WindowId.MainMenuWindow);

    private void CreateHeroSelector() => 
			_heroSelectorProvider.CreateHeroSelector();

    private void CloseGameLoadingUI() => 
			_gameLoadingUIService.Close();

    private async void EnterToHomeScreenState() => 
			await _stateMachine.Enter<HomeScreenState>();

    private void PlayMainMenuMusic() => 
			_clipSetter.SetClip(MusicTypeId.MainMenuMusic);
	}
}