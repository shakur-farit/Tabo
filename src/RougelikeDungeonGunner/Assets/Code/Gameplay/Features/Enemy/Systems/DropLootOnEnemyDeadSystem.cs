using Code.Gameplay.Features.Loot;
using Code.Gameplay.Features.Loot.Factory;
using Code.Gameplay.Features.Loot.Services;
using Entitas;

namespace Code.Gameplay.Features.Enemy.Systems
{
	public class DropLootOnEnemyDeadSystem : IExecuteSystem
	{
		private readonly ILootRandomizerService _randomizer;
    private readonly ILootDropChanceService _dropChance;
    private readonly ILootFactory _lootFactory;
		private readonly IGroup<GameEntity> _enemies;

		public DropLootOnEnemyDeadSystem(
			GameContext game,
			ILootRandomizerService randomizer,
			ILootDropChanceService dropChance,
			ILootFactory lootFactory)
		{
			_randomizer = randomizer;
      _dropChance = dropChance;
      _lootFactory = lootFactory;
			_enemies = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Enemy,
					GameMatcher.WorldPosition,
					GameMatcher.LootDropChance,
					GameMatcher.ExcludedLoot,
          GameMatcher.Dead,
					GameMatcher.ProcessingDeath));
		}

		public void Execute()
		{
			foreach (GameEntity enemy in _enemies)
			{
				if(_dropChance.ShouldDrop(enemy.LootDropChance) == false)
					continue;


				LootTypeId? loot = _randomizer.GetRandomLoot(enemy.ExcludedLoot);

				if (loot.HasValue)
					_lootFactory.CreateLoot(loot.Value, enemy.WorldPosition);
			}
		}
	}
}