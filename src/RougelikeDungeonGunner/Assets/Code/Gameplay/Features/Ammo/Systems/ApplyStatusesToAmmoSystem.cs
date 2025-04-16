using System.Collections.Generic;
using Entitas;

namespace Code.Gameplay.Features.Ammo.Systems
{
	public class ApplyStatusesToAmmoSystem : IExecuteSystem
	{
		private readonly IGroup<GameEntity> _ammo;
		private readonly IGroup<GameEntity> _weapons;
		private readonly List<GameEntity> _buffer = new(32);

		public ApplyStatusesToAmmoSystem(GameContext game)
		{
			_ammo = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Ammo)
				.NoneOf(GameMatcher.StatusSetups));

			_weapons = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Weapon,
					GameMatcher.StatusSetups));
		}

		public void Execute()
		{
			foreach (GameEntity weapon in _weapons)
			foreach (GameEntity ammo in _ammo.GetEntities(_buffer))
			{
				ammo.AddStatusSetups(weapon.StatusSetups);
			}
		}
	}
}