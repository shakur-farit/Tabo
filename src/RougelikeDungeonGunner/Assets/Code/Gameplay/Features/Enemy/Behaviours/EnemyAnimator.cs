using System;
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
			DOTween.Kill(transform);

		public void StartIdling() => _animator.SetBool(_isMoving, false);

		public void StartMoving() => _animator.SetBool(_isMoving, true);

		public void StartAimUp() => _animator.SetBool(_aimUp, true);
		public void StopAimUp() => _animator.SetBool(_aimUp, false);

		public void StartAimUpRight() => _animator.SetBool(_aimUpRight, true);
		public void StopAimUpRight() => _animator.SetBool(_aimUpRight, false);

		public void StartAimUpLeft() => _animator.SetBool(_aimUpLeft, true);
		public void StopAimUpLeft() => _animator.SetBool(_aimUpLeft, false);

		public void StartAimRight() => _animator.SetBool(_aimRight, true);
		public void StopAimRight() => _animator.SetBool(_aimRight, false);

		public void StartAimLeft() => _animator.SetBool(_aimLeft, true);
		public void StopAimLeft() => _animator.SetBool(_aimLeft, false);

		public void StartAimDown() => _animator.SetBool(_aimDown, true);
		public void StopAimDown() => _animator.SetBool(_aimDown, false);

		public void PlayDied()
		{
			Debug.Log("Enemy death animation");
			//_animator.SetTrigger(_diedHash);
		}

		public void PlayDamageTaken()
		{
			_spriteRenderer.DOColor(Color.red, 0.1f).OnComplete(() =>
			{
				_spriteRenderer.DOColor(Color.white, 0.1f);
			});
		}

		public void ResetAll()
		{
			_animator.ResetTrigger(_diedHash);
		}
	}
}