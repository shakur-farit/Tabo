using System.Collections.Generic;
using Code.Infrastructure.States.GameStates;
using Code.Infrastructure.States.StateMachine;
using Code.Meta.UI.Windows;
using Code.Meta.UI.Windows.Service;
using Entitas;

namespace Code.Gameplay.Features.Hero.Systems
{
	public class HeroDeathSystem : IExecuteSystem
	{
		private readonly List<GameEntity> _buffer = new(1);
		private readonly IGameStateMachine _stateMachine;
		private readonly IGroup<GameEntity> _heroes;

		public HeroDeathSystem(GameContext game, IGameStateMachine stateMachine)
		{
			_stateMachine = stateMachine;
			_heroes = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Hero,
					GameMatcher.Dead,
					GameMatcher.ProcessingDeath,
					GameMatcher.HeroAnimator));
		}

		public void Execute()
		{
			foreach (GameEntity hero in _heroes.GetEntities(_buffer))
			{
				hero.isMovementAvailable = false;

				hero.HeroAnimator.PlayDied();

				_stateMachine.Enter<GameOverState>();
			}
		}
	}
}