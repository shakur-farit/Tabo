using System.Collections.Generic;
using Code.Gameplay.Features.Statuses;
using Entitas;

namespace Code.Gameplay.Features.Loot.Systems
{
	public class LimitWeaponEnchantsSystem : IExecuteSystem
	{
		private readonly GameContext _game;
		private readonly IGroup<GameEntity> _weapons;

		public LimitWeaponEnchantsSystem(GameContext game)
		{
			_game = game;
			_weapons = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Weapon, 
					GameMatcher.MaxWeaponEnchantsCount, 
					GameMatcher.WeaponEnchants));
		}

		public void Execute()
		{
			foreach (GameEntity weapon in _weapons)
			{
				Dictionary<int, StatusSetup> enchants = weapon.WeaponEnchants;

				if (enchants.Count <= weapon.MaxWeaponEnchantsCount)
					continue;

				int oldestEnchantId = GetOldestEnchantId(enchants);

				if (TryGetEnchantById(oldestEnchantId, out GameEntity enchantToRemove)) 
					enchantToRemove.isDestructed = true;
			}
		}

		private int GetOldestEnchantId(Dictionary<int, StatusSetup> enchants)
		{
			int oldestId = int.MaxValue;

			foreach (int enchantId in enchants.Keys)
				if (enchantId < oldestId)
					oldestId = enchantId;

			return oldestId;
		}

		private bool TryGetEnchantById(int id, out GameEntity enchant)
		{
			enchant = _game.GetEntityWithId(id);
			return enchant != null && enchant.isEnchant;
		}
	}
}