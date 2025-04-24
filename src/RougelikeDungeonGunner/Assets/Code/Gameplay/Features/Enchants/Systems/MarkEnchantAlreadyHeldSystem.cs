using System;
using System.Collections.Generic;
using Code.Gameplay.Features.Statuses;
using Entitas;

namespace Code.Gameplay.Features.Loot.Systems
{
	public class MarkEnchantAlreadyHeldSystem : IExecuteSystem
	{
		const float Tolerance = 0.001f;


		private readonly IGroup<GameEntity> _weapons;
		private readonly IGroup<GameEntity> _enchants;
		private readonly List<GameEntity> _buffer = new(16);

		public MarkEnchantAlreadyHeldSystem(GameContext game)
		{
			_weapons = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Weapon,
					GameMatcher.WeaponEnchants));

			_enchants = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Enchant,
					GameMatcher.NewCollectedEnchant,
					GameMatcher.StatusSetups));
		}

		public void Execute()
		{
			foreach (GameEntity weapon in _weapons)
			foreach (KeyValuePair<int, StatusSetup> weaponEnchant in weapon.WeaponEnchants)
			foreach (GameEntity enchant in _enchants.GetEntities(_buffer))
			foreach (StatusSetup collectedSetup in enchant.StatusSetups)
			{
				StatusSetup setupOnWeapon = weaponEnchant.Value;

				if (AreEqual(setupOnWeapon, collectedSetup)) 
					enchant.isEnchantAlreadyHeld = true;
			}
		}

		private bool AreEqual(StatusSetup onWeapon, StatusSetup collected)
		{
			return onWeapon.StatusTypeId == collected.StatusTypeId &&
			       Math.Abs(onWeapon.Value - collected.Value) < Tolerance &&
			       Math.Abs(onWeapon.StatusDuration - collected.StatusDuration) < Tolerance &&
			       Math.Abs(onWeapon.Period - collected.Period) < Tolerance;
		}
	}
}