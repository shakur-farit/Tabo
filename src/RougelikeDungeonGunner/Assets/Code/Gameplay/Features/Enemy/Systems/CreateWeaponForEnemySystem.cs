using System.Collections.Generic;
using Code.Gameplay.Features.Ammo.Factory;
using Code.Gameplay.Features.Weapon;
using Code.Gameplay.Features.Weapon.Factory;
using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Enemy.Systems
{
	public class CreateWeaponForEnemySystem : IExecuteSystem
	{
		private readonly List<GameEntity> _buffer = new(64);
		private readonly IWeaponFactory _weaponFactory;
		private readonly IGroup<GameEntity> _enemies;

		public CreateWeaponForEnemySystem(GameContext game, IWeaponFactory weaponFactory)
		{
			_weaponFactory = weaponFactory;
			_enemies = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Enemy,
					GameMatcher.ParentTransform,
					GameMatcher.CurrentWeaponTypeId,
					GameMatcher.Unweaponed));
		}

		public void Execute()
		{
			foreach (GameEntity enemy in _enemies.GetEntities(_buffer))
			{
				_weaponFactory.CreateWeapon(enemy.CurrentWeaponTypeId, enemy.ParentTransform,
					Vector2.zero, enemy.Id, WeaponOwnerTypeId.Enemy);

				enemy.isUnweaponed = false;
			}
		}
	}
}