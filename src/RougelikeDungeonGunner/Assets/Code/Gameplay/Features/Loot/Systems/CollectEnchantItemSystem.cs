using System.Collections.Generic;
using Entitas;

namespace Code.Gameplay.Features.Loot.Systems
{
	public class CollectEnchantItemSystem : IExecuteSystem
	{
		private readonly IGroup<GameEntity> _collected;
		private readonly IGroup<GameEntity> _weapons;
		private readonly List<GameEntity> _buffer = new(1);

		public CollectEnchantItemSystem(GameContext game)
		{
			_collected = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Collected,
					GameMatcher.EnchantTypeId
					));

			_weapons = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Weapon));
		}

		public void Execute()
		{
			foreach (GameEntity weapon in _weapons.GetEntities(_buffer))
			foreach (GameEntity collected in _collected)
			{
				
			}
		}
	}
}