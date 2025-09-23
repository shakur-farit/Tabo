using System.Collections.Generic;
using Entitas;

namespace Code.Gameplay.Features.Ammo.Systems
{
	public class CalculateCurrentAmmoCountSystem : IExecuteSystem
	{
		private readonly IGroup<GameEntity> _weapons;
		private readonly List<GameEntity> _buffer = new(1);

		public CalculateCurrentAmmoCountSystem(GameContext game)
		{
			_weapons = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.MagazineSize,
					GameMatcher.CurrentAmmoCount,
					GameMatcher.MagazineNotEmpty,
					GameMatcher.Shot));
		}

		public void Execute()
		{
			foreach (GameEntity weapon in _weapons.GetEntities(_buffer))
			{
				weapon.ReplaceCurrentAmmoCount(weapon.CurrentAmmoCount - 1);

				if (weapon.CurrentAmmoCount <= 0)
				{
					weapon.isMagazineNotEmpty = false;
					weapon.isReloading = true;
				}
			}
		}
	}
}