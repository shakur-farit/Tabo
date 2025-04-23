using System.Collections.Generic;
using Code.Gameplay.Features.Statuses;
using Entitas;

namespace Code.Gameplay.Features.Loot.Systems
{
	public class AddEnchantToWeaponSystem : IExecuteSystem
	{
		private readonly IGroup<GameEntity> _enchants;
		private readonly IGroup<GameEntity> _weapons;

		public AddEnchantToWeaponSystem(GameContext game)
		{
			_enchants = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Enchant,
					GameMatcher.Id,
					GameMatcher.EnchantDuration,
					GameMatcher.StatusSetups));

			_weapons = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Weapon));
		}

		public void Execute()
		{
			foreach (GameEntity enchant in _enchants)
			foreach (StatusSetup setup in enchant.StatusSetups)
			foreach (GameEntity weapon in _weapons)
			{
				if (weapon.hasWeaponEnchants == false)
					weapon.AddWeaponEnchants(new Dictionary<int, StatusSetup>());

				weapon.WeaponEnchants.Add(enchant.Id, setup);
			}
		}
	}
}