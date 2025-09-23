using System.Collections.Generic;
using Entitas;

namespace Code.Gameplay.Features.Weapon.Systems
{
	public class MarkDestructWeaponWithoutOwnerSystem : IExecuteSystem
	{
		private readonly GameContext _game;
		private readonly IGroup<GameEntity> _weapons;
		private readonly List<GameEntity> _buffer = new(64);

		public MarkDestructWeaponWithoutOwnerSystem(GameContext game)
		{
			_game = game;
			_weapons = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.WeaponOwnerId));
		}

		public void Execute()
		{
			foreach (GameEntity weapon in _weapons.GetEntities(_buffer))
			{
				GameEntity owner = _game.GetEntityWithId(weapon.WeaponOwnerId);

				if(owner.isDead)
					weapon.isDestructed = true;
			}
		}
	}
}