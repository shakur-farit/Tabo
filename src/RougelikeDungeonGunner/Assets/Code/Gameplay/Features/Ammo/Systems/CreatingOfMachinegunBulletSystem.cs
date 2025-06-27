using System.Collections.Generic;
using Code.Common.Extensions;
using Code.Gameplay.Common.Random;
using Code.Gameplay.Features.Ammo.Factory;
using Code.Gameplay.Features.Cooldowns;
using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Ammo.Systems
{
	public class CreatingOfMachinegunBulletSystem : IExecuteSystem
	{
		private readonly List<GameEntity> _buffer = new(1);

		private readonly IAmmoFactory _ammoFactory;
		private readonly IAmmoDirectionProvider _ammoDirectionProvider;
		private readonly IGroup<GameEntity> _weapons;

		public CreatingOfMachinegunBulletSystem(
			GameContext game,
			IAmmoFactory ammoFactory,
			IAmmoDirectionProvider ammoDirectionProvider)
		{
			_ammoFactory = ammoFactory;
			_ammoDirectionProvider = ammoDirectionProvider;

			_weapons = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Machinegun, 
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
				_ammoFactory
					.CreateAmmo(AmmoTypeId.Rifle, weapon.FirePositionTransform.position)
					.AddProducerId(weapon.Id)
					.ReplaceDirection(_ammoDirectionProvider.GetDirection(weapon))
					.With(x => x.isMoving = true);

				weapon
					.With(x => x.isShot = true)
					.PutOnCooldown(weapon.Cooldown);
			}
		}
	}
}