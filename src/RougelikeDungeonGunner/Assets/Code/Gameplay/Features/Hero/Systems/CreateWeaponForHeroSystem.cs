using System.Collections.Generic;
using Code.Gameplay.Features.Ammo.Factory;
using Code.Gameplay.Features.Weapon;
using Code.Gameplay.Features.Weapon.Factory;
using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Hero.Systems
{
	public class CreateWeaponForHeroSystem : IExecuteSystem
	{
		private readonly IWeaponFactory _weaponFactory;
		private readonly IGroup<GameEntity> _heroes;
		private readonly List<GameEntity> _buffer = new(32);

		public CreateWeaponForHeroSystem(GameContext game, IWeaponFactory weaponFactory)
		{
			_weaponFactory = weaponFactory;

			_heroes = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Hero,
					GameMatcher.ParentTransform,
					GameMatcher.Unweaponed));
		}

		public void Execute()
		{
			foreach (GameEntity hero in _heroes.GetEntities(_buffer))
			{
				_weaponFactory.CreateWeapon(hero.CurrentWeaponTypeId, hero.ParentTransform, 
					Vector2.zero, hero.Id, WeaponOwnerTypeId.Hero);

				hero.isUnweaponed = false;
			}
		}
	}
}