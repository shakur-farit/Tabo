using System.Collections.Generic;
using Code.Common.Extensions;
using Code.Gameplay.Common.Random;
using Code.Gameplay.Common.Time;
using Code.Gameplay.Features.Ammo.Factory;
using Code.Gameplay.Features.Cooldowns;
using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Ammo.Systems
{
	public class CreatingOfLaserBoltSystem : IExecuteSystem
	{
		private readonly List<GameEntity> _buffer = new(1);

		private readonly IAmmoFactory _ammoFactory;
		private readonly IRandomService _random;
		private readonly IGroup<GameEntity> _weapons;

		public CreatingOfLaserBoltSystem(
			GameContext game,
			IAmmoFactory ammoFactory,
			IRandomService random)
		{
			_ammoFactory = ammoFactory;
			_random = random;

			_weapons = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.LaserBlaster,
					GameMatcher.MinPelletsSpreadAngle,
					GameMatcher.MaxPelletsSpreadAngle,
					GameMatcher.CooldownUp,
					GameMatcher.FirePositionTransform,
					GameMatcher.WorldPosition,
					GameMatcher.MagazineNotEmpty,
					GameMatcher.ClosestTargetPosition,
					GameMatcher.Precharged,
					GameMatcher.ReadyToShoot)); ;
		}

		public void Execute()
		{
			foreach (GameEntity weapon in _weapons.GetEntities(_buffer))
			{
				_ammoFactory
					.CreateAmmo(AmmoTypeId.LaserBolt, 1, weapon.FirePositionTransform.position)
					.AddProducerId(weapon.Id)
					.ReplaceDirection(GetSpreadDirection(weapon))
					.With(x => x.isMoving = true);

				weapon
					.With(x => x.isShot = true)
					.With(x => x.isPrecharged = false)
					.PutOnCooldown(weapon.Cooldown);
			}
		}

		private Vector3 GetSpreadDirection(GameEntity weapon)
			{
				float spreadAngle = _random.Range(weapon.MinPelletsSpreadAngle, weapon.MaxPelletsSpreadAngle);
				return Quaternion.Euler(0, 0, spreadAngle) * weapon.FirePositionTransform.right;
			}
		}
	}