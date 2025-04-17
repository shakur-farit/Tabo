using System;
using System.Collections.Generic;
using Code.Gameplay.Features.Enchants.Factory;
using Code.Gameplay.Features.Statuses;
using Entitas;

namespace Code.Gameplay.Features.Loot.Systems
{
	public class CollectEnchantItemSystem : IExecuteSystem
	{
		private const float Tolerance = 0.001f;

		private readonly GameContext _game;
		private readonly IEnchantFactory _enchantFactory;
		private readonly IGroup<GameEntity> _collected;
		private readonly IGroup<GameEntity> _weapons;
		private readonly List<GameEntity> _buffer = new(1);


		public CollectEnchantItemSystem(GameContext game, IEnchantFactory enchantFactory)
		{
			_game = game;
			_enchantFactory = enchantFactory;
			_collected = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Collected,
					GameMatcher.StatusSetups));

			_weapons = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Weapon,
					GameMatcher.Id));
		}

		public void Execute()
		{
			foreach (GameEntity weapon in _weapons.GetEntities(_buffer))
			foreach (GameEntity collected in _collected)
			foreach (StatusSetup setup in collected.StatusSetups)
			{
				if (TryGetExistingEnchantId(weapon, setup, out int enchantId))
				{
					GameEntity enchant = _game.GetEntityWithId(enchantId);

					if (enchant.hasEnchantDuration)
						enchant.ReplaceEnchantTimeLeft(enchant.EnchantDuration);
				}
				else
				{
					GameEntity enchant = _enchantFactory.CreateEnchant(setup, weapon.Id);
					AddOrCreateNewWeaponEnchants(weapon, enchant, setup);
				}
			}
		}

		private bool TryGetExistingEnchantId(GameEntity weapon, StatusSetup setup, out int enchantId)
		{
			if (weapon.hasWeaponEnchants)
			{
				foreach (KeyValuePair<int, StatusSetup> kvp in weapon.WeaponEnchants)
				{
					StatusSetup s = kvp.Value;
					if (Math.Abs(setup.Value - s.Value) < Tolerance &&
					    Math.Abs(setup.Period - s.Period) < Tolerance &&
					    Math.Abs(setup.StatusDuration - s.StatusDuration) < Tolerance &&
					    setup.StatusTypeId == s.StatusTypeId)
					{
						enchantId = kvp.Key;
						return true;
					}
				}
			}

			enchantId = -1;
			return false;
		}

		private void AddOrCreateNewWeaponEnchants(GameEntity weapon, GameEntity enchant, StatusSetup setup)
		{
			if (weapon.hasWeaponEnchants == false)
				weapon.AddWeaponEnchants(new Dictionary<int, StatusSetup>());

			weapon.WeaponEnchants.Add(enchant.Id, setup);
		}
	}
}