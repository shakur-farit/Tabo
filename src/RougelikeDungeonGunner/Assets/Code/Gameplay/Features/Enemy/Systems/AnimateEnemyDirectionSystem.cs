using Code.Gameplay.Features.Enemy.Behaviours;
using Code.Gameplay.Features.Enemy.States.StateMachine;
using Code.Gameplay.Features.Hero.States.HeroAnimationStates;
using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Enemy.Systems
{
	public class AnimateEnemyDirectionSystem : IExecuteSystem
	{
		private readonly IEnemyAnimationStateMachine _stateMachine;
		private readonly IGroup<GameEntity> _enemies;

		public AnimateEnemyDirectionSystem(GameContext game, IEnemyAnimationStateMachine stateMachine)
		{
			_stateMachine = stateMachine;
			_enemies = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Enemy,
					GameMatcher.EnemyAnimator,
					GameMatcher.Direction));
		}

		public void Execute()
		{
			foreach (GameEntity enemy in _enemies)
			{
				float angle = Mathf.Atan2(enemy.Direction.y, enemy.Direction.x) * Mathf.Rad2Deg;

				Debug.Log(angle);

				AnimateDirection(angle, enemy.EnemyAnimator);
			}
		}

		private void AnimateDirection(float angle, EnemyAnimator animator)
		{
			if (angle >= 22f && angle <= 67f)
				_stateMachine.Enter<EnemyUpRightDirectionAnimationState>(animator);
			else if (angle > 67f && angle <= 112f)
				_stateMachine.Enter<EnemyUpDirectionAnimationState>(animator);
			else if (angle > 112f && angle <= 158f)
				_stateMachine.Enter<EnemyUpLeftDirectionAnimationState>(animator);
			else if ((angle <= 180f && angle > 158f) || (angle > -180f && angle <= -135f))
				_stateMachine.Enter<EnemyLeftDirectionAnimationState>(animator);
			else if (angle > -135f && angle <= -45f)
				_stateMachine.Enter<EnemyDownDirectionAnimationState>(animator);
			else if ((angle > -45f && angle <= 0f) || (angle > 0f && angle < 22f))
				_stateMachine.Enter<EnemyRightDirectionAnimationState>(animator);
		}
	}
}