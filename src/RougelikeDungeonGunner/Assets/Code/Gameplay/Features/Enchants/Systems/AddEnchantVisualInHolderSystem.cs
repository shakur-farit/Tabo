using System.Collections.Generic;
using Code.Gameplay.Features.Enchants.Factory;
using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Enchants.Systems
{
	public class AddEnchantVisualInHolderSystem : IExecuteSystem
	{
		private readonly IEnchantVisualFactory _enchantVisualFactory;
		private readonly IGroup<GameEntity> _enchants;
		private readonly IGroup<GameEntity> _enchantHolders;
		private readonly List<GameEntity> _buffer = new(8);

		public AddEnchantVisualInHolderSystem(GameContext game, IEnchantVisualFactory enchantVisualFactory)
		{
			_enchantVisualFactory = enchantVisualFactory;
			_enchants = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Enchant,
					GameMatcher.EnchantTypeId)
				.NoneOf(GameMatcher.EnchantVisual));

			_enchantHolders = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.EnchantHolder));
		}

		public void Execute()
		{
			foreach (GameEntity enchant in _enchants.GetEntities(_buffer))
			foreach (GameEntity holder in _enchantHolders)
			{
				_enchantVisualFactory.CreateEnchantVisual(enchant.EnchantTypeId, holder.EnchantHolder);

				Debug.Log("create");

				enchant.isEnchantVisual = true;
			}
		}
	}
}