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
					GameMatcher.Direction)
				.NoneOf(GameMatcher.Stunned));
		}

		public void Execute()
		{
			foreach (GameEntity enemy in _enemies)
			{
				float angle = Mathf.Atan2(enemy.Direction.y, enemy.Direction.x) * Mathf.Rad2Deg;

				AnimateDirection(angle, enemy.EnemyAnimator);
			}
		}

		private void AnimateDirection(float angle, EnemyAnimator animator)
		{
			//if (angle >= 22f && angle <= 67f)
			//	_stateMachine.Enter<EnemyUpRightDirectionAnimationState>(animator);
			//else if (angle > 67f && angle <= 112f)
			//	_stateMachine.Enter<EnemyUpDirectionAnimationState>(animator);
			//else if (angle > 112f && angle <= 158f)
			//	_stateMachine.Enter<EnemyUpLeftDirectionAnimationState>(animator);
			//else if ((angle <= 180f && angle > 158f) || (angle > -180f && angle <= -135f))
			//	_stateMachine.Enter<EnemyLeftDirectionAnimationState>(animator);
			//else if (angle > -135f && angle <= -45f)
			//	_stateMachine.Enter<EnemyDownDirectionAnimationState>(animator);
			//else if ((angle > -45f && angle <= 0f) || (angle > 0f && angle < 22f))
			//	_stateMachine.Enter<EnemyRightDirectionAnimationState>(animator);

			if (angle >= 22f && angle <= 67f)
			{
				animator.Recall();
				animator.StartLookUpRightAnimation();
			}
			else if (angle > 67f && angle <= 112f)
			{
				animator.Recall();
				animator.StartLookUpAnimation();
			}
			else if (angle > 112f && angle <= 158f)
			{
				animator.Recall();
				animator.StartLookUpLeftAnimation();
			}
			else if ((angle <= 180f && angle > 158f) || (angle > -180f && angle <= -135f))
			{
				animator.Recall();
				animator.StartLookLeftAnimation();
			}
			else if (angle > -135f && angle <= -45f)
			{
				animator.Recall();
				animator.StartLookDownAnimation();
			}
			else if ((angle > -45f && angle <= 0f) || (angle > 0f && angle < 22f))
			{
				animator.Recall();
				animator.StartLookRightAnimation();
			}
		}
	}
}