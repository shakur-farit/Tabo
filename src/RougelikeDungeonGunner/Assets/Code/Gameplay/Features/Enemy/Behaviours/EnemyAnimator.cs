using Code.Gameplay.Common;
using Code.Gameplay.Common.Direction;
using Code.Gameplay.Common.Visuals;
using DG.Tweening;
using UnityEngine;

namespace Code.Gameplay.Features.Enemy.Behaviours
{
	public class EnemyAnimator : MonoBehaviour, IDamageTakenAnimator
	{
		[SerializeField] private Animator _animator;
		[SerializeField] private SpriteRenderer _spriteRenderer;

		private readonly int _isMoving = Animator.StringToHash("isMoving");
		private readonly int _facingDirectionIndex = Animator.StringToHash("facingDirectionIndex");
		private readonly int _diedHash = Animator.StringToHash("died");

		private FacingDirection _currentDirection = FacingDirection.Unknown;

		private void OnDestroy() =>
			DOTween.Kill(_spriteRenderer);

		public void StartIdling() => _animator.SetBool(_isMoving, false);
		public void StartMoving() => _animator.SetBool(_isMoving, true);

		public void SetDirectionEnum(FacingDirection direction)
		{
			if (_currentDirection != direction)
			{
				_currentDirection = direction; 
				_animator.SetInteger(_facingDirectionIndex, (int)direction);
			}
		}

		public void PlayDamageTaken() =>
			_spriteRenderer.DOColor(Color.red, 0.1f).OnComplete(() =>
				_spriteRenderer.DOColor(Color.white, 0.1f));

		public void PlayDied() { }

		public void SetRuntimeAnimatorController(RuntimeAnimatorController runtimeAnimatorController) =>
			_animator.runtimeAnimatorController = runtimeAnimatorController;
	}
}