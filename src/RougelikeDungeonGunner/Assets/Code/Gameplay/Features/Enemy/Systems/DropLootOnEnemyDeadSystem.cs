using Code.Gameplay.Features.Loot;
using Code.Gameplay.Features.Loot.Factory;
using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Enemy.Systems
{
	public class DropLootOnEnemyDeadSystem : IExecuteSystem
	{
		private readonly ILootFactory _lootFactory;
		private readonly IGroup<GameEntity> _enemies;

		public DropLootOnEnemyDeadSystem(GameContext game, ILootFactory lootFactory)
		{
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
				float randomFloat = Random.Range(0, 1f);

				if (randomFloat <= 0.5f)
					_lootFactory.CreateLoot(LootTypeId.CoinItem, enemy.WorldPosition);
				else
					_lootFactory.CreateLoot(LootTypeId.PoisonEnchantItem, enemy.WorldPosition);
			}
		}
	}
}