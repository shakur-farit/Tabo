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
	public class CreatingOfPlasmaBoltSystem : IExecuteSystem
	{
		private readonly List<GameEntity> _buffer = new(1);

		private readonly IAmmoFactory _ammoFactory;
		private readonly IRandomService _random;
		private readonly ITimeService _time;
		private readonly IGroup<GameEntity> _weapons;

		public CreatingOfPlasmaBoltSystem(
			GameContext game,
			IAmmoFactory ammoFactory,
			IRandomService random,
			ITimeService time)
		{
			_ammoFactory = ammoFactory;
			_random = random;
			_time = time;

			_weapons = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.PlasmaGun,
					GameMatcher.MinPelletsSpreadAngle,
					GameMatcher.MaxPelletsSpreadAngle,
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
				while (weapon.PrechargeTime > 0)
				{
					weapon.ReplacePrechargeTime(weapon.PrechargeTime - _time.DeltaTime);
					Debug.Log(weapon.PrechargeTime);
				}

				_ammoFactory
					.CreateAmmo(AmmoTypeId.PlasmaBolt, 1, weapon.FirePositionTransform.position)
					.AddProducerId(weapon.Id)
					.ReplaceDirection(GetSpreadDirection(weapon))
					.With(x => x.isMoving = true);

				weapon
					.With(x => x.isShot = true)
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