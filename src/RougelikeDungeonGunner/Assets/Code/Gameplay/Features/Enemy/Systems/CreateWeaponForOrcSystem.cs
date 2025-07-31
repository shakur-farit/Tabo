using Code.Gameplay.Features.Ammo.Factory;
using Code.Gameplay.Features.Weapon.Factory;
using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Enemy.Systems
{
	public class CreateWeaponForOrcSystem : IExecuteSystem
	{
		private readonly IWeaponFactory _weaponFactory;
		private readonly IGroup<GameEntity> _enemies;

		public CreateWeaponForOrcSystem(GameContext game, IWeaponFactory weaponFactory)
		{
			_weaponFactory = weaponFactory;
			_enemies = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Enemy,
					GameMatcher.Orc));
		}

		public void Execute()
		{
			foreach (GameEntity enemy in _enemies)
			{
				_weaponFactory.CreateWeapon(enemy.CurrentWeaponTypeId, enemy.ParentTransform,
					Vector2.zero, enemy.Id, WeaponOwnerTypeId.Enemy);
			}
		}
	}
}