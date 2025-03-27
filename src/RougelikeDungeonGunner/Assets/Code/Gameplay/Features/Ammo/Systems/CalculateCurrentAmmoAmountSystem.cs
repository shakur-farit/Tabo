using System.Collections.Generic;
using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Ammo.Systems
{
	public class CalculateCurrentAmmoAmountSystem : IExecuteSystem
	{
		private readonly IGroup<GameEntity> _weapons;
		private readonly List<GameEntity> _buffer = new(1);

		public CalculateCurrentAmmoAmountSystem(GameContext game)
		{
			_weapons = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.MagazineSize,
					GameMatcher.CurrentAmmoAmount,
					GameMatcher.MagazineNotEmpty,
					GameMatcher.Shot));
		}

		public void Execute()
		{
			foreach (GameEntity weapon in _weapons.GetEntities(_buffer))
			{
				weapon.ReplaceCurrentAmmoAmount(weapon.CurrentAmmoAmount - 1);

				if (weapon.CurrentAmmoAmount <= 0)
					weapon.isMagazineNotEmpty = false;
			}
		}
	}

	
}