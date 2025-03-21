using System.Collections.Generic;
using Entitas;

namespace Code.Gameplay.Features.Weapon.Systems
{
	public class CleanupUnparentedWeaponsSystem : ICleanupSystem
	{
		private readonly IGroup<GameEntity> _weapons;
		private readonly List<GameEntity> _buffer = new(1);

		public CleanupUnparentedWeaponsSystem(GameContext Game)
		{
			_weapons = Game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Weapon, 
					GameMatcher.Unparented));
		}

		public void Cleanup()
		{
			foreach (GameEntity weapon in _weapons.GetEntities(_buffer)) 
				weapon.isDestructed = true;
		}
	}
}