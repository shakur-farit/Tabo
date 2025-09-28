using System.Collections.Generic;
using Code.Gameplay.Common.Time;
using Code.Infrastructure.States.GameStates;
using Code.Infrastructure.States.StateMachine;
using Entitas;

namespace Code.Gameplay.Features.Level.Systems
{
	public class FinalizeProcessedLevelSystem : IExecuteSystem
	{
		private readonly List<GameEntity> _buffer = new(1);

		private readonly IGameStateMachine _stateMachine;
		private readonly ITimeService _time;
		private readonly IGroup<GameEntity> _levels;
		private readonly IGroup<GameEntity> _holders;

		public FinalizeProcessedLevelSystem(GameContext game, IGameStateMachine stateMachine)
		{
			_stateMachine = stateMachine;
			_levels = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Level,
					GameMatcher.Processed));
		}

		public void Execute()
		{
			foreach (GameEntity level in _levels.GetEntities(_buffer))
			{
				level.isDestructed = true;
				_stateMachine.Enter<LevelCompleteState>();
			}
		}
	}
}