using Code.Gameplay.StaticData;
using Code.Meta.Features.Shop.EnchantUIEntry.Behaviours;
using Code.Meta.Features.Shop.EnchantUIEntry.Configs;
using Code.Meta.Features.Shop.EnchantUIEntry.Services;

namespace Code.Meta.UI.Windows.Behaviours
{
  public class EnchantStatsUIRenderer : IEnchantStatsUIRenderer
  {
    private readonly ISelectedEnchantUIEntryProvider _enchantUIEntry;
    private readonly IStaticDataService _staticDataService;

    public EnchantStatsUIRenderer(ISelectedEnchantUIEntryProvider enchantUIEntry, IStaticDataService staticDataService)
    {
      _enchantUIEntry = enchantUIEntry;
      _staticDataService = staticDataService;
    }

    public void RenderUIStats(EnchantStatsUIHolder holder)
    {
      EnchantUIEntryConfig config =
        _staticDataService.GetEnchantUIEntryItemConfig(_enchantUIEntry.TypeId);

      foreach (EnchantStatUIEntry statUIEntry in config.EnchantStatUIEntries)
        holder.CreateStats(statUIEntry.TypeId);
    }
  }
}