using Code.Gameplay.Features.Level.Factory;
using Code.Gameplay.Features.Level.Services;
using Code.Infrastructure.States.StateInfrastructure;
using Code.Infrastructure.States.StateMachine;
using Code.Sounds.Music;
using Code.Sounds.Music.Services;

namespace Code.Infrastructure.States.GameStates
{
	public class BattleEnterState : SimpleState
	{
		private readonly IGameStateMachine _stateMachine;
		private readonly ILevelFactory _levelFactory;
		private readonly IMusicClipSetter _clipSetter;
    private readonly ILevelService _levelService;

		public BattleEnterState(
			IGameStateMachine stateMachine,
			ILevelFactory levelFactory,
			IMusicClipSetter clipSetter,
			ILevelService levelService)
		{
			_stateMachine = stateMachine;
			_levelFactory = levelFactory;
			_clipSetter = clipSetter;
      _levelService = levelService;
    }

		public override void Enter()
    {
			CreateNewLevel();
			PlayClearedRoomMusic(MusicTypeId.ClearedRoom);
			EnterToBattleLoop();
		}

		private void CreateNewLevel() => 
			_levelFactory.CreateLevel(_levelService.GetCurrentLevel());

    private void PlayClearedRoomMusic(MusicTypeId typeId) => 
			_clipSetter.SetClip(typeId);

		private void EnterToBattleLoop() => 
			_stateMachine.Enter<BattleLoopState>();
	}
}