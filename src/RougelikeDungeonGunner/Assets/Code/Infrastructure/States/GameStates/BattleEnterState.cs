using Code.Gameplay.Features.Level.Factory;
using Code.Gameplay.Features.Music;
using Code.Gameplay.Features.Music.Services;
using Code.Infrastructure.States.StateInfrastructure;
using Code.Infrastructure.States.StateMachine;
using Code.Meta.UI.Windows;
using Code.Meta.UI.Windows.Service;
using Code.Progress.Provider;

namespace Code.Infrastructure.States.GameStates
{
	public class BattleEnterState : SimpleState
	{
		private readonly IGameStateMachine _stateMachine;
		private readonly ILevelFactory _levelFactory;
		private readonly IProgressProvider _progressProvider;
		private readonly IWindowService _windowService;
		private readonly IMusicClipSetter _clipSetter;

		public BattleEnterState(
			IGameStateMachine stateMachine,
			ILevelFactory levelFactory,
			IProgressProvider progressProvider,
			IWindowService windowService,
			IMusicClipSetter clipSetter)
		{
			_stateMachine = stateMachine;
			_levelFactory = levelFactory;
			_progressProvider = progressProvider;
			_windowService = windowService;
			_clipSetter = clipSetter;
		}

		public override void Enter()
		{
			CreateNewLevel();
			OpenHud();
			PlayClearedRoomMusic(MusicTypeId.ClearedRoom);
			EnterToBattleLoop();
		}

		private void CreateNewLevel() => 
			_levelFactory.CreateLevel(_progressProvider.LevelData.CurrentLevel);

		private void OpenHud() => 
			_windowService.Open(WindowId.Hud);

		private void PlayClearedRoomMusic(MusicTypeId typeId) => 
			_clipSetter.SetClip(typeId);

		private void EnterToBattleLoop() => 
			_stateMachine.Enter<BattleLoopState>();
	}
}