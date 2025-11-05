using Code.Gameplay.StaticData;
using Code.Meta.Features.Shop.EnchantUIEntry.Behaviours;
using Code.Meta.Features.Shop.EnchantUIEntry.Configs;
using Code.Meta.Features.Shop.EnchantUIEntry.Services;
using UnityEngine;
using Zenject;

namespace Code.Meta.UI.Windows.Behaviours.CurrentWeaponEnchantInfo
{
  public class CurrentWeaponEnchantStatsRenderer : MonoBehaviour
  {
    [SerializeField] private EnchantStatsUIHolder _enchantStatsUIHolder;

    private ISelectedEnchantUIEntryProvider _enchantUIEntry;
    private IStaticDataService _staticDataService;

    [Inject]
    public void Constructor(ISelectedEnchantUIEntryProvider enchantUIEntry, IStaticDataService staticDataService)
    {
      _enchantUIEntry = enchantUIEntry;
      _staticDataService = staticDataService;
    }

    private void Start() => 
      RenderUIStats();

    private void RenderUIStats()
    {
      EnchantUIEntryConfig config =
        _staticDataService.GetEnchantUIEntryItemConfig(_enchantUIEntry.TypeId);

      foreach (EnchantStatUIEntry statUIEntry in config.EnchantStatUIEntries)
        _enchantStatsUIHolder.CreateStats(statUIEntry.TypeId);
    }
  }
}