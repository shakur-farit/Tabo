using System.Collections.Generic;
using Code.Common.Entity;
using Code.Common.Extensions;
using Code.Gameplay.Features.Ammo.Services;
using Code.Gameplay.Features.Cooldowns;
using Code.Sounds.SoundEffects.Factory;
using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.AmmoPattern.Systems
{
	public class CreatePatternForEnemyStarSigilSystem : IExecuteSystem
	{
		private readonly List<GameEntity> _buffer = new(64);

		private readonly IAmmoDirectionProvider _ammoDirectionProvider;
		private readonly ISoundEffectFactory _soundEffectFactory;
		private readonly IGroup<GameEntity> _weapons;

		public CreatePatternForEnemyStarSigilSystem(
			GameContext game,
			IAmmoDirectionProvider ammoDirectionProvider,
			ISoundEffectFactory soundEffectFactory)
		{
			_ammoDirectionProvider = ammoDirectionProvider;
			_soundEffectFactory = soundEffectFactory;
			_ammoDirectionProvider = ammoDirectionProvider;

			_weapons = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.EnemyStarSigil,
					GameMatcher.AmmoTypeId,
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
				CreateGameEntity.Empty()
					.AddAmmoPatternSetup(weapon.AmmoPatternSetup)
					.AddAmmoTypeId(weapon.AmmoTypeId)
					.AddFirePositionTransform(weapon.FirePositionTransform)
					.AddDirection(GetDirection(weapon))
					.AddProducerId(weapon.Id)
					.With(x => x.isSpawnRequest = true);

				weapon
					.With(x => x.isShot = true)
					.PutOnCooldown(weapon.Cooldown);

				if (weapon.hasShotSoundEffectTypeId)
					_soundEffectFactory.CreateSoundEffect(weapon.ShotSoundEffectTypeId);
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