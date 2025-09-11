using Code.Gameplay.Features.Loot;
using Code.Gameplay.Features.Loot.Factory;
using Code.Gameplay.Features.Loot.Services;
using Entitas;

namespace Code.Gameplay.Features.Enemy.Systems
{
	public class DropLootOnEnemyDeadSystem : IExecuteSystem
	{
		private readonly ILootRandomizerService _randomizer;
		private readonly ILootFactory _lootFactory;
		private readonly IGroup<GameEntity> _enemies;

		public DropLootOnEnemyDeadSystem(
			GameContext game,
			ILootRandomizerService randomizer,
			ILootFactory lootFactory)
		{
			_randomizer = randomizer;
			_lootFactory = lootFactory;
			_enemies = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Enemy,
					GameMatcher.WorldPosition,
					GameMatcher.Dead,
					GameMatcher.ProcessingDeath));
		}

		public void Execute()
		{
			foreach (GameEntity enemy in _enemies)
			{
				LootTypeId? loot = _randomizer.GetLootToDrop(enemy);

				if (loot.HasValue)
					_lootFactory.CreateLoot(loot.Value, enemy.WorldPosition);
			}
		}
	}
}