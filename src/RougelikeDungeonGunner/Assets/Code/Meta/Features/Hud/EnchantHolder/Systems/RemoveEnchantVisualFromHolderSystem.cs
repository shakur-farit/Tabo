using System.Collections.Generic;
using Entitas;

namespace Code.Meta.UI.EnchantHolder.Systems
{
	public class RemoveEnchantVisualFromHolderSystem : ReactiveSystem<GameEntity>
	{
		private readonly IGroup<GameEntity> _enchantHolders;

		public RemoveEnchantVisualFromHolderSystem(Contexts contexts) : base(contexts.game) =>
			_enchantHolders = contexts.game.GetGroup(GameMatcher.AllOf(
				GameMatcher.EnchantHolder));

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) =>
			context.CreateCollector(GameMatcher.AllOf(
				GameMatcher.Enchant,
				GameMatcher.EnchantUI,
				GameMatcher.Destructed)
				.NoneOf(GameMatcher.EnchantAlreadyHeld));

		protected override bool Filter(GameEntity enchants) => 
			enchants.isEnchant && enchants.isDestructed && enchants.isEnchantUI && enchants.hasEnchantTypeId;

		protected override void Execute(List<GameEntity> enchants)
		{
			foreach (GameEntity enchant in enchants)
			{
				foreach (GameEntity enchantHolder in _enchantHolders)
					enchantHolder.EnchantHolder.RemoveEnchantVisual(enchant.EnchantTypeId);
			}
		}
	}
}