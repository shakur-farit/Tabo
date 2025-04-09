using Code.Infrastructure.States.GameStates;
using Code.Infrastructure.States.StateMachine;
using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Levels
{
	public class FinalizeProcessedLevelSystem : IExecuteSystem
	{
		private readonly IGameStateMachine _stateMachine;
		private readonly IGroup<GameEntity> _levels;

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
			foreach (GameEntity level in _levels)
			{
				Debug.Log("Level Complete");
				level.isDestructed = true;
				_stateMachine.Enter<LevelCompleteState>();
			}
		}
	}
}