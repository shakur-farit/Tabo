using System.Collections.Generic;
using Code.Common.Extensions;
using Code.Gameplay.Features.Ammo.Factory;
using Code.Gameplay.Features.Cooldowns;
using Entitas;

namespace Code.Gameplay.Features.Ammo.Systems
{
	public class PistolBulletSystem : IExecuteSystem
	{
		private readonly List<GameEntity> _buffer = new(1);

		private readonly IAmmoFactory _ammoFactory;
		private readonly IGroup<GameEntity> _weapons;
		private readonly IGroup<GameEntity> _enemies;
		private readonly IGroup<GameEntity> _firePositionTransforms;

		public PistolBulletSystem(
			GameContext game,
			IAmmoFactory ammoFactory)
		{
			_ammoFactory = ammoFactory;

			_weapons = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Pistol,
					GameMatcher.CooldownUp));

			_firePositionTransforms = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.FirePositionTransform));

			_enemies = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Enemy));
		}

		public void Execute()
		{
			foreach (GameEntity weapon in _weapons.GetEntities(_buffer))
			foreach (GameEntity firePosition in _firePositionTransforms)
			{
				if (_enemies.count <= 0)
					continue;

				_ammoFactory.CreatePistolBullet(1, firePosition.FirePositionTransform.position)
					.ReplaceDirection(firePosition.FirePositionTransform.right)
					.With(x => x.isMoving = true);

				weapon
					.PutOnCooldown(weapon.Cooldown);
			}
		}
	}
}