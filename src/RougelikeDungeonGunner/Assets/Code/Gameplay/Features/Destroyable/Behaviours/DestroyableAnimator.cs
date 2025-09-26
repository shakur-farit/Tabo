using UnityEngine;

namespace Code.Gameplay.Features.Destroyable.Behaviours
{
  public class DestroyableAnimator : MonoBehaviour
  {
    [SerializeField] private Animator _animator;

    private readonly int _isDestroy = Animator.StringToHash("destroy");

    public void PlayDestroy() => 
	    _animator.SetBool(_isDestroy, true);

    public void SetRuntimeAnimatorController(RuntimeAnimatorController controller) => 
      _animator.runtimeAnimatorController = controller;
  }
}