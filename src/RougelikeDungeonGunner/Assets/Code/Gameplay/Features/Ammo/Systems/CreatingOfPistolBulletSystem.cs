using System.Collections.Generic;
using Code.Common.Extensions;
using Code.Gameplay.Features.Ammo.Factory;
using Code.Gameplay.Features.Cooldowns;
using Entitas;

namespace Code.Gameplay.Features.Ammo.Systems
{
	public class CreatingOfPistolBulletSystem : IExecuteSystem
	{
		private readonly List<GameEntity> _buffer = new(1);

		private readonly IAmmoFactory _ammoFactory;
		private readonly IGroup<GameEntity> _weapons;

		public CreatingOfPistolBulletSystem(
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
					GameMatcher.MagazineNotEmpty,
					GameMatcher.CurrentAmmoAmount,
					GameMatcher.ClosestTargetPosition));
		}

		public void Execute()
		{
			foreach (GameEntity weapon in _weapons.GetEntities(_buffer))
			{
				if (weapon.CurrentAmmoAmount > 0)
				{
					_ammoFactory
						.CreateAmmo(AmmoTypeId.PistolBullet ,1, weapon.FirePositionTransform.position)
						.AddProducerId(weapon.Id)
						.ReplaceDirection(weapon.FirePositionTransform.right)
						.With(x => x.isMoving = true);

					weapon.ReplaceCurrentAmmoAmount(weapon.CurrentAmmoAmount - 1);
				}
				else
					weapon.isMagazineNotEmpty = false;

				weapon
					.PutOnCooldown(weapon.Cooldown);
			}
		}
	}
}