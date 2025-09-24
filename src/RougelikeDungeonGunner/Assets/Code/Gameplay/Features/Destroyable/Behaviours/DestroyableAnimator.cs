using System;
using Code.Common.Extensions;
using UnityEngine;

namespace Code.Gameplay.Features.Destroyable.Behaviours
{
  public class DestroyableAnimator : MonoBehaviour
  {
    [SerializeField] private Animator _animator;

    private readonly int _isDestroy = Animator.StringToHash("destroy");

    public void PlayDestroy() => 
	    _animator.SetBool(_isDestroy, true);
  }

  public class DestroyableCollider : MonoBehaviour
  {
    [SerializeField] private DestroyableAnimator _animator;

	  private void OnTriggerEnter2D(Collider2D other)
	  {
		  if(other.gameObject.layer == (int)CollisionLayer.Hero || 
		     other.gameObject.layer == (int)CollisionLayer.Ammo)
				_animator.PlayDestroy();
	  }
  }
}