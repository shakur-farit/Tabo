namespace Code.Gameplay.Features.Loot.Services
{
  public interface ILootDropChanceService
  {
    bool ShouldDrop(float dropChance);
  }
}