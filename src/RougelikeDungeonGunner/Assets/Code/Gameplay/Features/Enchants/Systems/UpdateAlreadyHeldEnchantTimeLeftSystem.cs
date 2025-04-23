using System.Collections.Generic;
using Code.Gameplay.Features.Statuses;
using Entitas;

namespace Code.Gameplay.Features.Loot.Systems
{
	public class UpdateAlreadyHeldEnchantTimeLeftSystem : IExecuteSystem
	{
		private readonly GameContext _game;
		private readonly IGroup<GameEntity> _enchants;
		private readonly IGroup<GameEntity> _weapons;

		public UpdateAlreadyHeldEnchantTimeLeftSystem(GameContext game)
		{
			_game = game;
			_enchants = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Enchant,
					GameMatcher.EnchantAlreadyHeld));

			_weapons = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Weapon,
					GameMatcher.WeaponEnchants));
		}

		public void Execute()
		{
			foreach (GameEntity enchant in _enchants)
			foreach (GameEntity weapon in _weapons)
			{
				int id = GetWeaponEnchantKey(weapon, enchant);

				var enchantEntity = _game.GetEntityWithId(id);

				enchantEntity.ReplaceEnchantTimeLeft(1);
			}
		}

		private int GetWeaponEnchantKey(GameEntity weapon, GameEntity enchant)
		{
			int key = -1;

			Dictionary<int, StatusSetup> dictionary = weapon.WeaponEnchants;

			foreach (KeyValuePair<int, StatusSetup> pair in dictionary)
			{
				StatusSetup setup = pair.Value;
				StatusSetup match = enchant.statusSetups.Value.Find(x => x.StatusTypeId == setup.StatusTypeId);

				if (match != null)
					key = pair.Key;
			}

			return key;
		}
	}
}