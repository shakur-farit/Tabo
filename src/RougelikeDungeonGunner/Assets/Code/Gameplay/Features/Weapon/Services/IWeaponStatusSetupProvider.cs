using System.Collections.Generic;
using Code.Gameplay.Features.Statuses;

namespace Code.Gameplay.Features.Weapon.Services
{
  public interface IWeaponStatusSetupProvider
  {
    IReadOnlyList<StatusSetup> GetStatusSetups(WeaponTypeId typeId);
    void AddBoughtStatusSetup(WeaponTypeId typeId, StatusSetup setup);
    void Clear();
  }
}