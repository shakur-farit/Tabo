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

		private readonly int _aimUp = Animator.StringToHash("aimUp");
		private readonly int _aimUpRight = Animator.StringToHash("aimUpRight");
		private readonly int _aimUpLeft = Animator.StringToHash("aimUpLeft");
		private readonly int _aimRight = Animator.StringToHash("aimRight");
		private readonly int _aimLeft = Animator.StringToHash("aimLeft");
		private readonly int _aimDown = Animator.StringToHash("aimDown");

		private readonly int _diedHash = Animator.StringToHash("died");

		private void OnDestroy() => 
			DOTween.Kill(_spriteRenderer);

		public void StartIdling() => _animator.SetBool(_isMoving, false);

		public void StartMoving() => _animator.SetBool(_isMoving, true);

		public void StartLookUpAnimation() => _animator.SetBool(_aimUp, true);
		public void StopLookUpAnimation() => _animator.SetBool(_aimUp, false);

		public void StartLookUpRightAnimation() => _animator.SetBool(_aimUpRight, true);
		public void StopLookUpRightAnimation() => _animator.SetBool(_aimUpRight, false);

		public void StartLookUpLeftAnimation() => _animator.SetBool(_aimUpLeft, true);
		public void StopLookUpLeftAnimation() => _animator.SetBool(_aimUpLeft, false);

		public void StartLookRightAnimation() => _animator.SetBool(_aimRight, true);
		public void StopAimRightAnimation() => _animator.SetBool(_aimRight, false);

		public void StartLookLeftAnimation() => _animator.SetBool(_aimLeft, true);
		public void StopLookLeftAnimation() => _animator.SetBool(_aimLeft, false);

		public void StartLookDownAnimation() => _animator.SetBool(_aimDown, true);
		public void StopLookDownAnimation() => _animator.SetBool(_aimDown, false);

		public void PlayDied()
		{
			
		}

		public void PlayDamageTaken()
		{
			_spriteRenderer.DOColor(Color.red, 0.1f).OnComplete(() =>
			{
				_spriteRenderer.DOColor(Color.white, 0.1f);
			});
		}

		public void SetRuntimeAnimatorController(RuntimeAnimatorController runtimeAnimatorController) => 
			_animator.runtimeAnimatorController = runtimeAnimatorController;
	}
}