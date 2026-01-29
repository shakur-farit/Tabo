using System.Collections.Generic;
using Entitas;

namespace Code.Gameplay.Features.Ammo.Systems
{
  public class AmmoStatusVisualReactiveSystem : ReactiveSystem<GameEntity>
  {
    public AmmoStatusVisualReactiveSystem(GameContext game) : base(game)
    {
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) =>
      context.CreateCollector(GameMatcher.AllOf(
          GameMatcher.Ammo,
          GameMatcher.AmmoStatusVisualizer,
          GameMatcher.StatusSetups)
        .Added()
      );

    protected override bool Filter(GameEntity ammos) => 
      ammos.isAmmo && ammos.hasStatusSetups && ammos.hasAmmoStatusVisualizer;

    protected override void Execute(List<GameEntity> ammos)
    {
      foreach (GameEntity ammo in ammos)
          ammo.AmmoStatusVisualizer.Visualize(ammo.StatusSetups);
    }
  }
}