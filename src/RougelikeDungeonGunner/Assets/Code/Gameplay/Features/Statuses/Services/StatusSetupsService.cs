using System.Collections.Generic;
using System.Linq;
using Code.Gameplay.Features.Statuses;
using Code.Gameplay.Features.Weapon;
using Code.Gameplay.StaticData;

namespace Code.Gameplay.Features.Hero
{
  public class StatusSetupsService : IStatusSetupsService
  {
    private readonly IStaticDataService _staticDataService;
    private readonly Dictionary<WeaponTypeId, List<StatusSetup>> _boughtSetups = new();

    public StatusSetupsService(IStaticDataService staticDataService) =>
      _staticDataService = staticDataService;

    public IReadOnlyList<StatusSetup> GetStatusSetups(WeaponTypeId typeId)
    {
      List<StatusSetup> baseSetups = _staticDataService.GetWeaponConfig(typeId).StatusSetups;
      if (_boughtSetups.TryGetValue(typeId, out List<StatusSetup> boughtSetups))
        return baseSetups.Concat(boughtSetups).ToList();

      return baseSetups.ToList();
    }

    public void AddBoughtStatusSetup(WeaponTypeId typeId, StatusSetup setup)
    {
      if (_boughtSetups.TryGetValue(typeId, out List<StatusSetup> list) == false)
        _boughtSetups[typeId] = new List<StatusSetup>();

      if (_boughtSetups[typeId].Exists(s => s.StatusTypeId == setup.StatusTypeId))
        return;

      _boughtSetups[typeId].Add(setup);
    }

    public void Clear() => 
      _boughtSetups.Clear();
  }
}