using Code.Infrastructure.View.Registrars;
using UnityEngine;

namespace Code.Gameplay.Features.Ammo.Systems
{
  public class AmmoStatusVisualizerRegistrar : EntityComponentRegistrar
  {
    [SerializeField] private AmmoStatusVisualizer _visualizer;

    public override void RegisterComponents() => 
      Entity.AddAmmoStatusVisualizer(_visualizer);

    public override void UnregisterComponents()
    {
      if(Entity.hasAmmoStatusVisualizer)
        Entity.RemoveAmmoStatusVisualizer();
    }
  }
}