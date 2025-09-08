using System.Collections.Generic;
using Entitas;

namespace Code.Gameplay.Features.Weapon.Systems
{
	public class MarkWeaponReadyToShotSystem : IExecuteSystem
	{
		private readonly IGroup<GameEntity> _weapons;
		private readonly List<GameEntity> _buffer = new(1);

		public MarkWeaponReadyToShotSystem(GameContext game)
		{
			_weapons = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Weapon,
					GameMatcher.Shot));
		}

		public void Execute()
		{
			foreach (GameEntity weapon in _weapons.GetEntities(_buffer))
			{
				weapon.isShot = false;
				weapon.isReadyToShoot = true;
			}
		}
	}
}