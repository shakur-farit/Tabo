using Code.Meta.UI.Hud.EnchantHolder.Behaviours;
using Entitas;

namespace Code.Meta.UI.Hud.EnchantHolder.Systems
{
	public class UpdateEnchantTimeLeftVisualSystem : IExecuteSystem
	{
		private readonly IGroup<GameEntity> _enchants;
		private readonly IGroup<GameEntity> _enchantHolders;

		public UpdateEnchantTimeLeftVisualSystem(GameContext game)
		{
			_enchants = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.EnchantTypeId,
					GameMatcher.EnchantUI,
					GameMatcher.EnchantTimeLeft));

			_enchantHolders = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.EnchantHolder));
		}

		public void Execute()
		{
			foreach (GameEntity enchant in _enchants)
			foreach (GameEntity enchantHolder in _enchantHolders)
			{
				if (EnchantVisualByType(enchantHolder, enchant) != null)
				{
					EnchantUI enchantUI = EnchantVisualByType(enchantHolder, enchant);
					enchantUI.UpdateTimeLeftText(enchant.EnchantTimeLeft);
				}
			}
		}

		private static EnchantUI EnchantVisualByType(GameEntity enchantHolder, GameEntity enchant) => 
			enchantHolder.EnchantHolder.EnchantVisuals.Find(e => e.Id == enchant.EnchantTypeId);
	}
}