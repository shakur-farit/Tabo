using System.Collections.Generic;
using Code.Common.Extensions;
using Code.Gameplay.Features.Ammo.Services;
using Code.Gameplay.Features.AmmoPattern.Factory;
using Code.Gameplay.Features.Cooldowns;
using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.AmmoPattern.Systems
{
	public class CreatePatternForHeroSniperSystem : IExecuteSystem
	{
		private readonly List<GameEntity> _buffer = new(1);

		private readonly IAmmoPatternFactory _patternFactory;
		private readonly IAmmoDirectionProvider _ammoDirectionProvider;
		private readonly IGroup<GameEntity> _weapons;

		public CreatePatternForHeroSniperSystem(
			GameContext game,
			IAmmoPatternFactory patternFactory,
			IAmmoDirectionProvider ammoDirectionProvider)
		{
			_patternFactory = patternFactory;
			_ammoDirectionProvider = ammoDirectionProvider;

			_weapons = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.HeroSniper,
					GameMatcher.MaxPelletsDeviation,
					GameMatcher.MinPelletsDeviation,
					GameMatcher.CooldownUp,
					GameMatcher.FirePositionTransform,
					GameMatcher.WorldPosition,
					GameMatcher.MagazineNotEmpty,
					GameMatcher.ClosestTargetPosition,
					GameMatcher.Shooting,
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