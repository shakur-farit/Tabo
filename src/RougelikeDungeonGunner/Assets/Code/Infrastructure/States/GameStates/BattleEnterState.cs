using Code.Gameplay.Features.Level;
using Code.Gameplay.Features.Level.Factory;
using Code.Gameplay.Features.Level.Services;
using Code.Gameplay.Input.Systems;
using Code.Infrastructure.States.StateInfrastructure;
using Code.Infrastructure.States.StateMachine;
using Code.Meta.UI.Windows;
using Code.Meta.UI.Windows.Service;
using Code.Sounds.Music;
using Code.Sounds.Music.Services;

namespace Code.Infrastructure.States.GameStates
{
	public class BattleEnterState : SimpleState
	{
		private readonly IGameStateMachine _stateMachine;
		private readonly ILevelFactory _levelFactory;
		private readonly IWindowService _windowService;
		private readonly IMusicClipSetter _clipSetter;
    private readonly IGamePlatformProvider _platformProvider;
    private readonly IHudDependPlatformProvider _hudProvider;
    private readonly ILevelService _levelService;

		public BattleEnterState(
			IGameStateMachine stateMachine,
			ILevelFactory levelFactory,
			IWindowService windowService,
			IMusicClipSetter clipSetter,
			IGamePlatformProvider platformProvider,
			IHudDependPlatformProvider hudProvider,
			ILevelService levelService)
		{
			_stateMachine = stateMachine;
			_levelFactory = levelFactory;
			_windowService = windowService;
			_clipSetter = clipSetter;
      _platformProvider = platformProvider;
      _hudProvider = hudProvider;
      _levelService = levelService;
    }

		public override void Enter()
		{
			CreateNewLevel();
			OpenHud();
			PlayClearedRoomMusic(MusicTypeId.ClearedRoom);
			EnterToBattleLoop();
		}

		private void CreateNewLevel() => 
			_levelFactory.CreateLevel(_levelService.GetCurrentLevel());

		private void OpenHud() => 
			_windowService.Open(_hudProvider.GetHud());

    private void PlayClearedRoomMusic(MusicTypeId typeId) => 
			_clipSetter.SetClip(typeId);

		private void EnterToBattleLoop() => 
			_stateMachine.Enter<BattleLoopState>();
	}
}