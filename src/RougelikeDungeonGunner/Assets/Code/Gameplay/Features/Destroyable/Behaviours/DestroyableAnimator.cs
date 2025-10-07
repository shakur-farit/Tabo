using System;
using UnityEngine;

namespace Code.Gameplay.Features.Destroyable.Behaviours
{
  public class DestroyableAnimator : MonoBehaviour
  {
    private const string DestroyedState = "Destroyed";

    [SerializeField] private Animator _animator;

    private readonly int _isDestroy = Animator.StringToHash("destroy");

    private void OnDisable()
    {
      _animator.Rebind();
    }

    public void PlayDestroy() => 
	    _animator.SetBool(_isDestroy, true);

    public bool IsDestroyed() => 
      _animator.GetCurrentAnimatorStateInfo(0).IsName(DestroyedState);

    public void SetRuntimeAnimatorController(RuntimeAnimatorController controller) => 
      _animator.runtimeAnimatorController = controller;

    public void ResetAnimator()
    {
      
    }
  }
}