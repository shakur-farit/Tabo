using System.Collections.Generic;
using Code.Common.Extensions;
using Code.Gameplay.Features.Ammo.Factory;
using Code.Gameplay.Features.Cooldowns;
using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Ammo.Systems
{
	public class PistolBulletSystem : IExecuteSystem
	{
		private readonly List<GameEntity> _buffer = new(1);

		private readonly IAmmoFactory _ammoFactory;
		private readonly IGroup<GameEntity> _weapons;
		private readonly IGroup<GameEntity> _enemies;

		public PistolBulletSystem(
			GameContext game,
			IAmmoFactory ammoFactory)
		{
			_ammoFactory = ammoFactory;

			_weapons = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Pistol,
					GameMatcher.CooldownUp,
					GameMatcher.FirePositionTransform,
					GameMatcher.WorldPosition,
					GameMatcher.Radius,
					GameMatcher.MagazineNotEmpty,
					GameMatcher.CurrentAmmoAmount));

			_enemies = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Enemy,
					GameMatcher.Radius));
		}

		public void Execute()
		{
			foreach (GameEntity weapon in _weapons.GetEntities(_buffer))
			foreach (GameEntity enemy in _enemies)
			{
				float distance = (enemy.WorldPosition - weapon.WorldPosition).magnitude;

				if (distance > weapon.Radius)
					continue;

				_ammoFactory
					.CreatePistolBullet(1, weapon.FirePositionTransform.position)
					.AddProducerId(weapon.Id)
					.ReplaceDirection(weapon.FirePositionTransform.right)
					.With(x => x.isMoving = true);

				if (weapon.CurrentAmmoAmount > 0)
					weapon.ReplaceCurrentAmmoAmount(weapon.CurrentAmmoAmount - 1);
				else
					weapon.isMagazineNotEmpty = false;

				weapon
					.PutOnCooldown(weapon.Cooldown);
			}
		}
	}
}