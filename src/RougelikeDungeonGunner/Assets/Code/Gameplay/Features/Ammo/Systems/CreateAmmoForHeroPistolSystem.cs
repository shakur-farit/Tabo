using System.Collections.Generic;
using Code.Common.Extensions;
using Code.Gameplay.Features.Ammo.Services;
using Code.Gameplay.Features.Cooldowns;
using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Ammo.Systems
{
	public class CreateAmmoForHeroPistolSystem : IExecuteSystem
	{
		private readonly List<GameEntity> _buffer = new(1);

		private readonly IAmmoSpawnPatternService _spawnPatternService;
		private readonly IAmmoDirectionProvider _ammoDirectionProvider;
		private readonly IGroup<GameEntity> _weapons;

		public CreateAmmoForHeroPistolSystem(
			GameContext game,
			IAmmoSpawnPatternService spawnPatternService,
			IAmmoDirectionProvider ammoDirectionProvider)
		{
			_spawnPatternService = spawnPatternService;
			_ammoDirectionProvider = ammoDirectionProvider;
			_ammoDirectionProvider = ammoDirectionProvider;

			_weapons = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.HeroPistol,
					GameMatcher.AmmoTypeId,
					GameMatcher.AmmoPatternSetup,
					GameMatcher.MinPelletsDeviation,
					GameMatcher.MaxPelletsDeviation,
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
				_spawnPatternService.SpawnAmmoPattern(
					weapon.AmmoPatternSetup, 
					weapon.AmmoTypeId,
					weapon.FirePositionTransform.position,
					GetDirection(weapon), 
					weapon.Id);

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