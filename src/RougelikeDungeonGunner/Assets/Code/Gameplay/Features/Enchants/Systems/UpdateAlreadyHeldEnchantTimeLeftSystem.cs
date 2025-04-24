using System;
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
		private readonly List<GameEntity> _buffer = new(16);

		public UpdateAlreadyHeldEnchantTimeLeftSystem(GameContext game)
		{
			_game = game;
			_enchants = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Enchant,
					GameMatcher.EnchantDuration,
					GameMatcher.NewCollectedEnchant,
					GameMatcher.EnchantAlreadyHeld));

			_weapons = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Weapon,
					GameMatcher.WeaponEnchants));
		}

		public void Execute()
		{
			foreach (GameEntity enchant in _enchants.GetEntities(_buffer))
			foreach (GameEntity weapon in _weapons)
			{
				int id = GetWeaponEnchantKey(weapon, enchant);

				GameEntity enchantEntity = _game.GetEntityWithId(id);

				enchantEntity.ReplaceEnchantTimeLeft(enchant.EnchantDuration);

				enchant.isNewCollectedEnchant = false;
			}
		}

		private int GetWeaponEnchantKey(GameEntity weapon, GameEntity enchant)
		{
			int key = -1;

			Dictionary<int, StatusSetup> dictionary = weapon.WeaponEnchants;

			foreach (KeyValuePair<int, StatusSetup> pair in dictionary)
			foreach (StatusSetup candidate in enchant.StatusSetups)
			{
				if (AreEqual(pair.Value, candidate))
					key = pair.Key;
			}

			return key;
		}

		private bool AreEqual(StatusSetup a, StatusSetup b)
		{
			const float Tolerance = 0.001f;

			return a.StatusTypeId == b.StatusTypeId &&
			       Math.Abs(a.Value - b.Value) < Tolerance &&
			       Math.Abs(a.StatusDuration - b.StatusDuration) < Tolerance &&
			       Math.Abs(a.Period - b.Period) < Tolerance;
		}
	}
}