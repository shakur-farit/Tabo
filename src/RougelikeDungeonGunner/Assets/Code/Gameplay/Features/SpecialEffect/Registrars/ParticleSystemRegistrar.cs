using Code.Infrastructure.View.Registrars;
using UnityEngine;

namespace Code.Gameplay.Features.SpecialEffect.Behaviours
{
  public class ParticleSystemRegistrar : EntityComponentRegistrar
  {
    [SerializeField] private ParticleSystem _particleSystems;

    public override void RegisterComponents() => 
      Entity.AddParticleSystem(_particleSystems);

    public override void UnregisterComponents()
    {
      if(Entity.hasParticleSystem)
        Entity.RemoveParticleSystem();
    }
  }
}