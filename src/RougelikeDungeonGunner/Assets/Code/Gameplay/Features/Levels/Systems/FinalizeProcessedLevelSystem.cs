using System.Collections.Generic;
using Code.Gameplay.Common.Time;
using Code.Infrastructure.States.GameStates;
using Code.Infrastructure.States.StateMachine;
using Cysharp.Threading.Tasks;
using Entitas;
using UnityEditorInternal;

namespace Code.Gameplay.Features.Levels.Systems
{
	public class FinalizeProcessedLevelSystem : IExecuteSystem
	{
		private readonly IGameStateMachine _stateMachine;
		private readonly ITimeService _time;
		private readonly IGroup<GameEntity> _levels;
		private readonly List<GameEntity> _buffer = new(1);

		public FinalizeProcessedLevelSystem(GameContext game, IGameStateMachine stateMachine, ITimeService time)
		{
			_stateMachine = stateMachine;
			_time = time;
			_levels = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Level,
					GameMatcher.Processed,
					GameMatcher.FinishingTimeLeft,
					GameMatcher.FinishingTime));
		}

		public void Execute()
		{
			FinalizeAsync().Forget();
		}

		private async UniTaskVoid FinalizeAsync()
		{
			foreach (GameEntity level in _levels.GetEntities(_buffer))
			{
				if (level.FinishingTimeLeft <= 0)
				{
					level.ReplaceFinishingTimeLeft(level.FinishingTime);
					level.isDestructed = true;
					await _stateMachine.Enter<LevelCompleteState>();
				}
				else
				{
					level.ReplaceFinishingTimeLeft(level.FinishingTimeLeft - _time.DeltaTime);
				}
			}
		}
	}
}