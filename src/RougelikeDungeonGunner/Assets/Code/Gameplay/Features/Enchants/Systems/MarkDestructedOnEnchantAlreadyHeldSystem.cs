using System.Collections.Generic;
using Entitas;
using Unity.VisualScripting;

namespace Code.Gameplay.Features.Loot.Systems
{
	public class MarkDestructedOnEnchantAlreadyHeldSystem : IExecuteSystem
	{
		private readonly IGroup<GameEntity> _enchants;
		private readonly List<GameEntity> _buffer = new(16);

		public MarkDestructedOnEnchantAlreadyHeldSystem(GameContext game)
		{
			_enchants = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Enchant,
					GameMatcher.EnchantAlreadyHeld));
		}

		public void Execute()
		{
			foreach (GameEntity enchant in _enchants.GetEntities(_buffer))
				enchant.isDestructed = true;
		}
	}
}