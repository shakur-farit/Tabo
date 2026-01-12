using System.Collections.Generic;
using Entitas;

namespace Code.Gameplay.Features.Weapon.Systems
{
  public class SetHeroWeaponReloadingStandalonePlatformSystem : IExecuteSystem
  {
    private readonly IGroup<GameEntity> _weapons;
    private readonly IGroup<InputEntity> _inputs;
    private readonly List<GameEntity> _buffer = new(1);
    private readonly List<InputEntity> _inputsBuffer = new(1);

    public SetHeroWeaponReloadingStandalonePlatformSystem(GameContext game, InputContext input)
    {
      _weapons = game.GetGroup(GameMatcher
        .AllOf(
          GameMatcher.Weapon,
          GameMatcher.HeroWeapon,
          GameMatcher.MagazineSize,
          GameMatcher.ReloadTime,
          GameMatcher.ReloadTimeLeft)
        .NoneOf(GameMatcher.Reloading));

      _inputs = input.GetGroup(InputMatcher
        .AllOf(
          InputMatcher.Input,
          InputMatcher.WeaponReloadButtonDown));
    }

    public void Execute()
    {
      foreach (GameEntity weapon in _weapons.GetEntities(_buffer))
      foreach (InputEntity input in _inputs.GetEntities(_inputsBuffer))
      {
        if (weapon.CurrentAmmoCount <= 0)
          continue;

        weapon.isMagazineNotEmpty = false;
        weapon.isReloading = true;

        input.isWeaponReloadButtonDown = false;
      }
    }
  }
}