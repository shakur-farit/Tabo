using System.Collections.Generic;
using Code.Gameplay.Features.Enchants.Factory;
using Code.Gameplay.Features.Statuses;
using Entitas;

namespace Code.Gameplay.Features.Loot.Systems
{
	public class CollectEnchantItemSystem : IExecuteSystem
	{
		private readonly IEnchantFactory _enchantFactory;
		private readonly IGroup<GameEntity> _collected;
		private readonly IGroup<GameEntity> _heroes;
		private readonly List<GameEntity> _buffer = new(1);

		public CollectEnchantItemSystem(GameContext game, IEnchantFactory enchantFactory)
		{
			_enchantFactory = enchantFactory;
			_collected = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Collected,
					GameMatcher.StatusSetups));

			_heroes = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Hero,
					GameMatcher.Id));
		}

		public void Execute()
		{
			foreach (GameEntity hero in _heroes.GetEntities(_buffer))
			foreach (GameEntity collected in _collected)
			foreach (StatusSetup setup in collected.StatusSetups)
				_enchantFactory.CreateEnchant(setup, hero.Id);
		}
	}
}