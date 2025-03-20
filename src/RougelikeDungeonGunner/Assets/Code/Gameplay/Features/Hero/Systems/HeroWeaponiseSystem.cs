using System.Collections.Generic;
using Code.Gameplay.Features.Weapon.Factory;
using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Hero.Systems
{
	public class HeroWeaponiseSystem : IInitializeSystem
	{
		private readonly IWeaponFactory _weaponFactory;
		private readonly IGroup<GameEntity> _heroes;
		private readonly List<GameEntity> _buffer = new(32);

		public HeroWeaponiseSystem(GameContext game, IWeaponFactory weaponFactory)
		{
			_weaponFactory = weaponFactory;

			_heroes = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Hero,
					GameMatcher.CurrentWeaponType));
		}

		public void Initialize()
		{
			foreach (GameEntity hero in _heroes.GetEntities(_buffer))
			{
				GameEntity weapon = _weaponFactory.CreateWeapon(hero.CurrentWeaponType, 1, hero, Vector2.zero);

				hero.ReplaceCurrentWeaponId(weapon.Id);
			}
		}
	}
}