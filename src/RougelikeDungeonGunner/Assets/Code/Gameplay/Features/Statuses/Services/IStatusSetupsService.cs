using System.Collections.Generic;
using Code.Gameplay.Features.Statuses;
using Code.Gameplay.Features.Weapon;

namespace Code.Gameplay.Features.Hero
{
  public interface IStatusSetupsService
  {
    IReadOnlyList<StatusSetup> GetStatusSetups(WeaponTypeId typeId);
    void AddBoughtStatusSetup(WeaponTypeId typeId, StatusSetup setup);
    void Clear();
  }
}