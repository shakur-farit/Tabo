using System.Collections.Generic;
using Entitas;

namespace Code.Meta.UI.Hud.EnchantHolder.Systems
{
	public class AddEnchantVisualToHolderSystem : IExecuteSystem
	{
		private readonly IGroup<GameEntity> _enchantHolders;
		private readonly IGroup<GameEntity> _enchants;
		private readonly List<GameEntity> _buffer = new(2);

		public AddEnchantVisualToHolderSystem(GameContext game)
		{
			_enchants = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.EnchantTypeId)
				.NoneOf(GameMatcher.EnchantUI));

			_enchantHolders = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.EnchantHolder));
		}

		public void Execute()
		{
			foreach (GameEntity enchant in _enchants.GetEntities(_buffer))
			foreach (GameEntity enchantHolder in _enchantHolders)
			{
				enchantHolder.EnchantHolder.AddEnchantVisual(enchant.EnchantTypeId);

				enchant.isEnchantUI = true;
			}
		}
	}
}