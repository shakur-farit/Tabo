using Code.Gameplay.Features.Statuses;

namespace Code.Meta.Features.Shop.EnchantUIEntry
{
  public class SelectedEnchantUIEntryProvider : ISelectedEnchantUIEntryProvider
  {
    private StatusSetup _statusSetup;
    private EnchantUIEntryTypeId _typeId;

    public EnchantUIEntryTypeId TypeId => _typeId;
    public StatusSetup StatusSetup => _statusSetup;

    public void SetStatusSetup(StatusSetup statusSetup) => 
      _statusSetup = statusSetup;

    public void SetTypeId(EnchantUIEntryTypeId typeId) =>
      _typeId = typeId;
  }
}