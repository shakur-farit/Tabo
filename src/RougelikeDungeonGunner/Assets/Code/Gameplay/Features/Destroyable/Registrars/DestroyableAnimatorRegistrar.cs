using Code.Infrastructure.View.Registrars;
using UnityEngine;

namespace Code.Gameplay.Features.Destroyable.Behaviours
{
  public class DestroyableAnimatorRegistrar : EntityComponentRegistrar
  {
    [SerializeField] private DestroyableAnimator _destroyableAnimator;

    public override void RegisterComponents() => 
      Entity.AddDestroyableAnimator(_destroyableAnimator);

    public override void UnregisterComponents()
    {
      if(Entity.hasDestroyableAnimator)
        Entity.RemoveDestroyableAnimator();
    }
  }
}