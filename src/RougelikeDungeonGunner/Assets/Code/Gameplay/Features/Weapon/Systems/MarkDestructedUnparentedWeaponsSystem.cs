using System.Collections.Generic;
using Entitas;

namespace Code.Gameplay.Features.Weapon.Systems
{
	public class MarkDestructedUnparentedWeaponsSystem : IExecuteSystem
	{
		private readonly IGroup<GameEntity> _weapons;
		private readonly List<GameEntity> _buffer = new(1);

		public MarkDestructedUnparentedWeaponsSystem(GameContext game)
		{
			_weapons = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Weapon, 
					GameMatcher.Unparented));
		}

		public void Execute()
		{
			foreach (GameEntity weapon in _weapons.GetEntities(_buffer)) 
				weapon.isDestructed = true;
		}
	}
}