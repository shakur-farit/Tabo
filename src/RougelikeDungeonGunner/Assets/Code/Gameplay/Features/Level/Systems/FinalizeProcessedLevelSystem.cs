using System.Collections.Generic;
using Code.Gameplay.Common.Time;
using Code.Infrastructure.States.GameStates;
using Code.Infrastructure.States.StateMachine;
using Entitas;

namespace Code.Gameplay.Features.Level.Systems
{
	public class FinalizeProcessedLevelSystem : IExecuteSystem
	{
		private const string TimeText = "Time to level complete";

		private readonly List<GameEntity> _buffer = new(1);

		private readonly IGameStateMachine _stateMachine;
		private readonly ITimeService _time;
		private readonly IGroup<GameEntity> _levels;
		private readonly IGroup<GameEntity> _holders;

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

			_holders = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.TimerHolder));
		}

		public void Execute()
		{
			foreach (GameEntity level in _levels.GetEntities(_buffer))
			foreach (GameEntity holder in _holders)
			{
				if (level.FinishingTimeLeft <= 0)
				{
					level.ReplaceFinishingTimeLeft(level.FinishingTime);
					level.isDestructed = true;
					holder.TimerHolder.HideTimeText();
					_stateMachine.Enter<LevelCompleteState>();
				}
				else
				{
					level.ReplaceFinishingTimeLeft(level.FinishingTimeLeft - _time.DeltaTime);
					holder.TimerHolder.UpdateTimeText(TimeText, level.FinishingTimeLeft);
				}
			}
		}
	}
}