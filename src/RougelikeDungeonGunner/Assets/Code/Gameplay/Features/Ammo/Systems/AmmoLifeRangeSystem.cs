using System.Collections.Generic;
using Entitas;

namespace Code.Gameplay.Features.Ammo.Systems
{
	public class AmmoLifeRangeSystem : IExecuteSystem
	{
		private readonly List<GameEntity> _buffer = new(32);

		private readonly IGroup<GameEntity> _ammo;
		private readonly IGroup<GameEntity> _firePositionTransforms;
		private readonly IGroup<GameEntity> _weapons;

		public AmmoLifeRangeSystem(GameContext game)
		{
			_ammo = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Ammo,
					GameMatcher.WorldPosition));

			_firePositionTransforms = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.FirePositionTransform));

			_weapons = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Weapon,
					GameMatcher.Radius));
		}

		public void Execute()
		{
			foreach (GameEntity ammo in _ammo.GetEntities(_buffer))
			foreach (GameEntity weapon in _weapons)
			foreach (GameEntity firePositionTransform in _firePositionTransforms)
			{
				float distance = (ammo.WorldPosition - firePositionTransform.FirePositionTransform.position).magnitude;

				if (distance > weapon.Radius)
					ammo.isDestructed = true;
			}
		}
	}
}