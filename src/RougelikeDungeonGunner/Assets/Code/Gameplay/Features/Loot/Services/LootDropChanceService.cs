using Code.Gameplay.Common.Random;

namespace Code.Gameplay.Features.Loot.Services
{
  public class LootDropChanceService : ILootDropChanceService
  {
    private readonly IRandomService _random;

    public LootDropChanceService(IRandomService random) => 
      _random = random;

    public bool ShouldDrop(float dropChance)
    {
      float roll = _random.Range(0f, 100f);
      return roll <= dropChance;
    }
  }
}