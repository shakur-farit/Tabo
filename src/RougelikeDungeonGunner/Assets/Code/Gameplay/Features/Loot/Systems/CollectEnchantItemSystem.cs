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
					if (HasRoomForNewEnchant(weapon, setup))
					{
						GameEntity enchant = _enchantFactory.CreateEnchant(setup, weapon.Id);
						AddOrCreateNewWeaponEnchants(weapon, enchant, setup);
					}
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

		private bool HasRoomForNewEnchant(GameEntity weapon, StatusSetup newSetup)
		{
			if (!weapon.hasWeaponEnchants)
				return true;

			HashSet<StatusTypeId> existingTypes = new HashSet<StatusTypeId>();
			foreach (StatusSetup setup in weapon.WeaponEnchants.Values)
			{
				existingTypes.Add(setup.StatusTypeId);
			}

			if (existingTypes.Contains(newSetup.StatusTypeId))
				return true;

			// Если меньше двух — можно добавлять
			return existingTypes.Count < 1;
		}

		private void AddOrCreateNewWeaponEnchants(GameEntity weapon, GameEntity enchant, StatusSetup setup)
		{
			if (!weapon.hasWeaponEnchants)
				weapon.AddWeaponEnchants(new Dictionary<int, StatusSetup>());

			if (!weapon.hasWeaponEnchantsQueue)
				weapon.AddWeaponEnchantsQueue(new Queue<StatusTypeId>());

			if (!weapon.hasMaxWeaponEnchantsCount)
				weapon.AddMaxWeaponEnchantsCount(2); // по умолчанию максимум 2

			var enchants = weapon.WeaponEnchants;
			var queue = weapon.WeaponEnchantsQueue;
			var maxCount = weapon.MaxWeaponEnchantsCount;

			// если уже есть такой тип — просто добавить и вернуть (должно быть перехвачено раньше)
			if (queue.Contains(setup.StatusTypeId) == false && queue.Count >= maxCount)
			{
				// удаляем самый старый
				var removedType = queue.Dequeue();

				// находим соответствующий enchantId
				int? toRemove = null;
				foreach (var kvp in enchants)
				{
					if (kvp.Value.StatusTypeId == removedType)
					{
						toRemove = kvp.Key;
						break;
					}
				}

				if (toRemove.HasValue)
				{
					enchants.Remove(toRemove.Value);

					var entity = _game.GetEntityWithId(toRemove.Value);
					entity?.Destroy();
				}
			}

			// Добавляем новый
			enchants[enchant.Id] = setup;
			queue.Enqueue(setup.StatusTypeId);
		}
	}
}