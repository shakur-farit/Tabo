using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.SpecialEffect.Systems
{
  public class SetSpecialEffectRadiusSystem : IExecuteSystem
  {
    private const float Offset = 0.5f;

    private readonly IGroup<GameEntity> _specialEffects;

    public SetSpecialEffectRadiusSystem(GameContext game)
    {
      _specialEffects = game.GetGroup(GameMatcher
        .AllOf(
          GameMatcher.SpecialEffect,
          GameMatcher.Radius,
          GameMatcher.ParticleSystem));
    }

    public void Execute()
    {
      foreach (GameEntity specialEffects in _specialEffects)
      {
        ParticleSystem particleSystem = specialEffects.ParticleSystem;
        ParticleSystem.ShapeModule shape = particleSystem.shape;
        shape.radius = specialEffects.Radius - Offset;

        if (shape.radius < 0)
          shape.radius = 0;
      }
    }
  }
}