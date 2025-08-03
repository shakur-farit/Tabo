using System.Collections.Generic;
using Code.Common.Extensions;
using Code.Gameplay.Features.Ammo.Factory;
using Code.Gameplay.Features.Ammo.Services;
using Code.Gameplay.Features.Cooldowns;
using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Ammo.Systems
{
	public class CreateAmmoForHeroPlasmaGunSystem : IExecuteSystem
	{
		private readonly List<GameEntity> _buffer = new(1);

		private readonly IAmmoFactory _ammoFactory;
		private readonly IAmmoDirectionProvider _ammoDirectionProvider;
		private readonly IGroup<GameEntity> _weapons;

		public CreateAmmoForHeroPlasmaGunSystem(
			GameContext game,
			IAmmoFactory ammoFactory,
			IAmmoDirectionProvider ammoDirectionProvider)
		{
			_ammoFactory = ammoFactory;
			_ammoDirectionProvider = ammoDirectionProvider;

			_weapons = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.HeroPlasmaGun,
					GameMatcher.MinPelletsDeviation,
					GameMatcher.MaxPelletsDeviation,
					GameMatcher.CooldownUp,
					GameMatcher.FirePositionTransform,
					GameMatcher.WorldPosition,
					GameMatcher.MagazineNotEmpty,
					GameMatcher.ClosestTargetPosition,
					GameMatcher.Shooting,
					GameMatcher.Precharged,
					GameMatcher.ReadyToShoot));
		}

		public void Execute()
		{
			foreach (GameEntity weapon in _weapons.GetEntities(_buffer))
			{
				_ammoFactory
					.CreateAmmo(AmmoTypeId.LaserBolt, weapon.FirePositionTransform.position)
					.AddProducerId(weapon.Id)
					.ReplaceDirection(GetDirection(weapon))
					.With(x => x.isMoving = true);

				weapon
					.With(x => x.isShot = true)
					.With(x => x.isPrecharged = false)
					.PutOnCooldown(weapon.Cooldown);
			}
		}

		private Vector3 GetDirection(GameEntity weapon) =>
			_ammoDirectionProvider
				.GetDirection(
					weapon.MinPelletsDeviation,
					weapon.MaxPelletsDeviation,
					weapon.FirePositionTransform.right);

	}
}