using Code.Gameplay.Features.Statuses;

namespace Code.Meta.Features.Shop.EnchantUIEntry.Services
{
  public interface ISelectedEnchantUIEntryProvider
  {
    EnchantUIEntryTypeId TypeId { get; }
    StatusSetup StatusSetup { get; }
    void SetStatusSetup(StatusSetup statusSetup);
    void SetTypeId(EnchantUIEntryTypeId typeId);
  }
}