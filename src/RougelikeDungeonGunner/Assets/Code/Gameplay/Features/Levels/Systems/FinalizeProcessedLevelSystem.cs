using System.Collections.Generic;
using Code.Infrastructure.States.GameStates;
using Code.Infrastructure.States.StateMachine;
using Cysharp.Threading.Tasks;
using Entitas;

namespace Code.Gameplay.Features.Levels.Systems
{
	public class FinalizeProcessedLevelSystem : IExecuteSystem
	{
		private readonly IGameStateMachine _stateMachine;
		private readonly IGroup<GameEntity> _levels;
		private readonly List<GameEntity> _buffer = new(1);

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
			FinalizeAsync().Forget();
		}

		private async UniTaskVoid FinalizeAsync()
		{
			foreach (GameEntity level in _levels.GetEntities(_buffer))
			{
				level.isDestructed = true;
				await _stateMachine.Enter<LevelCompleteState>();
			}
		}
	}
}