using UnityEngine;

namespace Code.Gameplay.Features.Weapon
{
	public class DoorAnimator : MonoBehaviour
	{
		[SerializeField] private Animator _animator;

		private readonly int _isOpening = Animator.StringToHash("isOpening");

		public void PlayOpening() => _animator.SetBool(_isOpening, true);
	}
}