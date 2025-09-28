using Code.Gameplay.Features.Loot;
using Code.Gameplay.Features.Loot.Factory;
using Code.Gameplay.Features.Loot.Services;
using Entitas;

namespace Code.Gameplay.Features.Destroyable.Systems
{
  public class DropLootOnDestroyableItemDestroyingSystem : IExecuteSystem
  {
    private readonly ILootRandomizerService _randomizer;
    private readonly ILootDropChanceService _dropChance;
    private readonly ILootFactory _lootFactory;
    private readonly IGroup<GameEntity> _destroyables;

    public DropLootOnDestroyableItemDestroyingSystem(
      GameContext game,
      ILootRandomizerService randomizer,
      ILootDropChanceService dropChance,
      ILootFactory lootFactory)
    {
      _randomizer = randomizer;
      _dropChance = dropChance;
      _lootFactory = lootFactory;
      _destroyables = game.GetGroup(GameMatcher
        .AllOf(
          GameMatcher.DestroyableItem,
          GameMatcher.WorldPosition,
          GameMatcher.LootDropChance,
          GameMatcher.ExcludedLoot,
          GameMatcher.Destroyed));
    }

    public void Execute()
    {
      foreach (GameEntity destroyable in _destroyables)
      {
        if (_dropChance.ShouldDrop(destroyable.LootDropChance) == false)
          continue;


        LootTypeId? loot = _randomizer.GetRandomLoot(destroyable.ExcludedLoot);

        if (loot.HasValue)
          _lootFactory.CreateLoot(loot.Value, destroyable.WorldPosition);
      }
    }
  }
}