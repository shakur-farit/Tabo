using System.Collections.Generic;
using Assets.Code.Gameplay.Features.Ammo.Services;
using Assets.Code.Gameplay.Features.AmmoPattern.Factory;
using Assets.Code.Gameplay.Features.Cooldowns;
using Code.Common.Extensions;
using Entitas;
using UnityEngine;

namespace Assets.Code.Gameplay.Features.AmmoPattern.Systems
{
	public class CreatePatternForHeroLaserBlasterSystem : IExecuteSystem
	{
		private readonly List<GameEntity> _buffer = new(1);

		private readonly IAmmoPatternFactory _patternFactory;
		private readonly IAmmoDirectionProvider _ammoDirectionProvider;
		private readonly IGroup<GameEntity> _weapons;

		public CreatePatternForHeroLaserBlasterSystem(
			GameContext game,
			IAmmoPatternFactory patternFactory,
			IAmmoDirectionProvider ammoDirectionProvider)
		{
			_patternFactory = patternFactory;
			_ammoDirectionProvider = ammoDirectionProvider;

			_weapons = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.HeroLaserBlaster,
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
				GameEntity pattern = _patternFactory.CreatePattern(weapon.AmmoPatternSetup, weapon.AmmoTypeId,
					weapon.FirePositionTransform.position, GetDirection(weapon));

				pattern
					.AddProducerId(weapon.Id);

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