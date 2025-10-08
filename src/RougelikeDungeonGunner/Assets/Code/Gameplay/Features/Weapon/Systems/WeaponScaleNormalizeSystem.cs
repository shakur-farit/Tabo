using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Weapon.Systems
{
  public class WeaponScaleNormalizeSystem : IExecuteSystem
  {
    private readonly IGroup<GameEntity> _weapons;

    public WeaponScaleNormalizeSystem(GameContext game)
    {
      _weapons = game.GetGroup(GameMatcher
        .AllOf(
          GameMatcher.Weapon,
          GameMatcher.Transform));
    }

    public void Execute()
    {
      foreach (GameEntity weapon in _weapons) 
        weapon.Transform.localScale = Vector3.one;
    }
  }
}